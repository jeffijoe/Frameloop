using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Frameloop
{
    public partial class MainForm : Form
    {
        private MainViewModel vm;

        public MainForm()
        {
            InitializeComponent();
            // Viewmodel setup
            this.vm = new MainViewModel();
            this.vm.OnFolderChange += () => Dispatch(this.OnFolderChange);
            this.vm.OnTogglePlay += () => Dispatch(this.OnTogglePlay);
            this.vm.OnFrameChange += () => Dispatch(this.OnFrameChange);
            this.vm.OnFrameRateChange += () => Dispatch(this.OnFrameRateChange);
            this.vm.OnFramesLoaded += () => Dispatch(this.OnFramesLoaded);
            this.vm.OnVisibleControlsChange += () => Dispatch(this.OnVisibleControlsChange);

            // UI setup
            this.miToolbar.Click += (e, s) => this.vm.ToggleControl(Control.Toolbar);
            this.miToggleTracker.Click += (e, s) => this.vm.ToggleControl(Control.Tracker);
            this.exitToolStripMenuItem.Click += (e, s) => Application.Exit();
            this.aboutToolStripMenuItem.Click += (e, s) =>
            {
                AboutForm.Show();
            };

            // Sync initial UI state.
            this.OnFrameRateChange();
            this.OnTogglePlay();
            this.OnFolderChange();
            this.OnFrameChange();
            this.OnVisibleControlsChange();
        }

        private void OnVisibleControlsChange()
        {
            var tracker = this.vm.IsControlVisible(Control.Tracker);
            var toolbar = this.vm.IsControlVisible(Control.Toolbar);

            this.miToggleTracker.Checked = tracker;
            this.pnlBottom.Visible = tracker;

            this.mainToolStrip.Visible = toolbar;
            this.miToolbar.Checked = toolbar;
        }

        private void OnFramesLoaded()
        {
            this.tbPosition.Maximum = this.vm.FrameCount;
        }

        private void OnFrameRateChange()
        {
            var newValue = this.vm.FrameRate.ToString();
            if (this.txtFps.Text == newValue)
            {
                return;
            }

            this.txtFps.Text = newValue;
        }

        private void OnFrameChange()
        {
            this.imageViewer.Image = this.vm.GetCurrentFrame();
            if (this.vm.FrameCount == 0)
            {
                return;
            }

            this.lblStatus.Text = $"Frame #{this.vm.CurrentFrame} / {this.vm.FrameCount}";
            if (this.vm.CurrentFrame != 0)
            {
                this.tbPosition.Value = this.vm.CurrentFrame;
            }
        }

        private void OnTogglePlay()
        {
            this.btnTogglePlay.Text = this.vm.Playing ? "Stop" : "Play";
            this.tbPosition.Enabled = !this.vm.Playing;
        }

        private void OnFolderChange()
        {
            this.Text = string.IsNullOrEmpty(this.vm.Folder) ? "Frameloop" : $"Frameloop ({this.vm.Folder})";
            this.btnTogglePlay.Enabled = !string.IsNullOrEmpty(this.vm.Folder);
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void Dispatch(Action action)
        {
            this.Invoke(action);
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            var dlg = new FolderBrowserDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                this.vm.ChangeFolder(dlg.SelectedPath);
            }
        }

        private void btnTogglePlay_Click(object sender, EventArgs e)
        {
            this.vm.TogglePlay();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.vm.Quit();
        }

        private void txtFps_TextChanged(object sender, EventArgs e)
        {
            int fps;
            if (this.txtFps.Text == string.Empty)
            {
                return;
            }

            if (int.TryParse(this.txtFps.Text, out fps))
            {
                this.vm.ChangeFrameRate(fps);
            }
            else
            {
                this.OnFrameRateChange();
            }
        }

        private void tbPosition_ValueChanged(object sender, EventArgs e)
        {
            if (this.tbPosition.Value == this.vm.CurrentFrame)
            {
                return;
            }

            this.vm.SetFrame(this.tbPosition.Value);
        }

        private void MainForm_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                this.vm.TogglePlay();
            }
        }
    }
}
