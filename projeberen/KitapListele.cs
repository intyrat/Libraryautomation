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
    public partial class KitapListele : DevExpress.XtraEditors.XtraForm
    {
        public KitapListele()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "\\beren.mdb");
        OleDbCommand komut = new OleDbCommand();
        private void kayitgetir()
        {
            baglanti.Open();
            string kayit = "Select * from Kitap";
            OleDbCommand komut = new OleDbCommand(kayit, baglanti);
            OleDbDataAdapter da = new OleDbDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();
            dataGridView1.Columns["emanet"].Visible = false;
            dataGridView1.Columns["kitapno"].Visible = false;
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
            komut.CommandText = "select * from Kitap where Kitap_Adi like'" + bunifuMaterialTextbox1.Text + "%'";
            OleDbDataAdapter da = new OleDbDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();
            dataGridView1.Columns["emanet"].Visible = false;
            dataGridView1.Columns["kitapno"].Visible = false;
        }

        private void bunifuTileButton2_Click(object sender, EventArgs e)
        {
            DialogResult sonuc = MessageBox.Show("Kitabı silmek istiyormusunuz", "Çıkış", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (sonuc == DialogResult.Yes)
            {
                baglanti.Open();
                komut.Connection = baglanti;
                komut.Parameters.Clear();
                komut.CommandText = "delete  from Kitap where Barkod = @brkd";
                komut.Parameters.AddWithValue("@brkd", dataGridView1.CurrentRow.Cells[0].Value);
                komut.ExecuteNonQuery();
                baglanti.Close();
                kayitgetir();
            }
            else
            {

            }
        }

        private void bunifuTileButton1_Click(object sender, EventArgs e)
        {
            string kitapno = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            OleDbCommand cmd = new OleDbCommand("update Kitap set Barkod=@barkod,Kitap_Yazari=@kitapy,Kitap_Adi=@kitapa where kitapno=@kitapno", baglanti);
            cmd.Parameters.AddWithValue("@barkod", bunifuMaterialTextbox2.Text);
            cmd.Parameters.AddWithValue("@kitapy", bunifuMaterialTextbox3.Text);
            cmd.Parameters.AddWithValue("@kitapa", bunifuMaterialTextbox4.Text);
            cmd.Parameters.AddWithValue("@kitapno", kitapno);
            baglanti.Open();
            cmd.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Güncellendi");
            kayitgetir();
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand();
            komut.Connection = baglanti;
            komut.CommandText = "select * from Kitap";
            OleDbDataAdapter da = new OleDbDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();
            dataGridView1.Columns["emanet"].Visible = false;
            dataGridView1.Columns["kitapno"].Visible = false;
            bunifuMaterialTextbox2.Text = "";
            bunifuMaterialTextbox3.Text = "";
            bunifuMaterialTextbox3.Text = "";
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            bunifuMaterialTextbox2.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            bunifuMaterialTextbox3.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            bunifuMaterialTextbox4.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
        }

        private void KitapListele_Load(object sender, EventArgs e)
        {

        }
    }
}