using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLRP
{
    public partial class QL : Form
    {
        public QL()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            QuanLyRap f = new QuanLyRap();
            f.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            QLNV f1 = new QLNV();
            f1.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            QLP f2 = new QLP();
            f2.ShowDialog();
        }

        private void QL_Load(object sender, EventArgs e)
        {

        }
    }
}
