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
    public partial class Odul : DevExpress.XtraEditors.XtraForm
    {
        public Odul()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "\\beren.mdb");
        OleDbCommand komut = new OleDbCommand();
        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Odul_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            string kayit = "Select * from ogrencikayit order by alkitsay desc";
            OleDbCommand komut = new OleDbCommand(kayit, baglanti);
            OleDbDataAdapter da = new OleDbDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();
        }

        private void bunifuTileButton1_Click(object sender, EventArgs e)
        {

            this.Hide();
            grafik gr = new grafik();
            gr.ShowDialog();
        }
    }
}