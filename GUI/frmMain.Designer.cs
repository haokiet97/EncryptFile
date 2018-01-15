namespace EncryptFile
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.ptbDES = new System.Windows.Forms.PictureBox();
            this.ptbAES = new System.Windows.Forms.PictureBox();
            this.ptbRSA = new System.Windows.Forms.PictureBox();
            this.ptbExit = new System.Windows.Forms.PictureBox();
            this.ptbSound = new System.Windows.Forms.PictureBox();
            this.ptbTittle = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ptbDES)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbAES)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbRSA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbSound)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbTittle)).BeginInit();
            this.SuspendLayout();
            // 
            // ptbDES
            // 
            this.ptbDES.Image = global::EncryptFile.Properties.Resources.btnDESNon;
            this.ptbDES.Location = new System.Drawing.Point(1359, 401);
            this.ptbDES.Name = "ptbDES";
            this.ptbDES.Size = new System.Drawing.Size(291, 240);
            this.ptbDES.TabIndex = 1;
            this.ptbDES.TabStop = false;
            this.ptbDES.Click += new System.EventHandler(this.ptbDES_Click);
            this.ptbDES.MouseLeave += new System.EventHandler(this.ptbDES_MouseLeave);
            this.ptbDES.MouseHover += new System.EventHandler(this.ptbDES_MouseHover);
            // 
            // ptbAES
            // 
            this.ptbAES.Image = global::EncryptFile.Properties.Resources.btnAESNon;
            this.ptbAES.Location = new System.Drawing.Point(1009, 311);
            this.ptbAES.Name = "ptbAES";
            this.ptbAES.Size = new System.Drawing.Size(301, 235);
            this.ptbAES.TabIndex = 0;
            this.ptbAES.TabStop = false;
            this.ptbAES.Click += new System.EventHandler(this.ptbAES_Click);
            this.ptbAES.MouseLeave += new System.EventHandler(this.ptbAES_MouseLeave);
            this.ptbAES.MouseHover += new System.EventHandler(this.ptbAES_MouseHover);
            // 
            // ptbRSA
            // 
            this.ptbRSA.Image = global::EncryptFile.Properties.Resources.btnRSANon;
            this.ptbRSA.Location = new System.Drawing.Point(1051, 624);
            this.ptbRSA.Name = "ptbRSA";
            this.ptbRSA.Size = new System.Drawing.Size(285, 219);
            this.ptbRSA.TabIndex = 3;
            this.ptbRSA.TabStop = false;
            this.ptbRSA.Click += new System.EventHandler(this.ptbRSA_Click);
            this.ptbRSA.MouseLeave += new System.EventHandler(this.ptbRSA_MouseLeave);
            this.ptbRSA.MouseHover += new System.EventHandler(this.ptbRSA_MouseHover);
            // 
            // ptbExit
            // 
            this.ptbExit.Image = global::EncryptFile.Properties.Resources.btnExit;
            this.ptbExit.Location = new System.Drawing.Point(1410, 712);
            this.ptbExit.Name = "ptbExit";
            this.ptbExit.Size = new System.Drawing.Size(314, 226);
            this.ptbExit.TabIndex = 5;
            this.ptbExit.TabStop = false;
            this.ptbExit.Click += new System.EventHandler(this.ptbExit_Click);
            this.ptbExit.MouseLeave += new System.EventHandler(this.ptbExit_MouseLeave);
            this.ptbExit.MouseHover += new System.EventHandler(this.ptbExit_MouseHover);
            // 
            // ptbSound
            // 
            this.ptbSound.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ptbSound.Image = global::EncryptFile.Properties.Resources.btnSound_on;
            this.ptbSound.Location = new System.Drawing.Point(1802, 42);
            this.ptbSound.Name = "ptbSound";
            this.ptbSound.Size = new System.Drawing.Size(88, 80);
            this.ptbSound.TabIndex = 6;
            this.ptbSound.TabStop = false;
            this.ptbSound.Click += new System.EventHandler(this.ptbSound_Click);
            // 
            // ptbTittle
            // 
            this.ptbTittle.Image = global::EncryptFile.Properties.Resources.Tittle_Encrypt;
            this.ptbTittle.Location = new System.Drawing.Point(822, 0);
            this.ptbTittle.Name = "ptbTittle";
            this.ptbTittle.Size = new System.Drawing.Size(408, 216);
            this.ptbTittle.TabIndex = 7;
            this.ptbTittle.TabStop = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::EncryptFile.Properties.Resources.bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.ptbTittle);
            this.Controls.Add(this.ptbSound);
            this.Controls.Add(this.ptbExit);
            this.Controls.Add(this.ptbRSA);
            this.Controls.Add(this.ptbDES);
            this.Controls.Add(this.ptbAES);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.Text = "EasyEncrypt 1.0";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptbDES)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbAES)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbRSA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbSound)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbTittle)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ptbAES;
        private System.Windows.Forms.PictureBox ptbDES;
        private System.Windows.Forms.PictureBox ptbRSA;
        private System.Windows.Forms.PictureBox ptbExit;
        private System.Windows.Forms.PictureBox ptbSound;
        private System.Windows.Forms.PictureBox ptbTittle;
    }
}