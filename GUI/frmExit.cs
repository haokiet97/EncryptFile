using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EncryptFile.GUI
{
    public partial class frmExit : Form
    {
        public frmExit()
        {
            InitializeComponent();
        }

        private void frmExit_Load(object sender, EventArgs e)
        {
            try
            {
                
                this.lblNote.BackColor = Color.Transparent;
                this.btnOk.BackColor = Color.Transparent;
                this.btnCancel.BackColor = Color.Transparent;
            }catch (Exception ex)
            {

            }
            
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
