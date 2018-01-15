namespace EncryptFile
{
    partial class frmAES
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAES));
            this.lblKey = new System.Windows.Forms.Label();
            this.lblInput = new System.Windows.Forms.Label();
            this.lblMode = new System.Windows.Forms.Label();
            this.lblOutput = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.txtKey = new System.Windows.Forms.TextBox();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.cbbMode = new System.Windows.Forms.ComboBox();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.cbbBit = new System.Windows.Forms.ComboBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnFolder = new System.Windows.Forms.Button();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.btnDencrypt = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.cbbSeclectType = new System.Windows.Forms.ComboBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblKey
            // 
            this.lblKey.AutoSize = true;
            this.lblKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKey.ForeColor = System.Drawing.Color.Red;
            this.lblKey.Location = new System.Drawing.Point(63, 209);
            this.lblKey.Name = "lblKey";
            this.lblKey.Size = new System.Drawing.Size(64, 32);
            this.lblKey.TabIndex = 0;
            this.lblKey.Text = "Key";
            // 
            // lblInput
            // 
            this.lblInput.AutoSize = true;
            this.lblInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInput.ForeColor = System.Drawing.Color.Red;
            this.lblInput.Location = new System.Drawing.Point(63, 297);
            this.lblInput.Name = "lblInput";
            this.lblInput.Size = new System.Drawing.Size(78, 32);
            this.lblInput.TabIndex = 1;
            this.lblInput.Text = "Input";
            // 
            // lblMode
            // 
            this.lblMode.AutoSize = true;
            this.lblMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMode.ForeColor = System.Drawing.Color.Red;
            this.lblMode.Location = new System.Drawing.Point(63, 385);
            this.lblMode.Name = "lblMode";
            this.lblMode.Size = new System.Drawing.Size(86, 32);
            this.lblMode.TabIndex = 2;
            this.lblMode.Text = "Mode";
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutput.ForeColor = System.Drawing.Color.Red;
            this.lblOutput.Location = new System.Drawing.Point(63, 473);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(101, 32);
            this.lblOutput.TabIndex = 3;
            this.lblOutput.Text = "Output";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.Red;
            this.lblStatus.Location = new System.Drawing.Point(63, 689);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(96, 32);
            this.lblStatus.TabIndex = 4;
            this.lblStatus.Text = "Status";
            // 
            // txtKey
            // 
            this.txtKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKey.Location = new System.Drawing.Point(222, 203);
            this.txtKey.Name = "txtKey";
            this.txtKey.Size = new System.Drawing.Size(341, 30);
            this.txtKey.TabIndex = 5;
            // 
            // txtInput
            // 
            this.txtInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInput.Location = new System.Drawing.Point(222, 292);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(466, 30);
            this.txtInput.TabIndex = 6;
            // 
            // cbbMode
            // 
            this.cbbMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbMode.FormattingEnabled = true;
            this.cbbMode.Items.AddRange(new object[] {
            "CBC",
            "ECB",
            "CFB"});
            this.cbbMode.Location = new System.Drawing.Point(222, 376);
            this.cbbMode.Name = "cbbMode";
            this.cbbMode.Size = new System.Drawing.Size(108, 33);
            this.cbbMode.TabIndex = 7;
            // 
            // txtOutput
            // 
            this.txtOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOutput.Location = new System.Drawing.Point(222, 468);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(466, 30);
            this.txtOutput.TabIndex = 8;
            // 
            // cbbBit
            // 
            this.cbbBit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbBit.FormattingEnabled = true;
            this.cbbBit.Items.AddRange(new object[] {
            "128bit",
            "192bit",
            "256bit"});
            this.cbbBit.Location = new System.Drawing.Point(569, 201);
            this.cbbBit.Name = "cbbBit";
            this.cbbBit.Size = new System.Drawing.Size(119, 33);
            this.cbbBit.TabIndex = 9;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(222, 698);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(466, 23);
            this.progressBar1.TabIndex = 10;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerate.Location = new System.Drawing.Point(851, 202);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(150, 37);
            this.btnGenerate.TabIndex = 11;
            this.btnGenerate.Text = "Generate-Key";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpen.Location = new System.Drawing.Point(851, 292);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(150, 37);
            this.btnOpen.TabIndex = 12;
            this.btnOpen.Text = "Select";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnFolder
            // 
            this.btnFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFolder.Location = new System.Drawing.Point(851, 468);
            this.btnFolder.Name = "btnFolder";
            this.btnFolder.Size = new System.Drawing.Size(150, 37);
            this.btnFolder.TabIndex = 13;
            this.btnFolder.Text = "Open";
            this.btnFolder.UseVisualStyleBackColor = true;
            this.btnFolder.Click += new System.EventHandler(this.btnFolder_Click);
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEncrypt.Location = new System.Drawing.Point(253, 595);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(120, 41);
            this.btnEncrypt.TabIndex = 14;
            this.btnEncrypt.Text = "Encrypt";
            this.btnEncrypt.UseVisualStyleBackColor = true;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // btnDencrypt
            // 
            this.btnDencrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDencrypt.Location = new System.Drawing.Point(494, 595);
            this.btnDencrypt.Name = "btnDencrypt";
            this.btnDencrypt.Size = new System.Drawing.Size(153, 41);
            this.btnDencrypt.TabIndex = 15;
            this.btnDencrypt.Text = "Dencrypt";
            this.btnDencrypt.UseVisualStyleBackColor = true;
            this.btnDencrypt.Click += new System.EventHandler(this.btnDencrypt_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(851, 684);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(150, 37);
            this.btnExit.TabIndex = 16;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // cbbSeclectType
            // 
            this.cbbSeclectType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbSeclectType.FormattingEnabled = true;
            this.cbbSeclectType.Items.AddRange(new object[] {
            "File",
            "Folder"});
            this.cbbSeclectType.Location = new System.Drawing.Point(704, 292);
            this.cbbSeclectType.Name = "cbbSeclectType";
            this.cbbSeclectType.Size = new System.Drawing.Size(108, 33);
            this.cbbSeclectType.TabIndex = 17;
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(851, 599);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(150, 37);
            this.btnReset.TabIndex = 18;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // frmAES
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::EncryptFile.Properties.Resources.bgAES2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1189, 763);
            this.ControlBox = false;
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.cbbSeclectType);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnDencrypt);
            this.Controls.Add(this.btnEncrypt);
            this.Controls.Add(this.btnFolder);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.cbbBit);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.cbbMode);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.txtKey);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.lblMode);
            this.Controls.Add(this.lblInput);
            this.Controls.Add(this.lblKey);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAES";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AES Algorithm";
            this.Load += new System.EventHandler(this.frmAES_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblKey;
        private System.Windows.Forms.Label lblInput;
        private System.Windows.Forms.Label lblMode;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TextBox txtKey;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.ComboBox cbbMode;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.ComboBox cbbBit;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnFolder;
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.Button btnDencrypt;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ComboBox cbbSeclectType;
        private System.Windows.Forms.Button btnReset;
    }
}