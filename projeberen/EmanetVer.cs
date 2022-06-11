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
    public partial class EmanetVer : DevExpress.XtraEditors.XtraForm
    {
        public EmanetVer()
        {
            InitializeComponent();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        string ad, soyad, numa, sınıf, sube, kadi, kyazari, kbarkod, emanet1;

        private void EmanetVer_Load(object sender, EventArgs e)
        {
            bunifuDatepicker1.Value = DateTime.Now;
        }

        private void bunifuMaterialTextbox2_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuTileButton1_Click(object sender, EventArgs e)
        {
            OleDbDataReader dr;
            OleDbConnection baglanti = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "\\beren.mdb");
            OleDbCommand komut = new OleDbCommand("select * from ogrencikayit where Numara=@numara", baglanti);
            komut.Parameters.AddWithValue("@numara", bunifuMaterialTextbox2.Text);
            baglanti.Open();
            dr = komut.ExecuteReader();
            while (dr.Read())
            {
                ad = dr[0].ToString();
                soyad = dr[1].ToString();
                numa = dr[2].ToString();
                sınıf = dr[3].ToString();
                sube = dr[4].ToString();
            }
            baglanti.Close();
            komut.Parameters.Clear();
            OleDbDataReader dr1;
            OleDbCommand komut1 = new OleDbCommand("select * from Kitap where Barkod=@barkod", baglanti);
            komut1.Parameters.AddWithValue("@barkod", bunifuMaterialTextbox1.Text);
            baglanti.Open();
            dr1 = komut1.ExecuteReader();
            while (dr1.Read())
            {
                emanet1 = dr1[3].ToString();
                if (emanet1 == "1")
                {
                    MessageBox.Show("Bu kitap zaten emanet verildi");
                    goto buraya;
                }
                kadi = dr1[2].ToString();
                kyazari = dr1[1].ToString();
                kbarkod = dr1[0].ToString();
            }
            baglanti.Close();
            
            OleDbCommand komut2 = new OleDbCommand("insert into emanet (Ad,Soyad,Numara,Sınıf,Sube,Kitapbarkod,kitapadi,kitapyazari,tarih) values (@Ad,@Soyad,@Numara,@Sınıf,@Sube,@Kitapbarkod,@kitapadi,@kitapyazari,@tarih)", baglanti);
            komut2.Parameters.AddWithValue("@Ad", ad);
            komut2.Parameters.AddWithValue("@Soyad", soyad);
            komut2.Parameters.AddWithValue("@Numara", numa);
            komut2.Parameters.AddWithValue("@Sınıf", sınıf);
            komut2.Parameters.AddWithValue("@Sube", sube);
            komut2.Parameters.AddWithValue("@Kitapbarkod", kbarkod);
            komut2.Parameters.AddWithValue("@kitapadi", kadi);
            komut2.Parameters.AddWithValue("@kitapyazari", kyazari);
            komut2.Parameters.AddWithValue("@tarih", bunifuDatepicker1.Value);
            baglanti.Open();
            komut2.ExecuteNonQuery();
            baglanti.Close();

            OleDbCommand cmd5 = new OleDbCommand("update Kitap set emanet=@emanet where Barkod=@barkod", baglanti);
            cmd5.Parameters.AddWithValue("@emanet", "1");
            cmd5.Parameters.AddWithValue("@barkod", kbarkod);
            baglanti.Open();
            cmd5.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Emanet Verildi");


            OleDbCommand cmd6 = new OleDbCommand("update ogrencikayit set alkitsay = alkitsay+1 where Ad=@ad",baglanti);
            cmd6.Parameters.Add("@ad", OleDbType.VarChar).Value = ad;
            baglanti.Open();
            cmd6.ExecuteNonQuery();
            baglanti.Close();
            bunifuMaterialTextbox1.Text = "";
            bunifuMaterialTextbox2.Text = "";
            buraya:;
            



        }
    }
}