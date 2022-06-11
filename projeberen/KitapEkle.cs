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
    public partial class KitapEkle : DevExpress.XtraEditors.XtraForm
    {
        public KitapEkle()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "\\beren.mdb");
        OleDbCommand komut = new OleDbCommand();
        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuTileButton1_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                OleDbCommand cmd = new OleDbCommand("Select * from Kitap", baglanti);
                
                        komut.Connection = baglanti;
                        komut.Parameters.Clear();
                        komut.CommandText = "insert into Kitap(Barkod,Kitap_Yazari,Kitap_Adi,emanet)values(@barkod,@yazar,@kitapadi,@emanet)";
                        komut.Parameters.AddWithValue("@barkod", bunifuMaterialTextbox1.Text);
                        komut.Parameters.AddWithValue("@kitapadi", bunifuMaterialTextbox2.Text);
                        komut.Parameters.AddWithValue("@yazar", bunifuMaterialTextbox3.Text);
                        komut.Parameters.AddWithValue("@emanet", "0");
                        komut.ExecuteNonQuery();
                        MessageBox.Show("Kitap Kaydedildi");
                        bunifuMaterialTextbox1.Text = "";
                        bunifuMaterialTextbox2.Text = "";
                        bunifuMaterialTextbox3.Text = "";
                    

                
                
                baglanti.Close();
            }
            catch(Exception)
            {
                MessageBox.Show("Aynı barkoda sahip kitap bulunmakta");
            }


        }
    }
}