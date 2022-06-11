using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Windows.Forms;
namespace projeberen
{
    class Login
    {
        Giris frm = new Giris();
        



        //public void giris()
        //{
        //    OleDbConnection bağlantı = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "\\beren.mdb");
        //    bağlantı.Open();
        //    OleDbCommand cmd = new OleDbCommand("Select Ad,Sifre from Kayıt", bağlantı);
        //    OleDbDataReader oku = cmd.ExecuteReader();
        //    while (oku.Read())
        //    {
        //        if (Kadı == oku["Ad"].ToString() && Sifre == oku["Sifre"].ToString())
        //        {
        //            this.Close();
        //            a.Show();
        //        }
        //        else
        //        {
        //            MessageBox.Show("Şifre Yanlış... Lütfen Tekrar Deneyiniz");
        //        }
        //    }
        //}
        public void cıkıs()
        {
            DialogResult sonuc = MessageBox.Show("Çıkış yapmak istiyor musunuz?", "Çıkış", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
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
