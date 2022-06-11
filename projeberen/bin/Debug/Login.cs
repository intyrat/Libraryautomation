using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Data.OleDb;

namespace proje
{
    class Login
    {
        Giris frm = new Giris();
        AnaEkran a = new AnaEkran();
        public string kadı { get; set; }
        public string sifre { get; set; }

        public void giris()
        {
            OleDbConnection bağlantı = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source="+Application.StartupPath+"\\beren.mdb");
            bağlantı.Open();
            OleDbCommand cmd = new OleDbCommand("Select Ad,Sifre from Kayıt", bağlantı);
            OleDbDataReader oku = cmd.ExecuteReader();
            while (oku.Read())
            {
                if (kadı == oku["Ad"].ToString() && sifre == oku["Sifre"].ToString())
                {
                    a.Show();
                }
                else
                {
                    MessageBox.Show("Şifre Yanlış... Lütfen Tekrar Deneyiniz...");
                }
            }
        }
        public void cıkıs()
        {
            DialogResult sonuc = MessageBox.Show("Çıkış yapmak istiyormusunuz", "Çıkış", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (sonuc == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {

            }
        }

        



    }
}
