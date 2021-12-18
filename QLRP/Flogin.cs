using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLRP.DTO;
using QLRP.BLL;
namespace QLRP
{
    public partial class Flogin : Form
    {
        public Flogin()
        {
            InitializeComponent();
    
        }
        
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string TaiKhoan = textBox1.Text;
            string MatKhau = textBox2.Text;
            if (Login_BLL.Instance.CheckQuanLy_BLL(TaiKhoan, MatKhau))
            {
                QL f = new QL();
                f.ShowDialog();
            }
            else 
            if (Login_BLL.Instance.CheckNhanVien_BLL(TaiKhoan, MatKhau) == true)
            {
                Form1 f1 = new Form1();
                f1.ShowDialog();
            }
            else MessageBox.Show("Tài khoản hoặc mật khẩu không đúng!!!");
        }
    }
}
