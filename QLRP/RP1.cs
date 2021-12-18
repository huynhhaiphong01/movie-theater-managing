using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLRP.BLL;
using QLRP.DTO;
namespace QLRP
{
    public partial class RP1 : Form
    {
        public RP1()
        {
            InitializeComponent();
            SetCBBName();
        }
        public delegate void refreshData();
        public refreshData refresh;
        private RP GetRPOnForm()
        {
           RP a = new RP();
           a.MaRapPhim = txtMaRap.Text;
           a.TenRapPhim = txtTenRap.Text;
           a.DiaChi = txtDiaChi.Text;
           a.MaNhanVien = txtMa.Text;
           a.TenNhanVienQuanLy = cbbName1.SelectedItem.ToString();
           
            return a;
        }
        private void butOk_Click(object sender, EventArgs e)
        {
            if (QLRP_BLL.Instance.AddRP_BLL(GetRPOnForm())) MessageBox.Show("Thêm thành công!!!");
            else MessageBox.Show("Gặp lỗi khi thêm!!!");
        }

        public void SetCBBName()
        {
            foreach (NV i in QLNV_BLL.Instance.GetAllRecordNV_BLL())
            {
                cbbName1.Items.Add(new CBBItem()
                {
                    Text = i.TenNhanVien,
                    Value = Convert.ToInt32(i.MaNhanVien)
                });
            }
       

        }

        private void cbbName1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string name = cbbName1.SelectedItem.ToString();
            txtMa.Text = QLNV_BLL.Instance.GetMaNV(name);
        }

        private void butExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
    }
}
