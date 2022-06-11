using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace projeberen
{
    public partial class AnaEkran : DevExpress.XtraEditors.XtraForm
    {
        public AnaEkran()
        {
            InitializeComponent();
        }
        bool control;
        private void AnaEkran_Load(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Login cikis = new Login();
            cikis.cıkıs();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            Okuyucu Okuyucu = new Okuyucu();
            Okuyucu.ShowDialog();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            KitapEkle Kitapekle = new KitapEkle();
            Kitapekle.ShowDialog();
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            EmanetVer EmanetVer = new EmanetVer();
            EmanetVer.ShowDialog();
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            frmİade iade = new frmİade();
            iade.ShowDialog();
        }

        private void bunifuFlatButton5_Click(object sender, EventArgs e)
        {
            OkuyucuListele OkuyucuListele = new OkuyucuListele();
            OkuyucuListele.ShowDialog();
        }

        private void bunifuFlatButton6_Click(object sender, EventArgs e)
        {
            KitapListele KitapListele = new KitapListele();
            KitapListele.ShowDialog();
        }

        private void bunifuFlatButton7_Click(object sender, EventArgs e)
        {
            EmanetListele EmanetListele = new EmanetListele();
            EmanetListele.ShowDialog();
        }

        private void bunifuTileButton1_Click(object sender, EventArgs e)
        {
            Okuyucu Okuyucu = new Okuyucu();
            Okuyucu.ShowDialog();
        }

        private void bunifuTileButton2_Click(object sender, EventArgs e)
        {
            KitapEkle Kitapekle = new KitapEkle();
            Kitapekle.ShowDialog();
        }

        private void bunifuTileButton3_Click(object sender, EventArgs e)
        {
            EmanetVer EmanetVer = new EmanetVer();
            EmanetVer.ShowDialog();
        }

        private void bunifuTileButton4_Click(object sender, EventArgs e)
        {
            frmİade iade = new frmİade();
            iade.ShowDialog();
        }

        private void bunifuTileButton8_Click(object sender, EventArgs e)
        {
            OkuyucuListele OkuyucuListele = new OkuyucuListele();
            OkuyucuListele.ShowDialog();
        }

        private void bunifuTileButton7_Click(object sender, EventArgs e)
        {
            KitapListele KitapListele = new KitapListele();
            KitapListele.ShowDialog();
        }

        private void bunifuTileButton6_Click(object sender, EventArgs e)
        {
            EmanetListele EmanetListele = new EmanetListele();
            EmanetListele.ShowDialog();
        }

        private void bunifuFlatButton8_Click(object sender, EventArgs e)
        {

        }

        private void bunifuTileButton9_Click(object sender, EventArgs e)
        {
            frmİade iade = new frmİade();
            iade.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int x, y, z;
            x = rnd.Next(255);
            y = rnd.Next(255);
            z = rnd.Next(255);
            label1.ForeColor = Color.FromArgb(x, y, z);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuTileButton5_Click(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.Close();
            Giris grs = new Giris();
            grs.Show();
        }

        private void bunifuTileButton4_Click_1(object sender, EventArgs e)
        {
            Odul odl = new Odul();
            odl.ShowDialog();
        }

        private void kucultme_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void normal_Click(object sender, EventArgs e)
        {
            

        }

        private void buyutme_Click(object sender, EventArgs e)
        {
            

        }

        private void bunifuFlatButton1_Click_1(object sender, EventArgs e)
        {
            
            if (control == false)
            {
                control = true;
                WindowState = FormWindowState.Maximized;

            }
            else if (control == true)
            {
                control = false;
                WindowState = FormWindowState.Normal;
            }
                                     
            
        }
    }
}