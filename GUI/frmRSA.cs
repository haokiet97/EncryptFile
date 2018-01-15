using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace EncryptFile.GUI
{
    public partial class frmRSA : Form
    {
        private RSACryptoServiceProvider RSA = new RSACryptoServiceProvider();
        private string pathKeyXml = "";
        private bool isEncryptFile = true;
        public frmRSA()
        {
            InitializeComponent();
        }

        private void EnableOrDisableButton(bool isEnable)
        {
            this.btnDecrypt.Enabled = isEnable;
            this.btnEncrypt.Enabled = isEnable;
            this.btnGenerate.Enabled = isEnable;
            this.btnSelect.Enabled = isEnable;
            this.btnReset.Enabled = isEnable;
            this.btnExit.Enabled = isEnable;
        }

        private void RSAAlgorithm(string inputFile, string outputFile, RSAParameters RSAKey, bool isEncrypt)
        {
            try
            {
                FileStream fsIpnut = new FileStream(inputFile, FileMode.Open, FileAccess.Read);
                FileStream fsOutput = new FileStream(outputFile, FileMode.Create, FileAccess.Write);
                fsOutput.SetLength(0);
                byte[] bin, encryptedData;
                long RdLen = 0;
                long TotalLen = fsIpnut.Length;
                int Len;
                this.progressBar1.Minimum = 0;
                this.progressBar1.Maximum = 100;

                RSACryptoServiceProvider RSA = new RSACryptoServiceProvider();
                RSA.ImportParameters(RSAKey);

                int MaxBytesCanEncrypt;

                if (isEncrypt)
                {
                    MaxBytesCanEncrypt = ((RSA.KeySize - 384) / 8) + 37; //tai ssao??????
                }
                else
                {
                    MaxBytesCanEncrypt = RSA.KeySize / 8;
                }

                while (RdLen < TotalLen)
                {
                    bin = new byte[MaxBytesCanEncrypt];
                    Len = fsIpnut.Read(bin, 0, MaxBytesCanEncrypt);

                    if (isEncrypt)
                    {
                        encryptedData = RSA.Encrypt(bin, false);//
                    }
                    else
                    {
                        encryptedData = RSA.Decrypt(bin, false);
                    }
                    fsOutput.Write(encryptedData, 0, encryptedData.Length);
                    RdLen += Len;

                    this.progressBar1.Value = (int)(RdLen * 100 / TotalLen);
                    this.lblDone.Text = this.progressBar1.Value.ToString() + "%";
                    this.lblDone.Refresh();
                }
                fsOutput.Close();
                fsIpnut.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void frmRSA_Load(object sender, EventArgs e)
        {
            this.lblDone.BackColor = Color.Transparent;
            this.lblSecKey.BackColor = Color.Transparent;
            this.lblModul.BackColor = Color.Transparent;
            this.lblOutput.BackColor = Color.Transparent;
            this.lblPrivateKey.BackColor = Color.Transparent;
            this.lblPublicKey.BackColor = Color.Transparent;
            this.lblStatus.BackColor = Color.Transparent;
            this.lblInput.BackColor = Color.Transparent;

            this.cbbInputType.Text = "File";
            this.cbbLenghtKey.Text = "1024bits";
            EnableOrDisableButton(true);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            this.txtInput.Text = "";
            //this.txtOutput.Text = "";
            this.txtPrivateKey.Text = "";
            this.txtPublicKey.Text = "";
            this.txtModuls.Text = "";
            this.txtKeyPath.Text = "";
            this.cbbInputType.Text = "File";
            this.cbbLenghtKey.Text = "1024bits";
            this.progressBar1.Value = 0;
            this.lblDone.Text = "";
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            int LenghKey = 0;
            if (this.cbbLenghtKey.Text == "512bits") LenghKey = 512;
            else if (this.cbbLenghtKey.Text == "1024bits") LenghKey = 1024;
            else if (this.cbbLenghtKey.Text == "2048bits") LenghKey = 20148;
            else LenghKey = 4096;

            RSA = new RSACryptoServiceProvider(LenghKey);
            //RSAParameters RSAPara = new RSAParameters();

            Directory.CreateDirectory(Path.GetDirectoryName(Application.ExecutablePath) + "\\Keys");

            string keyPath = Path.Combine(Path.GetDirectoryName(Application.ExecutablePath) + "\\Keys", "PrivateKeyRSA.xml");
            string keyPath_PL = Path.Combine(Path.GetDirectoryName(Application.ExecutablePath) + "\\Keys", "PublicKeyRSA.xml");
            File.WriteAllText(keyPath, RSA.ToXmlString(true));
            File.WriteAllText(keyPath_PL, RSA.ToXmlString(false));


            this.pathKeyXml = keyPath;
            txtKeyPath.Text = pathKeyXml;

            if (File.Exists(keyPath))
            {
                if (Path.GetExtension(pathKeyXml) == ".xml")
                {
                    XmlDocument xml = new XmlDocument();
                    xml.LoadXml(File.ReadAllText(pathKeyXml));
                    try
                    {
                        XmlNode xnList = xml.SelectSingleNode("/RSAKeyValue/Modulus");
                        txtModuls.Text = xnList.InnerText;
                        xnList = xml.SelectSingleNode("/RSAKeyValue/Exponent");
                        txtPublicKey.Text = xnList.InnerText;
                        xnList = xml.SelectSingleNode("/RSAKeyValue/D");
                        txtPrivateKey.Text = xnList.InnerText;




                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }

            MessageBox.Show("Tạo khoá thành công!\n Độ dài: " + LenghKey.ToString() + "\nĐường Dẫn: " + pathKeyXml);

            //txtPrivateKey.Text = RSA.
        }

        private void btnOpenKey_Click(object sender, EventArgs e)
        {
            this.txtModuls.Text = "";
            this.txtPrivateKey.Text = "";
            this.txtPublicKey.Text = "";

            OpenFileDialog op = new OpenFileDialog();
            if (txtKeyPath.Text.Trim().Length != 0)
                op.InitialDirectory = Path.GetDirectoryName(txtKeyPath.Text);
            op.Filter = "All Files (*.*)|*.*";
            DialogResult dr = op.ShowDialog();

            if (dr == DialogResult.OK)
            {
                pathKeyXml = op.FileName;
                txtKeyPath.Text = pathKeyXml;
            }

            if (File.Exists(pathKeyXml))
            {
                if (Path.GetExtension(pathKeyXml) == ".xml")
                {
                    XmlDocument xml = new XmlDocument();
                    xml.LoadXml(File.ReadAllText(pathKeyXml));
                    try
                    {
                        XmlNode xnList = xml.SelectSingleNode("/RSAKeyValue/Modulus");
                        txtModuls.Text = xnList.InnerText;
                        xnList = xml.SelectSingleNode("/RSAKeyValue/Exponent");
                        txtPublicKey.Text = xnList.InnerText;
                        xnList = xml.SelectSingleNode("/RSAKeyValue/D");
                        txtPrivateKey.Text = xnList.InnerText;
                        this.btnDecrypt.Enabled = true;
                        this.btnEncrypt.Enabled = true;

                    }
                    catch (Exception ex0)
                    {
                        try
                        {
                            XmlNode xnList = xml.SelectSingleNode("/RSAKeyValue/Modulus");
                            txtModuls.Text = xnList.InnerText;
                            xnList = xml.SelectSingleNode("/RSAKeyValue/Exponent");
                            txtPublicKey.Text = xnList.InnerText;
                            this.btnDecrypt.Enabled = false;
                            MessageBox.Show("Bạn chỉ đc Mã hoá với File đã chọn...", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        }
                        catch (Exception ex1)
                        {
                            try
                            {
                                XmlNode xnList = xml.SelectSingleNode("/RSAKeyValue/Modulus");
                                txtModuls.Text = xnList.InnerText;
                                xnList = xml.SelectSingleNode("/RSAKeyValue/D");
                                txtPrivateKey.Text = xnList.InnerText;
                                this.btnEncrypt.Enabled = false;
                                MessageBox.Show("Bạn chỉ đc Giải Mã với File đã chọn...", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                            }
                            catch (Exception ex2)
                            {
                                MessageBox.Show("Lỗi: " + ex2.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }

                        }
                    }
                }

            }
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            this.txtOutput.Clear();
            if (this.cbbInputType.Text == "File")
            {
                this.isEncryptFile = true;
                OpenFileDialog op = new OpenFileDialog();
                if (txtInput.Text.Trim().Length != 0)
                    op.InitialDirectory = Path.GetDirectoryName(txtInput.Text);
                op.Filter = "All Files (*.*)|*.*";
                if (op.ShowDialog() == DialogResult.OK)
                {
                    this.txtInput.Text = op.FileName;
                }
            }
            else
            {
                this.isEncryptFile = false;
                FolderBrowserDialog fbd = new FolderBrowserDialog();
                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    this.txtInput.Text = fbd.SelectedPath;
                }
            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            if (this.txtOutput.Text.Trim().Length > 0)
            {
                try
                {
                    Process prc = new Process();
                    prc.StartInfo.FileName = Path.GetDirectoryName(txtOutput.Text);
                    prc.Start();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }



        private void btnEncrypt_Click(object sender, EventArgs e)
        {




            EnableOrDisableButton(false);
            if (!(this.txtKeyPath.Text.Trim().Length != 0 || (this.txtModuls.Text.Trim().Length != 0 && this.txtPrivateKey.Text.Trim().Length != 0)))
            {
                MessageBox.Show("Key Không hợp lệ..!\nHãy chọn tệp key hoặc generate..", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                EnableOrDisableButton(true);
                return;
            }

            try
            {
                if (txtPublicKey.Text.Trim().Length != 0 && txtModuls.Text.Trim().Length != 0 && txtKeyPath.Text.Trim().Length != 0)
                {
                    string inputFileName = txtInput.Text.Trim(), outputFileName = "";

                    if (isEncryptFile)
                    {
                        outputFileName = txtInput.Text.Trim() + ".Encrypt";
                        txtOutput.Text = outputFileName;
                    }
                    //lay Key
                    RSA = new RSACryptoServiceProvider();
                    RSA.FromXmlString(File.ReadAllText(this.pathKeyXml));


                    if (isEncryptFile)
                    {
                        RSAAlgorithm(inputFileName, outputFileName, RSA.ExportParameters(false), true); // RSA.ExportParameters(false) = truyen vao key public
                        MessageBox.Show("Đã thực thi hoàn tất.!");
                    }
                    else
                    {
                        string[] filePath = Directory.GetFiles(inputFileName, "*");

                        if (filePath.Length == 0 || (filePath.Length == 1 && Path.GetFileName(filePath[0]) == "Thumbs.db"))
                        {
                            MessageBox.Show("Thư mục rỗng!!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            EnableOrDisableButton(true);
                            return;
                        }
                        outputFileName = filePath[0];
                        txtOutput.Text = Path.GetDirectoryName(outputFileName);

                        for (int i = 0; i < filePath.Length; i++)
                        {
                            if (Path.GetFileName(filePath[i]) != "Thumbs.db")
                            {
                                RSAAlgorithm(filePath[i], filePath[i] + ".Encrypt", RSA.ExportParameters(true), true);
                            }
                        }
                    }
                    EnableOrDisableButton(true);


                }
                else
                {
                    MessageBox.Show("Dữ Lệu không đủ để Mã Hoá!!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    EnableOrDisableButton(true);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                EnableOrDisableButton(true);
            }

            EnableOrDisableButton(true);


            // enc.Abort();
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            EnableOrDisableButton(false);

            try
            {
                if (txtInput.Text.Trim() != "" && txtKeyPath.Text.Trim() != "")
                {
                    string inputFileName = txtInput.Text, outputFileName = "";
                    if (isEncryptFile && Path.GetExtension(inputFileName) != ".Encrypt")
                    {
                        MessageBox.Show("Định dạng File không hỗ trợ Giải Mã..!\nHãy Chọn Lại..!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        EnableOrDisableButton(true);
                        return;
                    }

                    if (isEncryptFile)
                    {
                        outputFileName = inputFileName.Substring(0, inputFileName.Length - 8);
                        this.txtOutput.Text = outputFileName;
                    }
                    RSA = new RSACryptoServiceProvider();
                    RSA.FromXmlString(File.ReadAllText(this.pathKeyXml));
                    if (isEncryptFile)
                    {
                        RSAAlgorithm(inputFileName, outputFileName, RSA.ExportParameters(true), false);
                    }
                    else
                    {
                        string[] filePaths = Directory.GetFiles(inputFileName, "*.Encrypt", SearchOption.AllDirectories);
                        if (filePaths.Length == 0 || (filePaths.Length == 1 && Path.GetFileName(filePaths[0]) == "Thumb.db"))
                        {
                            MessageBox.Show("Thư mục rỗng..!\nHãy kiểm tra lại..!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            EnableOrDisableButton(true);
                            return;
                        }

                        outputFileName = filePaths[0];
                        this.txtOutput.Text = Path.GetDirectoryName(outputFileName);
                        for (int i = 0; i < filePaths.Length; i++)
                        {

                            if (Path.GetFileName(filePaths[i]) != "Thumb.db")
                            {
                                RSAAlgorithm(filePaths[i], filePaths[i].Substring(0, filePaths[i].Length - 8), RSA.ExportParameters(true), false);
                            }

                        }
                    }

                    EnableOrDisableButton(true);



                }
                else
                {
                    MessageBox.Show("Không Đủ Dữ Liệu Giải Mã.!\n", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }



            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed: " + ex.Message,"Lỗi",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }


    }
}
