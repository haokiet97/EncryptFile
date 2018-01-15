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

namespace EncryptFile.GUI
{
    public partial class frmDES : Form
    {
        private bool isEncryptFile =true;
        public frmDES()
        {
            InitializeComponent();
        }

        private void frmDES_Load(object sender, EventArgs e)
        {
            this.cbbTypeFile.Text = "File";
            this.cbbMode.Text = "CBC";
            this.lblKey.BackColor = Color.Transparent;
            this.lblInput.BackColor = Color.Transparent;
            this.lblMode.BackColor = Color.Transparent;
            this.lblOutput.BackColor = Color.Transparent;
            this.lblStatus.BackColor = Color.Transparent;

        }

        private void EnableOrDisableButton(bool isEnable)
        {
            this.btnGenerate.Enabled = isEnable;
            this.btnSelect.Enabled = isEnable;
            this.btnReset.Enabled = isEnable;
            this.btnEncrypt.Enabled = isEnable;
            this.btnDecrypt.Enabled = isEnable;
            this.btnExit.Enabled = isEnable;
        }

        private void DESAlgorithm(string inputFile, string outputFile, string keys, bool isEncrypt, string mode)
        {
            try
            {

                if (!isEncrypt)   //set lai ten outputFile
                {
                    outputFile = Path.Combine(Path.GetDirectoryName(outputFile), Path.GetFileNameWithoutExtension(outputFile) + "_1" + Path.GetExtension(outputFile));
                }

                FileStream fsInput = new FileStream(inputFile, FileMode.Open, FileAccess.Read);
                FileStream fsOutput = new FileStream(outputFile, FileMode.OpenOrCreate, FileAccess.Write);

                fsOutput.SetLength(0);
                int NumberBytesRead = 10485760;
                Byte[] bin = new Byte[NumberBytesRead];
                long RdLen = 0;
                long TotalLen = fsInput.Length;
                int Len;

                progressBar1.Minimum = 0;
                progressBar1.Maximum = 100;

                //qua trinh

                DESCryptoServiceProvider DESProvider = new DESCryptoServiceProvider();

                try
                {
                    DESProvider.Key = Convert.FromBase64String(keys);
                    DESProvider.IV = Convert.FromBase64String(keys);//8byte
                    //ASCIIEncoding.ASCII.GetBytes(keys.Substring(0, 16));

                }
                catch (Exception ioex)
                {
                    MessageBox.Show("Lỗi: " + ioex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (mode == "CBC") DESProvider.Mode = CipherMode.CBC;
                else if (mode == "ECB") DESProvider.Mode = CipherMode.ECB;
                else if (mode == "CFB") DESProvider.Mode = CipherMode.CFB;

                CryptoStream cryptStream;

                if (isEncrypt)
                {
                    //MaHoa
                    cryptStream = new CryptoStream(fsOutput, DESProvider.CreateEncryptor(), CryptoStreamMode.Write);
                }
                else
                {
                    //GiaiMa
                    cryptStream = new CryptoStream(fsOutput, DESProvider.CreateDecryptor(), CryptoStreamMode.Write);
                }

              

                while (RdLen < TotalLen)
                {
                    Len = fsInput.Read(bin, 0, NumberBytesRead);
                    cryptStream.Write(bin, 0, Len);
                    RdLen += Len; 
                    progressBar1.Value = (int)((RdLen * 100) / TotalLen);
                 
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
            catch(Exception ioex)
            {
                MessageBox.Show("Lỗi: " + ioex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            DESCryptoServiceProvider des = new DESCryptoServiceProvider();
            des.GenerateKey();
            txtKey.Text = Convert.ToBase64String(des.Key);
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            if(cbbTypeFile.Text == "File")
            {
                this.isEncryptFile = true;
                txtOutput.Clear();

                OpenFileDialog op = new OpenFileDialog();
                if (txtInput.Text.Trim().Length != 0)
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
                txtOutput.Clear();
                FolderBrowserDialog fdb = new FolderBrowserDialog();
                if (fdb.ShowDialog() == DialogResult.OK)
                {
                    this.txtInput.Text = fdb.SelectedPath;
                }
            }
           

        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            if(this.txtOutput.Text.Trim().Length > 0)
            {

                try
                {
                    Process pc = new Process();
                    if (!isEncryptFile)
                    {
                        pc.StartInfo.FileName = txtOutput.Text;
                    }
                    else
                    {
                        pc.StartInfo.FileName = Path.GetDirectoryName(txtOutput.Text);
                    }
                    pc.Start();

                }
                catch (Exception ioex)
                {
                    MessageBox.Show("Lỗi: " + ioex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                MessageBox.Show("chương trình đang thực thi..\n Vui lòng thử lại sau.!");
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            this.txtInput.Clear();
            this.txtOutput.Clear();
            this.txtKey.Clear();
            this.cbbMode.Text = "CBC";
            this.cbbTypeFile.Text = "File";
            this.lblProgess.Text = "";
            this.progressBar1.Value = 0;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            EnableOrDisableButton(false);
            if(txtInput.Text.Trim().Length >0 && txtKey.Text.Trim().Length >0 && cbbMode.Text.Trim().Length > 0)
            {

                string inputFileName, outputFileName, key, mode;
                inputFileName = txtInput.Text;
                key = txtKey.Text.Trim();
                mode = cbbMode.Text.Trim();
                if(key.Trim().Length < 8)
                {
                    MessageBox.Show("Key phải dài hơn 8 kí tự..!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    EnableOrDisableButton(true);

                    return;
                }
                else if(key.Length > 12)
                {
                    key = key.Substring(0, 11)+"="; 
                }
                if (key.Length >= 8 || key.Length < 12) ;
                {
                    for(int i =0; i< 12- txtKey.Text.Length; i++)
                    {
                        key += "g";
                    }
                }

                if (isEncryptFile)
                {
                    outputFileName = txtInput.Text + ".Encrypt";
                    txtOutput.Text = outputFileName;
                    DESAlgorithm(inputFileName, outputFileName, key, true,mode);
                }
                else
                {
                    string[] filePath = Directory.GetFiles(inputFileName);
                    if(cbbTypeFile.Text.ToLower() == "file")
                    {
                        filePath = Directory.GetFiles(inputFileName, "*", SearchOption.AllDirectories);

                    }
                    if(filePath.Length ==0 || (filePath.Length ==1 && Path.GetDirectoryName(filePath[0]) == "Thumbs.db"))
                    {
                        MessageBox.Show("Thư mục rỗng..\nVui lòng nhập lại..!", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        EnableOrDisableButton(true);
                        return;
                    }
                    else
                    {
                        for(int i =0; i<filePath.Length; i++)
                        {
                            if(Path.GetFileName(filePath[i])!= "Thumbs.db")
                            {
                                DESAlgorithm(filePath[i], filePath[i] + ".Encrypt", key, true, mode);
                            }
                        }
                    }
                }
                EnableOrDisableButton(true);
            }
            else
            {
                MessageBox.Show("Thiếu Dữ Liệu..\n Vui lòng kiểm tra lại files, key hoặc mode...", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            if(txtInput.Text.Trim().Length !=0 && txtKey.Text.Trim().Length !=0 && cbbMode.Text.Trim().Length != 0)
            {

                EnableOrDisableButton(false);

               string inputFileName, outputFileName = "", mode, key;
                inputFileName = txtInput.Text;
                mode = cbbMode.Text;

                if (isEncryptFile && Path.GetExtension(inputFileName) != ".Encrypt")
                {
                    MessageBox.Show("Tập tin không hỗ trợ Giải Mã..\n Hãy chọn lại định dạng '*.Encrypt' ");
                    EnableOrDisableButton(true);
                    return;
                }

                key = txtKey.Text;
                if(key.Length < 8)
                {

                    MessageBox.Show("Key phải >= 8..\n Nhập Lại..!", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    EnableOrDisableButton(true);
                    return;
                }
                if (isEncryptFile)
                {
                    outputFileName = txtInput.Text.Substring(0, txtInput.Text.Length - 8);
                    txtOutput.Text = outputFileName;
                }

               
                //
                if (key.Length > 12)
                {
                    key = key.Substring(0, 11) + "=";
                }
                if (key.Length >= 8 || key.Length < 12) ;
                {
                    for (int i = 0; i < 12 - txtKey.Text.Length; i++)
                    {
                        key += "g";
                    }
                }
                //
                if (isEncryptFile)
                {
                    DESAlgorithm(inputFileName, outputFileName, key, false, mode);
                }
                else
                {
                    string[] filePaths = Directory.GetFiles(inputFileName, "*.Encrypt");

                    if(cbbTypeFile.Text == "Folder")
                    {
                        filePaths = Directory.GetFiles(inputFileName, "*.Encrypt", SearchOption.AllDirectories);
                    }
                    if (filePaths.Length == 0 || (filePaths.Length == 1 && Path.GetFileName(filePaths[0]) == "Thumbs.db"))
                    {
                        MessageBox.Show("Thư mục hiện tại không có chứa file dạng *.Encrypt");
                        EnableOrDisableButton(true);
                        return;
                    }

                    outputFileName = filePaths[0];
                    this.txtOutput.Text = Path.GetDirectoryName(outputFileName);
                    for(int i= 0; i< filePaths.Length; i++)
                    {
                        if(Path.GetFileName(filePaths[i])!= "Thumbs.db")
                        {
                            DESAlgorithm(filePaths[i], filePaths[i].Substring(0, filePaths[i].Length - 8),key,false,mode);
                        }
                    }
                }
                EnableOrDisableButton(true);
                MessageBox.Show("Đã Giải mã Xong..!\n Hãy Kiểm tra lại..!","Thông Báo",MessageBoxButtons.OK,MessageBoxIcon.Warning);

            }
            else
            {
                MessageBox.Show("Thiếu Dữ Liệu..\n Vui lòng kiểm tra lại files, key hoặc mode...", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }


        }
    }



}
