using Frameloop.Properties;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Frameloop
{
    public class MainViewModel
    {
        private FileSystemWatcher watcher;
        private CancellationTokenSource cts;
        private Task task;
        private Bitmap defaultFrame;

        public event Action OnTogglePlay;
        public event Action OnFramesLoaded;
        public event Action OnFrameRateChange;
        public event Action OnFrameChange;
        public event Action OnFolderChange;

        public int CurrentFrame { get; private set; }

        public int FrameCount => this.Frames.Count;

        public int FrameRate { get; private set; } = 24;

        public string Folder { get; private set; }

        public bool Playing { get; private set; }

        public bool Loading { get; private set; }

        public List<Bitmap> Frames { get; private set; }

        public MainViewModel()
        {
            this.Frames = new List<Bitmap>();
            //this.defaultFrame = Resources.Frameloop;
            this.watcher = new FileSystemWatcher();
            this.watcher.Created += (sender, evt) => this.LoadFrames();
            this.watcher.Changed += (sender, evt) => this.LoadFrames();
            this.watcher.Deleted += (sender, evt) => this.LoadFrames();
            this.cts = new CancellationTokenSource();
            this.task = new Task(() => this.AdvanceFrames(), this.cts.Token, TaskCreationOptions.LongRunning);
            this.task.Start();
        }

        public void ChangeFolder(string newFolder)
        {
            this.Folder = newFolder;
            this.LoadFrames();
            this.watcher.Path = newFolder;
            this.watcher.EnableRaisingEvents = true;
            this.OnFolderChange?.Invoke();
        }

        public void TogglePlay()
        {
            this.Playing = !this.Playing;
            this.OnTogglePlay?.Invoke();
        }

        public void LoadFrames()
        {
            this.Loading = true;
            this.CurrentFrame = 0;
            this.Frames.Clear();
            var files = Directory.GetFiles(this.Folder);
            var frames = files.Select(f => new Bitmap(f));
            this.Frames.InsertRange(0, frames);
            this.Loading = false;
            this.OnFramesLoaded?.Invoke();
            this.SetFrame(1);
        }

        internal void ChangeFrameRate(int frameRate)
        {
            if (this.FrameRate == frameRate)
            {
                return;
            }

            this.FrameRate = frameRate;
            this.OnFrameRateChange?.Invoke();
        }

        public async Task AdvanceFrames ()
        {
            while (!this.cts.Token.IsCancellationRequested)
            {
                if (this.Playing && !this.Loading)
                {
                    this.SetFrame(this.CurrentFrame + 1 > this.FrameCount ? 1 : this.CurrentFrame + 1);
                }
                
                await Task.Delay(1000 / this.FrameRate);
            }
        }

        public void SetFrame(int frame)
        {
            if (this.FrameCount == 0)
            {
                return;
            }

            this.CurrentFrame = Math.Min(this.FrameCount, frame);
            this.OnFrameChange();
        }

        public Bitmap GetFrame (int frameNumber)
        {
            if (this.CurrentFrame == 0 || this.FrameCount == 0)
            {
                return this.defaultFrame;
            }

            return this.Frames[frameNumber - 1];
        }

        public Bitmap GetCurrentFrame()
        {
            return this.GetFrame(this.CurrentFrame);
        }

        public void Quit ()
        {
            this.cts.Cancel();
        }
    }
}
