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
using DevExpress.Utils.Drawing;
using System.Data.OleDb;
namespace projeberen
{
    public partial class Giris : DevExpress.XtraEditors.XtraForm
    {
        public Giris()
        {
            InitializeComponent();
        }
        public string kadi, sifre,kadii,sifree;
        bool control;
        private void Giris_Load(object sender, EventArgs e)
        {
            bunifuImageButton6.Hide();
            bunifuImageButton7.Hide();
            bunifuImageButton8.Hide();
            
            bunifuImageButton10.Hide();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Login cikis = new Login();
            cikis.cıkıs();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuTileButton2_Click(object sender, EventArgs e)
        {

        }

        private void Giris_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                kadi = bunifuMaterialTextbox1.Text;
                sifre = bunifuMaterialTextbox2.Text;

                OleDbConnection bağlantı = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "\\beren.mdb");
                bağlantı.Open();
                OleDbCommand cmd = new OleDbCommand("Select Ad,Sifre from Kayıt", bağlantı);
                OleDbDataReader oku = cmd.ExecuteReader();
                while (oku.Read())
                {
                    if (kadi == oku["Ad"].ToString() && sifre == oku["Sifre"].ToString())
                    {
                        this.Hide();
                        AnaEkran a = new AnaEkran();
                        a.Show();
                    }
                    else
                    {
                        MessageBox.Show("Şifre Yanlış... Lütfen Tekrar Deneyiniz");
                    }

                }

            }
            if (e.KeyCode == Keys.Escape)
            {
                Application.Exit();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuMaterialTextbox2_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuTileButton2_Click_1(object sender, EventArgs e)
        {

        }

        private void bunifuTileButton4_Click(object sender, EventArgs e)
        {

        }

        private void bunifuTileButton3_Click(object sender, EventArgs e)
        {

        }

        private void bunifuTileButton1_Click_1(object sender, EventArgs e)
        {

        }

        private void bunifuTileButton2_Click_2(object sender, EventArgs e)
        {

        }

        private void bunifuTileButton1_Click_2(object sender, EventArgs e)
        {

        }

        private void bunifuTileButton2_Click_3(object sender, EventArgs e)
        {
            bool control= false;
            string adi, sif;
            adi = bunifuMaterialTextbox1.Text;
            sif = bunifuMaterialTextbox2.Text;

            OleDbConnection bağlantı = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "\\beren.mdb");
            bağlantı.Open();
            OleDbCommand cmd = new OleDbCommand("Select Ad,Sifre from OgrKayit", bağlantı);
            OleDbDataReader oku = cmd.ExecuteReader();
            while (oku.Read())
            {
                if (adi == oku["Ad"].ToString() && sif == oku["Sifre"].ToString())
                {
                    control = true;
                }

            }
            if (control == true)
            {
                this.Hide();
                OgrGiris ab = new OgrGiris();
                ab.Show();
            }
            else
            {
                MessageBox.Show("Kullacı adı veya şifre yanlış");
            }
            //if (adi == oku["Ad"].ToString() && sif == oku["Sifre"].ToString())
            //{ olası bir durumda kullanırım
            //    this.Hide();
            //    OgrGiris ab = new OgrGiris();
            //    ab.Show();
            //}

            //else
            //{
            //    MessageBox.Show("Şifre Yanlış... Lütfen Tekrar Deneyiniz");
            //}
        }

        private void bunifuTileButton1_Click_3(object sender, EventArgs e)
        {
            Login cikis = new Login();
            cikis.cıkıs();
        }

        private void bunifuImageButton2_Click_1(object sender, EventArgs e)
        {
            if (bunifuMaterialTextbox2.isPassword == true)
            {
                bunifuMaterialTextbox2.isPassword = false;
            }
            else
            {
                bunifuMaterialTextbox2.isPassword = true;
            }
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            if (bunifuMaterialTextbox4.isPassword == true)
            {
                bunifuMaterialTextbox4.isPassword = false;
            }
            else
            {
                bunifuMaterialTextbox4.isPassword = true;
            }
        }

        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/profile.php?id=100015872830107");
        }

        private void bunifuImageButton9_Click(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton6_Click(object sender, EventArgs e)
        {
            
            System.Diagnostics.Process.Start("https://www.instagram.com/pshscott/");
        }

        private void bunifuImageButton5_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://mail.google.com/mail/u/0/#inbox");
        }

        private void bunifuImageButton7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuImageButton8_Click(object sender, EventArgs e)
        {
            hakkımda hm = new hakkımda();
            hm.ShowDialog();
        }

        private void bunifuImageButton10_Click(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton4_Click_1(object sender, EventArgs e)
        {
            

        }

        private void bunifuImageButton5_Click_1(object sender, EventArgs e)
        {
            if (control == false)
            {
                control = true;
                bunifuTransition1.ShowSync(bunifuImageButton7);
                bunifuTransition1.ShowSync(bunifuImageButton6);
                bunifuTransition1.ShowSync(bunifuImageButton8);
                bunifuTransition1.ShowSync(bunifuImageButton10);


            }
            else if (control == true)
            {
                control = false;
                bunifuTransition1.HideSync(bunifuImageButton6);
                bunifuTransition1.HideSync(bunifuImageButton8);
                bunifuTransition1.HideSync(bunifuImageButton10);
                bunifuTransition1.HideSync(bunifuImageButton7);

            }

        }

        private void bunifuImageButton6_Click_1(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.instagram.com/pshscott/");
        }

        private void bunifuImageButton7_Click_1(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/profile.php?id=100015872830107");
        }

        private void bunifuImageButton9_Click_1(object sender, EventArgs e)
        {
            
        }

        private void bunifuImageButton8_Click_1(object sender, EventArgs e)
        {
           
        }

        private void bunifuImageButton10_Click_1(object sender, EventArgs e)
        {
            hakkımda hm = new hakkımda();
            hm.ShowDialog();
        }

        private void bunifuImageButton8_Click_2(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://twitter.com/tedoji");
            
        }

        private void bunifuTileButton4_Click_1(object sender, EventArgs e)
        {
            kadi = bunifuMaterialTextbox3.Text;
            sifre = bunifuMaterialTextbox4.Text;

            OleDbConnection bağlantı = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "\\beren.mdb");
            bağlantı.Open();
            OleDbCommand cmd = new OleDbCommand("Select Ad,Sifre from Kayıt", bağlantı);
            OleDbDataReader oku = cmd.ExecuteReader();
            while (oku.Read())
            {
                if (kadi == oku["Ad"].ToString() && sifre == oku["Sifre"].ToString())
                {
                    this.Hide();
                    AnaEkran a = new AnaEkran();
                    a.Show();
                }
                else
                {
                    MessageBox.Show("Şifre Yanlış... Lütfen Tekrar Deneyiniz");
                }
            }
        }

        private void bunifuTileButton1_Click_4(object sender, EventArgs e)
        {
            OgrKayit or = new OgrKayit();
            or.ShowDialog();
        }

        private void bunifuTileButton1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
