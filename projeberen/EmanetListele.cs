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
    public partial class EmanetListele : DevExpress.XtraEditors.XtraForm
    {
        public EmanetListele()
        {
            InitializeComponent();
        }

        private void EmanetListele_Load(object sender, EventArgs e)
        {
            OleDbConnection baglanti = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "\\beren.mdb");
            OleDbCommand komut = new OleDbCommand("select * from emanet", baglanti);
            OleDbDataAdapter da = new OleDbDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuTileButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            getirmeyenler ft = new getirmeyenler();
            ft.ShowDialog();
        }
    }
}