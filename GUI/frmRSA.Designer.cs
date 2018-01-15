namespace EncryptFile.GUI
{
    partial class frmRSA
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
            this.lblPrivateKey = new System.Windows.Forms.Label();
            this.lblPublicKey = new System.Windows.Forms.Label();
            this.lblModul = new System.Windows.Forms.Label();
            this.lblOutput = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.txtPrivateKey = new System.Windows.Forms.TextBox();
            this.txtPublicKey = new System.Windows.Forms.TextBox();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.cbbInputType = new System.Windows.Forms.ComboBox();
            this.cbbLenghtKey = new System.Windows.Forms.ComboBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.txtModuls = new System.Windows.Forms.TextBox();
            this.lblInput = new System.Windows.Forms.Label();
            this.btnOpenKey = new System.Windows.Forms.Button();
            this.txtKeyPath = new System.Windows.Forms.TextBox();
            this.lblSecKey = new System.Windows.Forms.Label();
            this.lblDone = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblPrivateKey
            // 
            this.lblPrivateKey.AutoSize = true;
            this.lblPrivateKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrivateKey.ForeColor = System.Drawing.Color.Red;
            this.lblPrivateKey.Location = new System.Drawing.Point(101, 255);
            this.lblPrivateKey.Name = "lblPrivateKey";
            this.lblPrivateKey.Size = new System.Drawing.Size(138, 29);
            this.lblPrivateKey.TabIndex = 0;
            this.lblPrivateKey.Text = "PrivateKey";
            // 
            // lblPublicKey
            // 
            this.lblPublicKey.AutoSize = true;
            this.lblPublicKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPublicKey.ForeColor = System.Drawing.Color.Red;
            this.lblPublicKey.Location = new System.Drawing.Point(101, 330);
            this.lblPublicKey.Name = "lblPublicKey";
            this.lblPublicKey.Size = new System.Drawing.Size(130, 29);
            this.lblPublicKey.TabIndex = 1;
            this.lblPublicKey.Text = "PublicKey";
            // 
            // lblModul
            // 
            this.lblModul.AutoSize = true;
            this.lblModul.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModul.ForeColor = System.Drawing.Color.Red;
            this.lblModul.Location = new System.Drawing.Point(101, 405);
            this.lblModul.Name = "lblModul";
            this.lblModul.Size = new System.Drawing.Size(98, 29);
            this.lblModul.TabIndex = 2;
            this.lblModul.Text = "Moduls";
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutput.ForeColor = System.Drawing.Color.Red;
            this.lblOutput.Location = new System.Drawing.Point(101, 556);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(90, 29);
            this.lblOutput.TabIndex = 3;
            this.lblOutput.Text = "Output";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.Red;
            this.lblStatus.Location = new System.Drawing.Point(101, 724);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(85, 29);
            this.lblStatus.TabIndex = 4;
            this.lblStatus.Text = "Status";
            // 
            // txtPrivateKey
            // 
            this.txtPrivateKey.Enabled = false;
            this.txtPrivateKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrivateKey.Location = new System.Drawing.Point(289, 251);
            this.txtPrivateKey.Name = "txtPrivateKey";
            this.txtPrivateKey.Size = new System.Drawing.Size(519, 30);
            this.txtPrivateKey.TabIndex = 5;
            // 
            // txtPublicKey
            // 
            this.txtPublicKey.Enabled = false;
            this.txtPublicKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPublicKey.Location = new System.Drawing.Point(289, 327);
            this.txtPublicKey.Name = "txtPublicKey";
            this.txtPublicKey.Size = new System.Drawing.Size(519, 30);
            this.txtPublicKey.TabIndex = 6;
            // 
            // txtInput
            // 
            this.txtInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInput.Location = new System.Drawing.Point(289, 480);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(519, 30);
            this.txtInput.TabIndex = 7;
            // 
            // txtOutput
            // 
            this.txtOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOutput.Location = new System.Drawing.Point(289, 556);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(519, 30);
            this.txtOutput.TabIndex = 8;
            // 
            // cbbInputType
            // 
            this.cbbInputType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbInputType.FormattingEnabled = true;
            this.cbbInputType.Items.AddRange(new object[] {
            "File",
            "Folder"});
            this.cbbInputType.Location = new System.Drawing.Point(841, 481);
            this.cbbInputType.Name = "cbbInputType";
            this.cbbInputType.Size = new System.Drawing.Size(121, 33);
            this.cbbInputType.TabIndex = 9;
            // 
            // cbbLenghtKey
            // 
            this.cbbLenghtKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbLenghtKey.FormattingEnabled = true;
            this.cbbLenghtKey.Items.AddRange(new object[] {
            "512bits",
            "1024bits",
            "2048bits",
            "4096bits"});
            this.cbbLenghtKey.Location = new System.Drawing.Point(841, 251);
            this.cbbLenghtKey.Name = "cbbLenghtKey";
            this.cbbLenghtKey.Size = new System.Drawing.Size(121, 33);
            this.cbbLenghtKey.TabIndex = 10;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(289, 730);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(519, 23);
            this.progressBar1.TabIndex = 11;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerate.Location = new System.Drawing.Point(1016, 255);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(125, 36);
            this.btnGenerate.TabIndex = 12;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEncrypt.Location = new System.Drawing.Point(349, 645);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(121, 37);
            this.btnEncrypt.TabIndex = 12;
            this.btnEncrypt.Text = "Encrypt";
            this.btnEncrypt.UseVisualStyleBackColor = true;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // btnSelect
            // 
            this.btnSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelect.Location = new System.Drawing.Point(1016, 484);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(112, 30);
            this.btnSelect.TabIndex = 12;
            this.btnSelect.Text = "Select";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(1016, 723);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(112, 30);
            this.btnExit.TabIndex = 12;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(-180, 520);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 12;
            this.button5.Text = "button1";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDecrypt.Location = new System.Drawing.Point(595, 645);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(121, 37);
            this.btnDecrypt.TabIndex = 12;
            this.btnDecrypt.Text = "Decrypt";
            this.btnDecrypt.UseVisualStyleBackColor = true;
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(841, 645);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(121, 37);
            this.btnReset.TabIndex = 12;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpen.Location = new System.Drawing.Point(1016, 556);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(112, 37);
            this.btnOpen.TabIndex = 12;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // txtModuls
            // 
            this.txtModuls.Enabled = false;
            this.txtModuls.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtModuls.Location = new System.Drawing.Point(289, 403);
            this.txtModuls.Name = "txtModuls";
            this.txtModuls.Size = new System.Drawing.Size(519, 30);
            this.txtModuls.TabIndex = 7;
            // 
            // lblInput
            // 
            this.lblInput.AutoSize = true;
            this.lblInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInput.ForeColor = System.Drawing.Color.Red;
            this.lblInput.Location = new System.Drawing.Point(101, 481);
            this.lblInput.Name = "lblInput";
            this.lblInput.Size = new System.Drawing.Size(70, 29);
            this.lblInput.TabIndex = 2;
            this.lblInput.Text = "Input";
            // 
            // btnOpenKey
            // 
            this.btnOpenKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenKey.Location = new System.Drawing.Point(1016, 187);
            this.btnOpenKey.Name = "btnOpenKey";
            this.btnOpenKey.Size = new System.Drawing.Size(112, 36);
            this.btnOpenKey.TabIndex = 13;
            this.btnOpenKey.Text = "OpenKey";
            this.btnOpenKey.UseVisualStyleBackColor = true;
            this.btnOpenKey.Click += new System.EventHandler(this.btnOpenKey_Click);
            // 
            // txtKeyPath
            // 
            this.txtKeyPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKeyPath.Location = new System.Drawing.Point(289, 193);
            this.txtKeyPath.Name = "txtKeyPath";
            this.txtKeyPath.Size = new System.Drawing.Size(519, 30);
            this.txtKeyPath.TabIndex = 14;
            // 
            // lblSecKey
            // 
            this.lblSecKey.AutoSize = true;
            this.lblSecKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSecKey.ForeColor = System.Drawing.Color.Red;
            this.lblSecKey.Location = new System.Drawing.Point(101, 198);
            this.lblSecKey.Name = "lblSecKey";
            this.lblSecKey.Size = new System.Drawing.Size(111, 25);
            this.lblSecKey.TabIndex = 15;
            this.lblSecKey.Text = "Key (.xml)";
            // 
            // lblDone
            // 
            this.lblDone.AutoSize = true;
            this.lblDone.Location = new System.Drawing.Point(823, 736);
            this.lblDone.Name = "lblDone";
            this.lblDone.Size = new System.Drawing.Size(0, 17);
            this.lblDone.TabIndex = 16;
            // 
            // frmRSA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::EncryptFile.Properties.Resources.bgRSA;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1225, 796);
            this.ControlBox = false;
            this.Controls.Add(this.lblDone);
            this.Controls.Add(this.lblSecKey);
            this.Controls.Add(this.txtKeyPath);
            this.Controls.Add(this.btnOpenKey);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnDecrypt);
            this.Controls.Add(this.btnEncrypt);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.cbbLenghtKey);
            this.Controls.Add(this.cbbInputType);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.txtModuls);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.txtPublicKey);
            this.Controls.Add(this.txtPrivateKey);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.lblInput);
            this.Controls.Add(this.lblModul);
            this.Controls.Add(this.lblPublicKey);
            this.Controls.Add(this.lblPrivateKey);
            this.Name = "frmRSA";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RSA Algorithm";
            this.Load += new System.EventHandler(this.frmRSA_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPrivateKey;
        private System.Windows.Forms.Label lblPublicKey;
        private System.Windows.Forms.Label lblModul;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TextBox txtPrivateKey;
        private System.Windows.Forms.TextBox txtPublicKey;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.ComboBox cbbInputType;
        private System.Windows.Forms.ComboBox cbbLenghtKey;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btnDecrypt;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.TextBox txtModuls;
        private System.Windows.Forms.Label lblInput;
        private System.Windows.Forms.Button btnOpenKey;
        private System.Windows.Forms.TextBox txtKeyPath;
        private System.Windows.Forms.Label lblSecKey;
        private System.Windows.Forms.Label lblDone;
    }
}