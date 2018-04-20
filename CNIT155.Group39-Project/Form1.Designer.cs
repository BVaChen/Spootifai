namespace CNIT155.Group39_Project
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.btnImport = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnForward = new System.Windows.Forms.Button();
            this.btnBackward = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.trkPlayTime = new System.Windows.Forms.TrackBar();
            this.trkVolume = new System.Windows.Forms.TrackBar();
            this.lblVol = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.radRpt1ce = new System.Windows.Forms.RadioButton();
            this.radRptList = new System.Windows.Forms.RadioButton();
            this.radShuffle = new System.Windows.Forms.RadioButton();
            this.radDefaultPlay = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnSort = new System.Windows.Forms.Button();
            this.lstPlaylist = new System.Windows.Forms.ListBox();
            this.tmrTimeTrack = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.trkPlayTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkVolume)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.CausesValidation = false;
            this.label1.Font = new System.Drawing.Font("Magneto", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(4, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "MUSIC PLAYER 39";
            // 
            // btnImport
            // 
            this.btnImport.AutoEllipsis = true;
            this.btnImport.BackColor = System.Drawing.Color.MediumOrchid;
            this.btnImport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnImport.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnImport.Location = new System.Drawing.Point(680, 109);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(52, 27);
            this.btnImport.TabIndex = 1;
            this.btnImport.Text = "Import";
            this.btnImport.UseVisualStyleBackColor = false;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.Color.DarkMagenta;
            this.btnPlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlay.Location = new System.Drawing.Point(252, 5);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(35, 23);
            this.btnPlay.TabIndex = 2;
            this.btnPlay.Text = "⏯";
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnForward
            // 
            this.btnForward.BackColor = System.Drawing.Color.Violet;
            this.btnForward.Location = new System.Drawing.Point(363, 5);
            this.btnForward.Name = "btnForward";
            this.btnForward.Size = new System.Drawing.Size(30, 23);
            this.btnForward.TabIndex = 2;
            this.btnForward.Text = "⏭";
            this.btnForward.UseVisualStyleBackColor = false;
            this.btnForward.Click += new System.EventHandler(this.btnForward_Click);
            // 
            // btnBackward
            // 
            this.btnBackward.BackColor = System.Drawing.Color.Violet;
            this.btnBackward.Location = new System.Drawing.Point(328, 5);
            this.btnBackward.Name = "btnBackward";
            this.btnBackward.Size = new System.Drawing.Size(29, 23);
            this.btnBackward.TabIndex = 2;
            this.btnBackward.Text = "⏮";
            this.btnBackward.UseVisualStyleBackColor = false;
            this.btnBackward.Click += new System.EventHandler(this.btnBackward_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(679, 177);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(52, 23);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(680, 142);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(52, 23);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnStop
            // 
            this.btnStop.BackColor = System.Drawing.Color.Violet;
            this.btnStop.Location = new System.Drawing.Point(293, 5);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(29, 23);
            this.btnStop.TabIndex = 2;
            this.btnStop.Text = "◼";
            this.btnStop.UseVisualStyleBackColor = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(614, -220);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(134, 20);
            this.textBox1.TabIndex = 4;
            // 
            // trkPlayTime
            // 
            this.trkPlayTime.Location = new System.Drawing.Point(239, 44);
            this.trkPlayTime.Maximum = 1000;
            this.trkPlayTime.Name = "trkPlayTime";
            this.trkPlayTime.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.trkPlayTime.Size = new System.Drawing.Size(333, 45);
            this.trkPlayTime.TabIndex = 6;
            this.trkPlayTime.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trkPlayTime.Scroll += new System.EventHandler(this.trkPlayTime_Scroll);
            // 
            // trkVolume
            // 
            this.trkVolume.Location = new System.Drawing.Point(51, 44);
            this.trkVolume.Maximum = 100;
            this.trkVolume.Name = "trkVolume";
            this.trkVolume.Size = new System.Drawing.Size(127, 45);
            this.trkVolume.TabIndex = 7;
            this.trkVolume.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trkVolume.ValueChanged += new System.EventHandler(this.trkVolume_ValueChanged);
            // 
            // lblVol
            // 
            this.lblVol.AutoSize = true;
            this.lblVol.Location = new System.Drawing.Point(12, 49);
            this.lblVol.Name = "lblVol";
            this.lblVol.Size = new System.Drawing.Size(42, 13);
            this.lblVol.TabIndex = 8;
            this.lblVol.Text = "Volume";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(216, 49);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(30, 13);
            this.lblTime.TabIndex = 9;
            this.lblTime.Text = "Time";
            // 
            // radRpt1ce
            // 
            this.radRpt1ce.AutoSize = true;
            this.radRpt1ce.Location = new System.Drawing.Point(6, 42);
            this.radRpt1ce.Name = "radRpt1ce";
            this.radRpt1ce.Size = new System.Drawing.Size(93, 17);
            this.radRpt1ce.TabIndex = 11;
            this.radRpt1ce.TabStop = true;
            this.radRpt1ce.Text = "Repeat (track)";
            this.radRpt1ce.UseVisualStyleBackColor = true;
            // 
            // radRptList
            // 
            this.radRptList.AutoSize = true;
            this.radRptList.Location = new System.Drawing.Point(6, 65);
            this.radRptList.Name = "radRptList";
            this.radRptList.Size = new System.Drawing.Size(100, 17);
            this.radRptList.TabIndex = 12;
            this.radRptList.TabStop = true;
            this.radRptList.Text = "Repeat (playlist)";
            this.radRptList.UseVisualStyleBackColor = true;
            // 
            // radShuffle
            // 
            this.radShuffle.AutoSize = true;
            this.radShuffle.Location = new System.Drawing.Point(6, 88);
            this.radShuffle.Name = "radShuffle";
            this.radShuffle.Size = new System.Drawing.Size(58, 17);
            this.radShuffle.TabIndex = 13;
            this.radShuffle.TabStop = true;
            this.radShuffle.Text = "Shuffle";
            this.radShuffle.UseVisualStyleBackColor = true;
            // 
            // radDefaultPlay
            // 
            this.radDefaultPlay.AutoSize = true;
            this.radDefaultPlay.Location = new System.Drawing.Point(6, 19);
            this.radDefaultPlay.Name = "radDefaultPlay";
            this.radDefaultPlay.Size = new System.Drawing.Size(59, 17);
            this.radDefaultPlay.TabIndex = 14;
            this.radDefaultPlay.TabStop = true;
            this.radDefaultPlay.Text = "Default";
            this.radDefaultPlay.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radRpt1ce);
            this.groupBox1.Controls.Add(this.radShuffle);
            this.groupBox1.Controls.Add(this.radDefaultPlay);
            this.groupBox1.Controls.Add(this.radRptList);
            this.groupBox1.Location = new System.Drawing.Point(8, 79);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(119, 113);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Playback Mode";
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(679, 79);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(53, 24);
            this.btnOpen.TabIndex = 18;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnSort
            // 
            this.btnSort.Location = new System.Drawing.Point(8, 198);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(57, 23);
            this.btnSort.TabIndex = 21;
            this.btnSort.Text = "Sort...";
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click_1);
            // 
            // lstPlaylist
            // 
            this.lstPlaylist.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstPlaylist.FormattingEnabled = true;
            this.lstPlaylist.ItemHeight = 14;
            this.lstPlaylist.Location = new System.Drawing.Point(133, 79);
            this.lstPlaylist.Name = "lstPlaylist";
            this.lstPlaylist.Size = new System.Drawing.Size(540, 158);
            this.lstPlaylist.TabIndex = 22;
            this.lstPlaylist.DoubleClick += new System.EventHandler(this.lstPlaylist_DoubleClick);
            // 
            // tmrTimeTrack
            // 
            this.tmrTimeTrack.Enabled = true;
            this.tmrTimeTrack.Interval = 500;
            this.tmrTimeTrack.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(738, 251);
            this.Controls.Add(this.lstPlaylist);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblVol);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnBackward);
            this.Controls.Add(this.btnForward);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.trkPlayTime);
            this.Controls.Add(this.trkVolume);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Spootifai";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trkPlayTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkVolume)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnForward;
        private System.Windows.Forms.Button btnBackward;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TrackBar trkPlayTime;
        private System.Windows.Forms.TrackBar trkVolume;
        private System.Windows.Forms.Label lblVol;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.RadioButton radRpt1ce;
        private System.Windows.Forms.RadioButton radRptList;
        private System.Windows.Forms.RadioButton radShuffle;
        private System.Windows.Forms.RadioButton radDefaultPlay;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.ListBox lstPlaylist;
        private System.Windows.Forms.Timer tmrTimeTrack;
    }
}

