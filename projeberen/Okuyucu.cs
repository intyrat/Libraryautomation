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
    public partial class Okuyucu : DevExpress.XtraEditors.XtraForm
    {
        public Okuyucu()
        {
            InitializeComponent();
        }
        OleDbConnection bağlantı = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "\\beren.mdb");
        OleDbCommand komut = new OleDbCommand();
        public void temizle()
        {
            bunifuMaterialTextbox1.Text = "";
            bunifuMaterialTextbox2.Text = "";
            bunifuMaterialTextbox3.Text = "";
            comboBox1.Text = "";
            comboBox2.Text = "";
        }
        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuTileButton1_Click(object sender, EventArgs e)
        {
            try
            {
                bağlantı.Open();
                komut.Connection = bağlantı;
                komut.Parameters.Clear();
                komut.CommandText = "insert into ogrencikayit(Ad,Soyad,Numara,Sinif,Sube)values(@ad,@soyad,@numara,@sinif,@sube)";
                komut.Parameters.AddWithValue("@ad", bunifuMaterialTextbox1.Text);
                komut.Parameters.AddWithValue("@soyad", bunifuMaterialTextbox2.Text);
                komut.Parameters.AddWithValue("@numara", bunifuMaterialTextbox3.Text);
                komut.Parameters.AddWithValue("@sinif", comboBox1.Text);
                komut.Parameters.AddWithValue("@sube", comboBox2.Text);
                komut.ExecuteNonQuery();
                bağlantı.Close();
                temizle();

                MessageBox.Show("Kişi Kaydedildi");





            }
            catch (Exception)
            {
                MessageBox.Show("bu numaraya sahip öğrenci bulunmaktadır");
            }
        }


        private void Okuyucu_Load(object sender, EventArgs e)
        {

        }
    }
}