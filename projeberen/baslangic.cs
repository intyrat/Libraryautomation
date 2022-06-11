using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;

namespace projeberen
{

    public partial class baslangic : DevExpress.XtraEditors.XtraForm
    {

        public baslangic()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            timer1.Interval = 40;
            if (metroProgressBar1.Value != 100)
            {
                metroProgressBar1.Value += 1;
                label2.Text = metroProgressBar1.Value.ToString();
                if (metroProgressBar1.Value == 100)
                {

                    Giris g = new Giris();
                    g.Show();
                    this.Hide();
                }
            }
        }

        private void baslangic_Load(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(Image.FromFile(Application.StartupPath + "\\berenn.png"));
            Graphics g = Graphics.FromImage(bmp);
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            this.BackgroundImage = bmp;
            this.BackColor = Color.Black;
            this.FormBorderStyle = FormBorderStyle.None;
            this.Width = this.BackgroundImage.Width;
            this.Height = this.BackgroundImage.Height;
            this.TransparencyKey = Color.Black;
            this.TopMost = true;
            pictureBox1.Image = Image.FromFile(Application.StartupPath + "\\beros.gif");
            this.Height = 451;
            this.Width = 443;
            timer1.Start();
            timer1.Enabled = true;

        }
    }
}
