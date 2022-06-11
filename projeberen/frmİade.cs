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
    public partial class frmİade : DevExpress.XtraEditors.XtraForm
    {
        public frmİade()
        {
            InitializeComponent();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuTileButton1_Click(object sender, EventArgs e)
        {
            OleDbConnection baglanti = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "\\beren.mdb");
            OleDbCommand cmd = new OleDbCommand("delete from emanet where Numara=@num and Kitapbarkod=@kitapbarkod", baglanti);
            cmd.Parameters.AddWithValue("@num", bunifuMaterialTextbox2.Text);
            cmd.Parameters.AddWithValue("@kitapbarkod", bunifuMaterialTextbox1.Text);
            baglanti.Open();
            cmd.ExecuteNonQuery();
            baglanti.Close();

            OleDbCommand cmd1 = new OleDbCommand("update Kitap set emanet=@emanet where Barkod=@barkod", baglanti);
            cmd1.Parameters.AddWithValue("@emanet", "0");
            cmd1.Parameters.AddWithValue("@barkod", bunifuMaterialTextbox1.Text);
            baglanti.Open();
            cmd1.ExecuteNonQuery();
            baglanti.Close();
            bunifuMaterialTextbox1.Text = "";
            bunifuMaterialTextbox2.Text = "";
            MessageBox.Show("İade alındı");

        }
    }
}