namespace YoutubeDownloaderv2
{
    partial class main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main));
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.urlInput = new System.Windows.Forms.TextBox();
            this.pTitle = new System.Windows.Forms.Label();
            this.loadData = new System.Windows.Forms.Button();
            this.downloadMP4 = new System.Windows.Forms.Button();
            this.log = new System.Windows.Forms.TextBox();
            this.changeDirectory = new System.Windows.Forms.Button();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.downloadMP3 = new System.Windows.Forms.Button();
            this.creditsB = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.vDisplay = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(163, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Log";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(143, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Enter URL";
            // 
            // urlInput
            // 
            this.urlInput.BackColor = System.Drawing.Color.Black;
            this.urlInput.ForeColor = System.Drawing.Color.Red;
            this.urlInput.Location = new System.Drawing.Point(71, 59);
            this.urlInput.Name = "urlInput";
            this.urlInput.Size = new System.Drawing.Size(213, 20);
            this.urlInput.TabIndex = 2;
            // 
            // pTitle
            // 
            this.pTitle.AutoSize = true;
            this.pTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pTitle.ForeColor = System.Drawing.Color.Red;
            this.pTitle.Location = new System.Drawing.Point(68, 9);
            this.pTitle.Name = "pTitle";
            this.pTitle.Size = new System.Drawing.Size(237, 20);
            this.pTitle.TabIndex = 3;
            this.pTitle.Text = "No BS YouTube Downloader";
            // 
            // loadData
            // 
            this.loadData.BackColor = System.Drawing.Color.Black;
            this.loadData.ForeColor = System.Drawing.Color.Red;
            this.loadData.Location = new System.Drawing.Point(129, 85);
            this.loadData.Name = "loadData";
            this.loadData.Size = new System.Drawing.Size(100, 23);
            this.loadData.TabIndex = 4;
            this.loadData.Text = "Load Video Info";
            this.loadData.UseVisualStyleBackColor = false;
            this.loadData.Click += new System.EventHandler(this.loadData_Click);
            // 
            // downloadMP4
            // 
            this.downloadMP4.BackColor = System.Drawing.Color.Black;
            this.downloadMP4.ForeColor = System.Drawing.Color.Red;
            this.downloadMP4.Location = new System.Drawing.Point(24, 393);
            this.downloadMP4.Name = "downloadMP4";
            this.downloadMP4.Size = new System.Drawing.Size(99, 43);
            this.downloadMP4.TabIndex = 5;
            this.downloadMP4.Text = "Download MP4";
            this.downloadMP4.UseVisualStyleBackColor = false;
            this.downloadMP4.Click += new System.EventHandler(this.downloadMP4_Click);
            // 
            // log
            // 
            this.log.BackColor = System.Drawing.Color.Black;
            this.log.ForeColor = System.Drawing.Color.Red;
            this.log.Location = new System.Drawing.Point(12, 129);
            this.log.Multiline = true;
            this.log.Name = "log";
            this.log.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.log.Size = new System.Drawing.Size(346, 258);
            this.log.TabIndex = 6;
            this.log.Text = "Welcome To TSYD. The default download directory is the Desktop, but you can chang" +
    "e the download directory to whatever you want. Thank you for using this applicat" +
    "ion!\r\n\r\n";
            this.log.KeyDown += new System.Windows.Forms.KeyEventHandler(this.log_KeyDown);
            this.log.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.log_KeyPress);
            // 
            // changeDirectory
            // 
            this.changeDirectory.BackColor = System.Drawing.Color.Black;
            this.changeDirectory.ForeColor = System.Drawing.Color.Red;
            this.changeDirectory.Location = new System.Drawing.Point(234, 393);
            this.changeDirectory.Name = "changeDirectory";
            this.changeDirectory.Size = new System.Drawing.Size(99, 43);
            this.changeDirectory.TabIndex = 7;
            this.changeDirectory.Text = "Change Directory Location";
            this.changeDirectory.UseVisualStyleBackColor = false;
            this.changeDirectory.Click += new System.EventHandler(this.changeDirectory_Click);
            // 
            // folderBrowserDialog
            // 
            this.folderBrowserDialog.Description = "Choose where to save videos or audio to.";
            // 
            // downloadMP3
            // 
            this.downloadMP3.BackColor = System.Drawing.Color.Black;
            this.downloadMP3.ForeColor = System.Drawing.Color.Red;
            this.downloadMP3.Location = new System.Drawing.Point(129, 393);
            this.downloadMP3.Name = "downloadMP3";
            this.downloadMP3.Size = new System.Drawing.Size(99, 43);
            this.downloadMP3.TabIndex = 8;
            this.downloadMP3.Text = "Download MP3 Audio";
            this.downloadMP3.UseVisualStyleBackColor = false;
            this.downloadMP3.Click += new System.EventHandler(this.downloadMP3_Click);
            // 
            // creditsB
            // 
            this.creditsB.BackColor = System.Drawing.Color.Black;
            this.creditsB.ForeColor = System.Drawing.Color.Red;
            this.creditsB.Location = new System.Drawing.Point(147, 481);
            this.creditsB.Name = "creditsB";
            this.creditsB.Size = new System.Drawing.Size(63, 27);
            this.creditsB.TabIndex = 11;
            this.creditsB.Text = "Credits";
            this.creditsB.UseVisualStyleBackColor = false;
            this.creditsB.Click += new System.EventHandler(this.creditsB_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(78, 439);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(201, 39);
            this.label2.TabIndex = 12;
            this.label2.Text = "Simple YouTube Downloader\r\nBy: Slink Soft\r\nCredits Below To Respective Developers" +
    "";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::YoutubeDownloaderv2.Properties.Resources._580b57fcd9996e24bc43c545;
            this.pictureBox2.Location = new System.Drawing.Point(304, 21);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(54, 35);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::YoutubeDownloaderv2.Properties.Resources._580b57fcd9996e24bc43c545;
            this.pictureBox1.Location = new System.Drawing.Point(8, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(54, 35);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // vDisplay
            // 
            this.vDisplay.AutoSize = true;
            this.vDisplay.ForeColor = System.Drawing.Color.Red;
            this.vDisplay.Location = new System.Drawing.Point(301, 495);
            this.vDisplay.Name = "vDisplay";
            this.vDisplay.Size = new System.Drawing.Size(63, 13);
            this.vDisplay.TabIndex = 15;
            this.vDisplay.Text = "Version: 0.0";
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(370, 512);
            this.Controls.Add(this.vDisplay);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.creditsB);
            this.Controls.Add(this.downloadMP3);
            this.Controls.Add(this.changeDirectory);
            this.Controls.Add(this.log);
            this.Controls.Add(this.downloadMP4);
            this.Controls.Add(this.loadData);
            this.Controls.Add(this.pTitle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.urlInput);
            this.Controls.Add(this.label3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(386, 551);
            this.MinimumSize = new System.Drawing.Size(386, 551);
            this.Name = "main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "YouTube Downloader";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox urlInput;
        private System.Windows.Forms.Label pTitle;
        private System.Windows.Forms.Button loadData;
        private System.Windows.Forms.Button downloadMP4;
        private System.Windows.Forms.TextBox log;
        private System.Windows.Forms.Button changeDirectory;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.Button downloadMP3;
        private System.Windows.Forms.Button creditsB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label vDisplay;
    }
}

