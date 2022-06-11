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
using System.Data.OleDb;
namespace projeberen
{
    public partial class OgrGiris : DevExpress.XtraEditors.XtraForm
    {
        public OgrGiris()
        {
            InitializeComponent();
        }
        bool control;
        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Login cikis = new Login();
            cikis.cıkıs();
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

        private void bunifuTileButton8_Click(object sender, EventArgs e)
        {
            OgrOkuyucuLst ogrlist = new OgrOkuyucuLst();
            ogrlist.ShowDialog();
        }

        private void bunifuTileButton7_Click(object sender, EventArgs e)
        {
            OgrListele lst = new OgrListele();
            lst.ShowDialog();
        }

        private void bunifuTileButton6_Click(object sender, EventArgs e)
        {
            EmanetListele EmanetListele = new EmanetListele();
            EmanetListele.ShowDialog();
        }

        private void bunifuTileButton3_Click(object sender, EventArgs e)
        {
            EmanetVer EmanetVer = new EmanetVer();
            EmanetVer.ShowDialog();
        }

        private void bunifuTileButton9_Click(object sender, EventArgs e)
        {
            frmİade iade = new frmİade();
            iade.ShowDialog();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.Close();
            Giris grs = new Giris();
            grs.Show();
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            Login cikis = new Login();
            cikis.cıkıs();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
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

        private void kucuk_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}