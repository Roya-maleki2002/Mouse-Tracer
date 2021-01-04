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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSavePicture = new System.Windows.Forms.Button();
            this.lblLeftClick = new System.Windows.Forms.Label();
            this.lblRightClick = new System.Windows.Forms.Label();
            this.lblMouseWheel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Location = new System.Drawing.Point(12, 38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(360, 211);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btnSavePicture
            // 
            this.btnSavePicture.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSavePicture.Location = new System.Drawing.Point(252, 9);
            this.btnSavePicture.Name = "btnSavePicture";
            this.btnSavePicture.Size = new System.Drawing.Size(120, 23);
            this.btnSavePicture.TabIndex = 3;
            this.btnSavePicture.Text = "Save Picture";
            this.btnSavePicture.UseVisualStyleBackColor = true;
            this.btnSavePicture.Click += new System.EventHandler(this.btnSavePicture_Click);
            // 
            // lblLeftClick
            // 
            this.lblLeftClick.AutoSize = true;
            this.lblLeftClick.ForeColor = System.Drawing.Color.Red;
            this.lblLeftClick.Location = new System.Drawing.Point(12, 14);
            this.lblLeftClick.Name = "lblLeftClick";
            this.lblLeftClick.Size = new System.Drawing.Size(51, 13);
            this.lblLeftClick.TabIndex = 4;
            this.lblLeftClick.Text = "Left Click";
            // 
            // lblRightClick
            // 
            this.lblRightClick.AutoSize = true;
            this.lblRightClick.ForeColor = System.Drawing.Color.Green;
            this.lblRightClick.Location = new System.Drawing.Point(69, 14);
            this.lblRightClick.Name = "lblRightClick";
            this.lblRightClick.Size = new System.Drawing.Size(58, 13);
            this.lblRightClick.TabIndex = 4;
            this.lblRightClick.Text = "Right Click";
            // 
            // lblMouseWheel
            // 
            this.lblMouseWheel.AutoSize = true;
            this.lblMouseWheel.ForeColor = System.Drawing.Color.Blue;
            this.lblMouseWheel.Location = new System.Drawing.Point(133, 14);
            this.lblMouseWheel.Name = "lblMouseWheel";
            this.lblMouseWheel.Size = new System.Drawing.Size(73, 13);
            this.lblMouseWheel.TabIndex = 4;
            this.lblMouseWheel.Text = "Mouse Wheel";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 261);
            this.Controls.Add(this.lblRightClick);
            this.Controls.Add(this.lblMouseWheel);
            this.Controls.Add(this.lblLeftClick);
            this.Controls.Add(this.btnSavePicture);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mouse Tracer";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnSavePicture;
        private System.Windows.Forms.Label lblLeftClick;
        private System.Windows.Forms.Label lblRightClick;
        private System.Windows.Forms.Label lblMouseWheel;
    }
}
