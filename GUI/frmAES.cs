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
using System.Threading.Tasks;
using System.Windows.Forms;


namespace EncryptFile
{
    public partial class frmAES : Form
    {
        public frmAES()
        {
            InitializeComponent();
        }
        //khai bien va delegate
        private bool isEncryptFile = true;
       

        private void enabledOrDisableButtons(bool isEnable)
        {
            this.btnGenerate.Enabled = isEnable;
            this.btnOpen.Enabled = isEnable;
            this.btnOpen.Enabled = isEnable;
            this.btnEncrypt.Enabled = isEnable;
            this.btnDencrypt.Enabled = isEnable;
            this.btnExit.Enabled = isEnable;
        }

        private void AESAlgorithm(string inputFile, string outputFile, string keys, bool isEncrypt, string mode)
        {
            try
            {

                if (!isEncrypt) //set ten output file cho t.h giai ma
                {
                    outputFile = Path.Combine(Path.GetDirectoryName(outputFile), Path.GetFileNameWithoutExtension(outputFile) + " _1" + Path.GetExtension(outputFile));
                }

                FileStream fsInput = new FileStream(inputFile, FileMode.Open, FileAccess.Read);
                FileStream fsOutput = new FileStream(outputFile, FileMode.Create, FileAccess.Write);

                fsOutput.SetLength(0);
                int numberBytesRead = 10485760;// `10 mb/lan
                byte[] bin = new byte[numberBytesRead];
                long rdLen = 0; // vi tri doc
                long totalLen = fsInput.Length; // tong do dai cua file
                int Len;

                progressBar1.Minimum = 0;
                progressBar1.Maximum = 100;

                //bat dau ma hoa

                AesCryptoServiceProvider AESProvides = new AesCryptoServiceProvider();
                try
                {
                    AESProvides.Key = Convert.FromBase64String(keys);
                    AESProvides.IV = ASCIIEncoding.ASCII.GetBytes(keys.Substring(0, 16));
                }
                catch (Exception ioex)
                {
                    MessageBox.Show("Lỗi: " + ioex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (mode == "ECB") AESProvides.Mode = CipherMode.ECB;
                else if (mode == "CBC") AESProvides.Mode = CipherMode.CBC;
                else if (mode == "CFB") AESProvides.Mode = CipherMode.CFB;
                CryptoStream cryptStream;// khai bao dong ma hao

                //ma hoa va giai ma
                if (isEncrypt)
                {
                    cryptStream = new CryptoStream(fsOutput, AESProvides.CreateEncryptor(), CryptoStreamMode.Write);
                }
                else
                {
                    cryptStream = new CryptoStream(fsOutput, AESProvides.CreateDecryptor(), CryptoStreamMode.Write);
                }

                //doc tu inputfile, ma hoa va ghi outputfile
                while (rdLen < totalLen)
                {
                    Len = fsInput.Read(bin, 0, numberBytesRead);
                    cryptStream.Write(bin, 0, Len);
                    rdLen += Len;
                    progressBar1.Value = (int)((rdLen * 100) / totalLen);
                }

                if (progressBar1.IsHandleCreated && isEncryptFile)
                {
                    Process prc = new Process();
                    prc.StartInfo.FileName = Path.GetDirectoryName(txtOutput.Text);
                    prc.Start();
                }
                cryptStream.Close();
                fsInput.Close();
                fsOutput.Close();
            }
            catch (Exception ioex)
            {
                MessageBox.Show("Failed: " + ioex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void btnExit_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            AesCryptoServiceProvider aes = new AesCryptoServiceProvider();
            if(cbbBit.Text.Trim().Length != 0)
            {
                if(cbbBit.Text.Trim() == "128bit")
                {
                    aes.KeySize = 128;
                }
                else if(cbbBit.Text.Trim() == "192bit")
                {
                    aes.KeySize = 192;
                }
                else
                {
                    aes.KeySize = 256;
                }
                aes.GenerateKey();
                txtKey.Text = Convert.ToBase64String(aes.Key);
            }
            else
            {
                MessageBox.Show("Hãy chọn độ dài khoá!.");
            }

        }

        private void frmAES_Load(object sender, EventArgs e)
        {
            this.cbbBit.Text = "256bit";
            this.cbbMode.Text = "CBC";
            this.cbbSeclectType.Text = "File";
            this.lblKey.BackColor = Color.Transparent;
            this.lblInput.BackColor = Color.Transparent;
            this.lblMode.BackColor = Color.Transparent;
            this.lblOutput.BackColor = Color.Transparent;
            this.lblStatus.BackColor = Color.Transparent;
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            if(cbbSeclectType.Text == "File")
            {
                this.isEncryptFile = true;
                this.txtOutput.Clear();
                OpenFileDialog op = new OpenFileDialog();

                if(txtInput.Text.Trim().Length !=0)
                op.InitialDirectory = Path.GetDirectoryName(txtInput.Text);

                op.Filter = "All file (*.*)|*.*";

                if (op.ShowDialog() == DialogResult.OK)
                {
                    this.txtInput.Text = op.FileName;
                }
            }
            else
            {
                this.isEncryptFile = false;
                this.txtOutput.Clear();
                FolderBrowserDialog fd = new FolderBrowserDialog();
                if (fd.ShowDialog() == DialogResult.OK)
                {
                    this.txtInput.Text = fd.SelectedPath;
                }
            }
           
        }

        private void btnFolder_Click(object sender, EventArgs e)
        {
            if (txtOutput.Text.Trim().Length > 0)
            {
                try
                {
                    Process prc = new Process();
                    if (!isEncryptFile)
                    {
                        prc.StartInfo.FileName = txtOutput.Text;
                    }
                    else
                    {
                        prc.StartInfo.FileName = Path.GetDirectoryName(txtOutput.Text);
                    }
                    prc.Start();
                }catch(Exception ioex)
                {
                    MessageBox.Show("Failed: " + ioex.Message);
                }
            }
            else
            {
                MessageBox.Show("Thư mục đang được mã hoá hoặc giải mã..");
            }
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            if(txtInput.Text.Trim() != "" && txtKey.Text.Trim() != "" && cbbMode.Text.Trim()!="")
            {
                Stopwatch sw = new Stopwatch();
                sw.Start();
                enabledOrDisableButtons(false);

                //khai bao
                string inputFileName, outputFileName = "", mode, key;
                inputFileName = txtInput.Text;
                key = txtKey.Text;
                if(key.Length < 8)
                {
                    MessageBox.Show("Bạn phải nhập key >=8 kí tự..");
                    enabledOrDisableButtons(true);
                    return;
                }

                if (isEncryptFile)
                {
                    outputFileName = txtInput.Text + ".Encrypt";
                    txtOutput.Text = outputFileName;
                }
                //set mode
                mode = cbbMode.Text.Trim();
                //fix up key cho lengt
                if (key.Length !=32 && key.Length != 24 && key.Length != 44)
                {
                    for(int i=0; i< 32 - txtKey.Text.Trim().Length; i++)
                    {
                        key += "g";   // fix cho key co do dai tieu chuan
                    }
                }

                if (key.Length == 24) key = key.Substring(0, 22) + "==";
                if (key.Length == 44) key = key.Substring(0, 43) + "=";
                //ma hoa file
                if (this.isEncryptFile)
                {
                    AESAlgorithm(inputFileName, outputFileName, key, true, mode);
                   //
                }
                else
                {
                    string[] filePaths = Directory.GetFiles(inputFileName);
                    if(cbbSeclectType.Text == "Folder")
                    {
                        filePaths = Directory.GetFiles(inputFileName, "*", SearchOption.AllDirectories);
                    }
                    if(filePaths.Length ==0 || (filePaths.Length ==1 && Path.GetFileName(filePaths[0]) == "Thumbs.db"))
                    {
                        MessageBox.Show("Thư mục hiện tại rỗng..!\n Vui lòng nhập lại..");
                        enabledOrDisableButtons(true);
                        return;
                    }
                    outputFileName = filePaths[0];
                    this.txtOutput.Text = Path.GetDirectoryName(outputFileName);
                    for(int i=0; i< filePaths.Length; i++)
                    {
                        if(Path.GetFileName(filePaths[i])!= "Thumbs.db")
                        {
                            AESAlgorithm(filePaths[i], filePaths[i] + ".Encrypt", key, true, mode);
                        }
                    }
                }

                enabledOrDisableButtons(true);
                sw.Stop();
                double times = sw.Elapsed.TotalMilliseconds / 1000;
                MessageBox.Show("Tổng thời gia thực Thi: "+ times.ToString() + " giây");
            }
            else
            {
                MessageBox.Show("Thiếu Dữ Liệu..\n Vui lòng kiểm tra lại files, key hoặc mode...", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnDencrypt_Click(object sender, EventArgs e)
        {

            if(txtInput.Text.Trim() != "" && txtKey.Text.Trim() != "" && cbbMode.Text.Trim() != "")
            {

                Stopwatch sw = new Stopwatch();
                sw.Start();
                enabledOrDisableButtons(false);

                string inputFileName, outputFileName = "", mode, key;
                inputFileName = txtInput.Text;
               
                if(isEncryptFile && Path.GetExtension(inputFileName) != ".Encrypt")
                {
                    MessageBox.Show("Tập tin không hỗ trợ Giải Mã..\n Hãy chọn lại định dạng '*.Encrypt' ");
                    enabledOrDisableButtons(true);
                    return;

                }

                key = txtKey.Text;

                 if(key.Length < 8)
                {
                    MessageBox.Show("Key phải >= 8..\n Nhập Lại..!", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    enabledOrDisableButtons(true);
                    return;
                }

                if (isEncryptFile)
                {
                    outputFileName = txtInput.Text.Substring(0,txtInput.Text.Length - 8);
                    this.txtOutput.Text = outputFileName;
                }

                mode = cbbMode.Text;

                if (key.Length != 32 && key.Length != 24 && key.Length != 44)
                {
                    for (int i = 0; i < 32 - txtKey.Text.Trim().Length; i++)
                    {
                        key += "g";   // fix cho key co do dai tieu chuan
                    }
                }
                if (key.Length == 24) key = key.Substring(0, 22) + "==";
                if (key.Length == 44) key = key.Substring(0, 43) + "=";

                if (isEncryptFile)
                {
                    AESAlgorithm(inputFileName, outputFileName, key, false, mode);
                }
                else
                {
                    string[] filePaths = Directory.GetFiles(inputFileName, "*.Encrypt");
                    if(cbbSeclectType.Text == "Folder")
                    {
                        filePaths = Directory.GetFiles(inputFileName, "*.Encrypt", SearchOption.AllDirectories);
                    }
                    if(filePaths.Length ==0 || ( filePaths.Length ==1 && Path.GetFileName(filePaths[0])=="Thumbs.db" ))
                    {
                        MessageBox.Show("Thư mục hiện tại không có chứa file dạng *.Encrypt");
                        enabledOrDisableButtons(true);
                        return;
                    }

                    outputFileName = filePaths[0];
                    this.txtOutput.Text = Path.GetDirectoryName(outputFileName);

                    for(int i = 0; i < filePaths.Length; i++)
                    {
                        if (Path.GetFileName(filePaths[i]) != "Thumbs.db")
                        {
                            AESAlgorithm(filePaths[i], filePaths[i].Substring(0, filePaths[i].Length - 8), key,false, mode);
                        }
                    }



                }
                enabledOrDisableButtons(true);
                sw.Stop();
                double times = sw.Elapsed.TotalMilliseconds / 1000;
                MessageBox.Show("Thời Gian thực thi là: " + times.ToString() + " giây.");

            }
            else
            {
                MessageBox.Show("Thiếu Dữ Liệu..\n Vui lòng kiểm tra lại files, key hoặc mode...", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            this.txtInput.Text = "";
            this.txtKey.Text = "";
            this.txtOutput.Text = "";
            this.cbbBit.Text = "256bit";
            this.cbbMode.Text = "CBC";
            this.cbbSeclectType.Text = "File";
        }
    }
}
