namespace HsvThresholder
{
    partial class hsvThreshForm
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
            this.srcPicBox = new System.Windows.Forms.PictureBox();
            this.threshPicBox = new System.Windows.Forms.PictureBox();
            this.hueMinTrackBar = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.hueLabel = new System.Windows.Forms.Label();
            this.satMinTrackBar = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.satLabel = new System.Windows.Forms.Label();
            this.valMinTrackBar = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.valLabel = new System.Windows.Forms.Label();
            this.hueMaxTrackBar = new System.Windows.Forms.TrackBar();
            this.satMaxTrackBar = new System.Windows.Forms.TrackBar();
            this.valMaxTrackBar = new System.Windows.Forms.TrackBar();
            this.outTxtBox = new System.Windows.Forms.TextBox();
            this.openImageBtn = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.srcPicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.threshPicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hueMinTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.satMinTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.valMinTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hueMaxTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.satMaxTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.valMaxTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // srcPicBox
            // 
            this.srcPicBox.Location = new System.Drawing.Point(12, 12);
            this.srcPicBox.Name = "srcPicBox";
            this.srcPicBox.Size = new System.Drawing.Size(736, 480);
            this.srcPicBox.TabIndex = 0;
            this.srcPicBox.TabStop = false;
            // 
            // threshPicBox
            // 
            this.threshPicBox.Location = new System.Drawing.Point(754, 12);
            this.threshPicBox.Name = "threshPicBox";
            this.threshPicBox.Size = new System.Drawing.Size(736, 480);
            this.threshPicBox.TabIndex = 0;
            this.threshPicBox.TabStop = false;
            // 
            // hueMinTrackBar
            // 
            this.hueMinTrackBar.Enabled = false;
            this.hueMinTrackBar.Location = new System.Drawing.Point(1497, 41);
            this.hueMinTrackBar.Maximum = 255;
            this.hueMinTrackBar.Name = "hueMinTrackBar";
            this.hueMinTrackBar.Size = new System.Drawing.Size(465, 90);
            this.hueMinTrackBar.TabIndex = 1;
            this.hueMinTrackBar.TickFrequency = 16;
            this.hueMinTrackBar.ValueChanged += new System.EventHandler(this.TrackBar_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1497, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Hue:";
            // 
            // hueLabel
            // 
            this.hueLabel.AutoSize = true;
            this.hueLabel.Location = new System.Drawing.Point(1551, 13);
            this.hueLabel.Name = "hueLabel";
            this.hueLabel.Size = new System.Drawing.Size(79, 25);
            this.hueLabel.TabIndex = 3;
            this.hueLabel.Text = "0 - 255";
            // 
            // satMinTrackBar
            // 
            this.satMinTrackBar.Enabled = false;
            this.satMinTrackBar.Location = new System.Drawing.Point(1496, 187);
            this.satMinTrackBar.Maximum = 255;
            this.satMinTrackBar.Name = "satMinTrackBar";
            this.satMinTrackBar.Size = new System.Drawing.Size(465, 90);
            this.satMinTrackBar.TabIndex = 1;
            this.satMinTrackBar.TickFrequency = 16;
            this.satMinTrackBar.ValueChanged += new System.EventHandler(this.TrackBar_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1497, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Saturation:";
            // 
            // satLabel
            // 
            this.satLabel.AutoSize = true;
            this.satLabel.Location = new System.Drawing.Point(1610, 159);
            this.satLabel.Name = "satLabel";
            this.satLabel.Size = new System.Drawing.Size(79, 25);
            this.satLabel.TabIndex = 3;
            this.satLabel.Text = "0 - 255";
            // 
            // valMinTrackBar
            // 
            this.valMinTrackBar.Enabled = false;
            this.valMinTrackBar.Location = new System.Drawing.Point(1497, 344);
            this.valMinTrackBar.Maximum = 255;
            this.valMinTrackBar.Name = "valMinTrackBar";
            this.valMinTrackBar.Size = new System.Drawing.Size(465, 90);
            this.valMinTrackBar.TabIndex = 1;
            this.valMinTrackBar.TickFrequency = 16;
            this.valMinTrackBar.ValueChanged += new System.EventHandler(this.TrackBar_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1497, 316);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Value:";
            // 
            // valLabel
            // 
            this.valLabel.AutoSize = true;
            this.valLabel.Location = new System.Drawing.Point(1566, 316);
            this.valLabel.Name = "valLabel";
            this.valLabel.Size = new System.Drawing.Size(79, 25);
            this.valLabel.TabIndex = 3;
            this.valLabel.Text = "0 - 255";
            // 
            // hueMaxTrackBar
            // 
            this.hueMaxTrackBar.Enabled = false;
            this.hueMaxTrackBar.Location = new System.Drawing.Point(1496, 94);
            this.hueMaxTrackBar.Maximum = 255;
            this.hueMaxTrackBar.Name = "hueMaxTrackBar";
            this.hueMaxTrackBar.Size = new System.Drawing.Size(465, 90);
            this.hueMaxTrackBar.TabIndex = 1;
            this.hueMaxTrackBar.TickFrequency = 16;
            this.hueMaxTrackBar.Value = 255;
            this.hueMaxTrackBar.ValueChanged += new System.EventHandler(this.TrackBar_ValueChanged);
            // 
            // satMaxTrackBar
            // 
            this.satMaxTrackBar.Enabled = false;
            this.satMaxTrackBar.Location = new System.Drawing.Point(1496, 241);
            this.satMaxTrackBar.Maximum = 255;
            this.satMaxTrackBar.Name = "satMaxTrackBar";
            this.satMaxTrackBar.Size = new System.Drawing.Size(465, 90);
            this.satMaxTrackBar.TabIndex = 1;
            this.satMaxTrackBar.TickFrequency = 16;
            this.satMaxTrackBar.Value = 255;
            this.satMaxTrackBar.ValueChanged += new System.EventHandler(this.TrackBar_ValueChanged);
            // 
            // valMaxTrackBar
            // 
            this.valMaxTrackBar.Enabled = false;
            this.valMaxTrackBar.Location = new System.Drawing.Point(1496, 402);
            this.valMaxTrackBar.Maximum = 255;
            this.valMaxTrackBar.Name = "valMaxTrackBar";
            this.valMaxTrackBar.Size = new System.Drawing.Size(465, 90);
            this.valMaxTrackBar.TabIndex = 1;
            this.valMaxTrackBar.TickFrequency = 16;
            this.valMaxTrackBar.Value = 255;
            this.valMaxTrackBar.ValueChanged += new System.EventHandler(this.TrackBar_ValueChanged);
            // 
            // outTxtBox
            // 
            this.outTxtBox.Location = new System.Drawing.Point(12, 504);
            this.outTxtBox.Multiline = true;
            this.outTxtBox.Name = "outTxtBox";
            this.outTxtBox.ReadOnly = true;
            this.outTxtBox.Size = new System.Drawing.Size(1756, 37);
            this.outTxtBox.TabIndex = 4;
            // 
            // openImageBtn
            // 
            this.openImageBtn.Location = new System.Drawing.Point(1775, 504);
            this.openImageBtn.Name = "openImageBtn";
            this.openImageBtn.Size = new System.Drawing.Size(187, 37);
            this.openImageBtn.TabIndex = 0;
            this.openImageBtn.Text = "Open Image...";
            this.openImageBtn.UseVisualStyleBackColor = true;
            this.openImageBtn.Click += new System.EventHandler(this.openImageBtn_Click);
            // 
            // hsvThreshForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1974, 553);
            this.Controls.Add(this.openImageBtn);
            this.Controls.Add(this.outTxtBox);
            this.Controls.Add(this.valLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.satMaxTrackBar);
            this.Controls.Add(this.satLabel);
            this.Controls.Add(this.hueLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.valMaxTrackBar);
            this.Controls.Add(this.valMinTrackBar);
            this.Controls.Add(this.satMinTrackBar);
            this.Controls.Add(this.hueMaxTrackBar);
            this.Controls.Add(this.hueMinTrackBar);
            this.Controls.Add(this.threshPicBox);
            this.Controls.Add(this.srcPicBox);
            this.Name = "hsvThreshForm";
            this.Text = "HSV Thresholder";
            this.Resize += new System.EventHandler(this.ResizeImages);
            ((System.ComponentModel.ISupportInitialize)(this.srcPicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.threshPicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hueMinTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.satMinTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.valMinTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hueMaxTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.satMaxTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.valMaxTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox srcPicBox;
        private System.Windows.Forms.PictureBox threshPicBox;
        private System.Windows.Forms.TrackBar hueMinTrackBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label hueLabel;
        private System.Windows.Forms.TrackBar satMinTrackBar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label satLabel;
        private System.Windows.Forms.TrackBar valMinTrackBar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label valLabel;
        private System.Windows.Forms.TrackBar hueMaxTrackBar;
        private System.Windows.Forms.TrackBar satMaxTrackBar;
        private System.Windows.Forms.TrackBar valMaxTrackBar;
        private System.Windows.Forms.TextBox outTxtBox;
        private System.Windows.Forms.Button openImageBtn;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}

