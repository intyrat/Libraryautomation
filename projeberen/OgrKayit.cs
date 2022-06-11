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
    public partial class OgrKayit : DevExpress.XtraEditors.XtraForm
    {
        public OgrKayit()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "\\beren.mdb");
        OleDbCommand komut = new OleDbCommand();
        private void bunifuTileButton1_Click(object sender, EventArgs e)
        {
            if (bunifuMaterialTextbox1.Text != "" && bunifuMaterialTextbox2.Text != "")
            {
                baglanti.Open();
                komut.Connection = baglanti;
                komut.Parameters.Clear();
                komut.CommandText = "insert into OgrKayit(Ad,Sifre)values(@ad,@sifre)";
                komut.Parameters.AddWithValue("@ad", bunifuMaterialTextbox1.Text);
                komut.Parameters.AddWithValue("@sifre", bunifuMaterialTextbox2.Text);
                komut.ExecuteNonQuery();
                baglanti.Close();
                bunifuMaterialTextbox1.Text = "";
                bunifuMaterialTextbox2.Text = "";
                MessageBox.Show("Nöbetçi Kaydedildi");
                this.Close();
            }
            else
            {
                MessageBox.Show("Lütfen Kayıt Alanını Doldurunuz");
            }


        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
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
    }
}