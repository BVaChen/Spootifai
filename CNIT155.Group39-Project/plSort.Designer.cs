namespace CNIT155.Group39_Project
{
    partial class plSort
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
            this.btnAsc = new System.Windows.Forms.Button();
            this.btnDsc = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.radTitle = new System.Windows.Forms.RadioButton();
            this.radDuration = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.radArtist = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // btnAsc
            // 
            this.btnAsc.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAsc.Location = new System.Drawing.Point(197, 36);
            this.btnAsc.Name = "btnAsc";
            this.btnAsc.Size = new System.Drawing.Size(75, 23);
            this.btnAsc.TabIndex = 0;
            this.btnAsc.Text = "Ascending";
            this.btnAsc.UseVisualStyleBackColor = true;
            this.btnAsc.Click += new System.EventHandler(this.btnAsc_Click);
            // 
            // btnDsc
            // 
            this.btnDsc.Location = new System.Drawing.Point(197, 65);
            this.btnDsc.Name = "btnDsc";
            this.btnDsc.Size = new System.Drawing.Size(75, 23);
            this.btnDsc.TabIndex = 1;
            this.btnDsc.Text = "Descending";
            this.btnDsc.UseVisualStyleBackColor = true;
            this.btnDsc.Click += new System.EventHandler(this.btnDsc_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(197, 94);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // radTitle
            // 
            this.radTitle.AutoSize = true;
            this.radTitle.Location = new System.Drawing.Point(16, 42);
            this.radTitle.Name = "radTitle";
            this.radTitle.Size = new System.Drawing.Size(45, 17);
            this.radTitle.TabIndex = 3;
            this.radTitle.TabStop = true;
            this.radTitle.Text = "Title";
            this.radTitle.UseVisualStyleBackColor = true;
            // 
            // radDuration
            // 
            this.radDuration.AutoSize = true;
            this.radDuration.Location = new System.Drawing.Point(16, 65);
            this.radDuration.Name = "radDuration";
            this.radDuration.Size = new System.Drawing.Size(65, 17);
            this.radDuration.TabIndex = 4;
            this.radDuration.TabStop = true;
            this.radDuration.Text = "Duration";
            this.radDuration.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Sort the playlist by one of the following criteria.";
            // 
            // radArtist
            // 
            this.radArtist.AutoSize = true;
            this.radArtist.Location = new System.Drawing.Point(16, 89);
            this.radArtist.Name = "radArtist";
            this.radArtist.Size = new System.Drawing.Size(48, 17);
            this.radArtist.TabIndex = 6;
            this.radArtist.TabStop = true;
            this.radArtist.Text = "Artist";
            this.radArtist.UseVisualStyleBackColor = true;
            // 
            // plSort
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(284, 125);
            this.Controls.Add(this.radArtist);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radDuration);
            this.Controls.Add(this.radTitle);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnDsc);
            this.Controls.Add(this.btnAsc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "plSort";
            this.Text = "Sort Playlist";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAsc;
        private System.Windows.Forms.Button btnDsc;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.RadioButton radTitle;
        private System.Windows.Forms.RadioButton radDuration;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radArtist;
    }
}