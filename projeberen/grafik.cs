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
    public partial class grafik : DevExpress.XtraEditors.XtraForm
    {
        public grafik()
        {
            InitializeComponent();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Odul odl = new Odul();
            odl.ShowDialog();
        }

        private void grafik_Load(object sender, EventArgs e)
        {
            OleDbConnection bağlantı = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "\\beren.mdb");
            bağlantı.Open();
            OleDbCommand cmd = new OleDbCommand("Select Top 2 Ad,Soyad,Numara,alkitsay from ogrencikayit order by alkitsay desc", bağlantı);
            OleDbDataReader oku = cmd.ExecuteReader();
            while (oku.Read())
            {
                chart1.Series["En Cok Okuyanlar"].Points.AddXY(oku[0].ToString() + " " + oku[1].ToString() + " " + oku[2].ToString(), oku[3]);

            }
            bağlantı.Close();
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}