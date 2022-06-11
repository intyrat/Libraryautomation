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
    public partial class getirmeyenler : DevExpress.XtraEditors.XtraForm
    {
        public getirmeyenler()
        {
            InitializeComponent();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {

            this.Close();
            EmanetListele EmanetListele = new EmanetListele();
            EmanetListele.ShowDialog();
        }

        private void getirmeyenler_Load(object sender, EventArgs e)
        {
            DataTable dt1 = new DataTable();
            OleDbConnection baglanti = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "\\beren.mdb");
            OleDbCommand cmd = new OleDbCommand("select tarih from emanet", baglanti);
            OleDbDataReader dr;
            baglanti.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                dateTimePicker1.Text =  dr[0].ToString();
                DateTime dt = dateTimePicker1.Value.AddDays(+14);
                if (DateTime.Now >= dt)
                {
                    OleDbCommand cmd1 = new OleDbCommand("select * from emanet where tarih=@tarih", baglanti);
                    OleDbDataAdapter da = new OleDbDataAdapter(cmd1);

                    cmd1.Parameters.Add("@tarih", OleDbType.VarChar).Value = dr[0].ToString();
                    cmd1.ExecuteNonQuery();
                    da.Fill(dt1);
                }
            }
            dataGridView1.DataSource = dt1;
            baglanti.Close();
        }
    }
}