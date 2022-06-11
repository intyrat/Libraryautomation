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
    public partial class OkuyucuListele : DevExpress.XtraEditors.XtraForm
    {
        public OkuyucuListele()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "\\beren.mdb");
        OleDbCommand komut = new OleDbCommand();

        private void kayitgetir()
        {
            baglanti.Open();
            string kayit = "Select * from ogrencikayit";
            OleDbCommand komut = new OleDbCommand(kayit, baglanti);
            OleDbDataAdapter da = new OleDbDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();
        }
        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
        {
            kayitgetir();
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand();
            komut.Connection = baglanti;
            komut.CommandText = "select * from ogrencikayit where Ad like'" + bunifuMaterialTextbox1.Text + "%'";
            OleDbDataAdapter da = new OleDbDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();
            dataGridView1.Columns[5].Visible = false;
        }

        private void bunifuTileButton1_Click(object sender, EventArgs e)
        {
            DialogResult sonuc = MessageBox.Show("Kişiyi silmek istiyormusunuz", "Çıkış", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (sonuc == DialogResult.Yes)
            {
                baglanti.Open();
                komut.Connection = baglanti;
                komut.Parameters.Clear();
                komut.CommandText = "delete from ogrencikayit where Numara = @number";
                komut.Parameters.AddWithValue("@number", dataGridView1.CurrentRow.Cells[2].Value);
                komut.ExecuteNonQuery();
                baglanti.Close();
                kayitgetir();
            }
            else
            {

            }
        }

        private void OkuyucuListele_Load(object sender, EventArgs e)
        {

        }
    }
}