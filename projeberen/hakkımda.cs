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

namespace projeberen
{
    public partial class hakkımda : DevExpress.XtraEditors.XtraForm
    {
        public hakkımda()
        {
            InitializeComponent();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.Opacity > 0.0)
            {
                this.Opacity -= 0.025;
            }
            else
            {
                timer1.Stop();
                this.Close();

            }
        }

        private void hakkımda_Load(object sender, EventArgs e)
        {

        }
    }
}