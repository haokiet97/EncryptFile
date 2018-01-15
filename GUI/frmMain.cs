using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media.Effects;

namespace EncryptFile
{
    public partial class frmMain : Form
    {

        private bool isSound = true;
        private SoundPlayer soundplay = new SoundPlayer();
        int i = 0;
        System.Windows.Forms.Timer t;
        FlowerEffect[] FE;
       // Thread ThEffect;



        public frmMain()
        {
            InitializeComponent();
            soundplay.SoundLocation = "backgroundsound.wav";
            soundplay.Play();
        }

       
        private void frmMain_Load(object sender, EventArgs e)
        {
            int x = Screen.PrimaryScreen.Bounds.Size.Width + 20;
            int y = Screen.PrimaryScreen.Bounds.Size.Height + 20;
            this.Size = Screen.PrimaryScreen.Bounds.Size + new Size(20,20);
            this.Location = new Point(0, 0);
            this.FormBorderStyle = FormBorderStyle.None;
            //
            this.ptbAES.Location = new Point(1009 * x / 1920, 311 * y / 1080);
            this.ptbRSA.Location = new Point(1051 * x / 1920, 624 * y / 1080);
            this.ptbDES.Location = new Point(1359 * x / 1920, 401 * y / 1080);
            this.ptbExit.Location = new Point(1410 * x / 1920, 712 * y / 1080);
            this.ptbSound.Location = new Point(1802 * x / 1920, 42 * y / 1080);
            //
            this.ptbSound.BackColor = Color.Transparent;
            this.ptbAES.BackColor = Color.Transparent;
            this.ptbDES.BackColor = Color.Transparent;
            this.ptbRSA.BackColor = Color.Transparent;
            this.ptbExit.BackColor = Color.Transparent;
            this.ptbTittle.BackColor = Color.Transparent;
            //effect

           this. Effect();
        }
        private void Effect()
        {
            FE = new FlowerEffect[100];
            t = new System.Windows.Forms.Timer();
            t.Interval = 100;
            t.Tick += new EventHandler(t_Tick);
            t.Start();
        }
        private void t_Tick(object sender, EventArgs e)
        {
            if(i > 20)
            {
                t.Stop();
                return;
            }
            FE[i] = new FlowerEffect();
            Controls.Add(FE[i]);
            i++;
        }

        private void ptbExit_Click(object sender, EventArgs e)
        {
            //ThEffect.Abort();
            GUI.frmExit fr = new GUI.frmExit();
            fr.ShowDialog();
           // Application.Exit();
        }

        private void ptbAES_MouseHover(object sender, EventArgs e)
        {
            ptbAES.Image = new Bitmap(Application.StartupPath+"\\RESOURCES\\btnAESSel.png");
        }

        private void ptbAES_MouseLeave(object sender, EventArgs e)
        {
            ptbAES.Image = new Bitmap(Application.StartupPath + "\\RESOURCES\\btnAESNon.png");
        }

        private void ptbDES_MouseHover(object sender, EventArgs e)
        {
            ptbDES.Image = new Bitmap(Application.StartupPath + "\\RESOURCES\\btnDESSel.png");
        }

        private void ptbDES_MouseLeave(object sender, EventArgs e)
        {
            ptbDES.Image = new Bitmap(Application.StartupPath + "\\RESOURCES\\btnDESNon.png");
        }

      

        private void ptbRSA_MouseHover(object sender, EventArgs e)
        {
            ptbRSA.Image = new Bitmap(Application.StartupPath + "\\RESOURCES\\btnRSASel.png");
        }

        private void ptbRSA_MouseLeave(object sender, EventArgs e)
        {
            ptbRSA.Image = new Bitmap(Application.StartupPath + "\\RESOURCES\\btnRSANon.png");
        }

        private void ptbExit_MouseHover(object sender, EventArgs e)
        {
            ptbExit.Image = new Bitmap(Application.StartupPath + "\\RESOURCES\\btnExitSelected.png");
        }

        private void ptbExit_MouseLeave(object sender, EventArgs e)
        {
            ptbExit.Image = new Bitmap(Application.StartupPath + "\\RESOURCES\\btnExit.png");
        }

        private void ptbDES_Click(object sender, EventArgs e)
        {
            //tat sound
            this.isSound = true;
            ptbSound_Click(null, null);
            //hien dialog
            GUI.frmDES fr = new GUI.frmDES();
            fr.ShowDialog();
            // bat sound
            ptbSound_Click(null, null);
        }

        private void ptbAES_Click(object sender, EventArgs e)
        {
            //tat sound
            this.isSound = true;
            ptbSound_Click(null, null);
            //hien dialog
            frmAES fr = new frmAES();
            fr.ShowDialog();
            // bat sound
            ptbSound_Click(null, null);
        }

        private void ptbSound_Click(object sender, EventArgs e)
        {
            if (this.isSound)
            {
                this.soundplay.Stop();
                this.ptbSound.Image = new Bitmap(Application.StartupPath+ "\\RESOURCES\\btnSound_off.png");
                this.isSound = false;
            }
            else
            {
                this.soundplay.PlayLooping();
                this.ptbSound.Image = new Bitmap(Application.StartupPath + "\\RESOURCES\\btnSound_on.png");
                this.isSound = true;
            }

        }

        private void ptbRSA_Click(object sender, EventArgs e)
        {
            //tat sound
            this.isSound = true;
            ptbSound_Click(null, null);
            //hien dialog
            GUI.frmRSA fr = new GUI.frmRSA();
            fr.ShowDialog();
            // bat sound
            ptbSound_Click(null, null);
        }
    }

    public class FlowerEffect : PictureBox
    {

        Random rd = new Random();
        public FlowerEffect()
        {
            Create();
            Move();

        }
        public void Create()
        {
            this.Location = new Point(rd.Next(Screen.PrimaryScreen.Bounds.Width), rd.Next(Screen.PrimaryScreen.Bounds.Height));
            this.MinimumSize = new Size(10, 10);
            this.Size = new Size(35, 35);

            int ImgRd = rd.Next(1, 6);

            switch (ImgRd)
            {
                case 1 :
                    this.BackgroundImage = Image.FromFile("la1.png");
                    break;
                case 2:
                    this.BackgroundImage = Image.FromFile("la2.png");
                    break;
                case 3:
                    this.BackgroundImage = Image.FromFile("la3.png");
                    break;
                case 4:
                    this.BackgroundImage = Image.FromFile("la4.png");
                    break;
                case 5:
                    this.BackgroundImage = Image.FromFile("la5.png");
                    break;
                case 6:
                    this.BackgroundImage = Image.FromFile("la6.png");
                    break;
            }
            this.BackgroundImageLayout = ImageLayout.Stretch;
            this.BackColor = Color.Transparent;

        }
        public void Move()
        {
            System.Windows.Forms.Timer t = new System.Windows.Forms.Timer();
            t.Interval = 100;
            t.Tick += new EventHandler(t_Tick);
            t.Start();
        }

        private void t_Tick(object sender, EventArgs e)
        {
            this.Location += new Size(2, -1);
            if (this.Location.X > Screen.PrimaryScreen.Bounds.Width || this.Location.Y < 0)
            {
                this.Location = new Point(rd.Next(0, Screen.PrimaryScreen.Bounds.Width), rd.Next(0, Screen.PrimaryScreen.Bounds.Height));

            }
        }
    }
}
