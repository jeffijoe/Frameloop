﻿namespace Frameloop
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnBrowse = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.lblFps = new System.Windows.Forms.ToolStripLabel();
            this.txtFps = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnTogglePlay = new System.Windows.Forms.ToolStripButton();
            this.imageViewer = new System.Windows.Forms.PictureBox();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.tbPosition = new System.Windows.Forms.TrackBar();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageViewer)).BeginInit();
            this.statusStrip.SuspendLayout();
            this.pnlBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbPosition)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(895, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnBrowse
            // 
            this.btnBrowse.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnBrowse.Image = ((System.Drawing.Image)(resources.GetObject("btnBrowse.Image")));
            this.btnBrowse.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(58, 22);
            this.btnBrowse.Text = "Browse...";
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // lblFps
            // 
            this.lblFps.Name = "lblFps";
            this.lblFps.Size = new System.Drawing.Size(60, 22);
            this.lblFps.Text = "Framerate";
            // 
            // txtFps
            // 
            this.txtFps.Name = "txtFps";
            this.txtFps.Size = new System.Drawing.Size(100, 25);
            this.txtFps.Text = "24";
            this.txtFps.TextChanged += new System.EventHandler(this.txtFps_TextChanged);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // btnTogglePlay
            // 
            this.btnTogglePlay.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnTogglePlay.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnTogglePlay.Image = ((System.Drawing.Image)(resources.GetObject("btnTogglePlay.Image")));
            this.btnTogglePlay.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnTogglePlay.Name = "btnTogglePlay";
            this.btnTogglePlay.Size = new System.Drawing.Size(33, 22);
            this.btnTogglePlay.Text = "Play";
            this.btnTogglePlay.Click += new System.EventHandler(this.btnTogglePlay_Click);
            // 
            // imageViewer
            // 
            this.imageViewer.BackColor = System.Drawing.Color.White;
            this.imageViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imageViewer.Location = new System.Drawing.Point(0, 25);
            this.imageViewer.Name = "imageViewer";
            this.imageViewer.Size = new System.Drawing.Size(895, 435);
            this.imageViewer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imageViewer.TabIndex = 2;
            this.imageViewer.TabStop = false;
            // 
            // statusStrip
            // 
            this.statusStrip.Location = new System.Drawing.Point(0, 438);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(895, 22);
            this.statusStrip.TabIndex = 3;
            this.statusStrip.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(54, 17);
            this.lblStatus.Text = "Waiting..";
            // 
            // pnlBottom
            // 
            this.pnlBottom.Controls.Add(this.tbPosition);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(0, 393);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(895, 45);
            this.pnlBottom.TabIndex = 4;
            // 
            // tbPosition
            // 
            this.tbPosition.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbPosition.Location = new System.Drawing.Point(0, 0);
            this.tbPosition.Minimum = 1;
            this.tbPosition.Name = "tbPosition";
            this.tbPosition.Size = new System.Drawing.Size(895, 45);
            this.tbPosition.TabIndex = 0;
            this.tbPosition.Value = 1;
            this.tbPosition.ValueChanged += new System.EventHandler(this.tbPosition_ValueChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 460);
            this.Controls.Add(this.pnlBottom);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.imageViewer);
            this.Controls.Add(this.toolStrip1);
            this.Name = "MainForm";
            this.Text = "Frameloop";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageViewer)).EndInit();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.pnlBottom.ResumeLayout(false);
            this.pnlBottom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbPosition)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnBrowse;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnTogglePlay;
        private System.Windows.Forms.PictureBox imageViewer;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.TrackBar tbPosition;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel lblFps;
        private System.Windows.Forms.ToolStripTextBox txtFps;
    }
}

