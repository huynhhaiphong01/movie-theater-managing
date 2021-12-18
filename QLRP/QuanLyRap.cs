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
using QLRP.DAL;
using QLRP.DTO;
using System.Reflection;
namespace QLRP
{
    public partial class QuanLyRap : Form
    {
        public QuanLyRap()
        {
            InitializeComponent();
            SetCBBName();
            SetCBBSort();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.DataSource = QLRP_BLL.Instance.GetAllRecordRP_BLL();
        }


        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                txtMaRP.Text = dataGridView1.CurrentRow.Cells["MaRapPhim"].Value.ToString();
                txtTenRap.Text = dataGridView1.CurrentRow.Cells["TenRapPhim"].Value.ToString();
                txtDiaChi.Text = dataGridView1.CurrentRow.Cells["DiaChi"].Value.ToString();
                 string name = dataGridView1.CurrentRow.Cells["TenNhanVienQuanLy"].Value.ToString();
                string id = QLNV_BLL.Instance.GetMaNV(dataGridView1.CurrentRow.Cells["TenNhanVienQuanLy"].Value.ToString());
                cbbTenNhanVien.SelectedIndex = Convert.ToInt32(id) - 1;
                txtMaNV.Text = id;
            }
        }
        public void refreshData()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = QLRP_BLL.Instance.GetAllRecordRP_BLL();
        }
        public void SetCBBName()
        {
            foreach (NV i in QLNV_BLL.Instance.GetAllRecordNV_BLL())
            {
                cbbTenNhanVien.Items.Add(new CBBItem()
                {
                    Text = i.TenNhanVien,
                    Value = Convert.ToInt32(i.MaNhanVien)
                });
            }

        }
        public void SetCBBSort()
        {
            foreach (PropertyInfo i in typeof(RP).GetProperties())
            {
                    cbbSort.Items.Add(i.Name.ToString());
            }
            cbbSort.SelectedIndex = 0;
        }
        private void butAdd_Click(object sender, EventArgs e)
        {
            RP1 f1 = new RP1();
            f1.Show();
            f1.refresh = refreshData;
        }

        private void cbbTenNhanVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            string name = cbbTenNhanVien.SelectedItem.ToString();
            txtMaNV.Text = QLNV_BLL.Instance.GetMaNV(name);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private RP GetRPOnFormQL()
        {
            RP a = new RP();
            a.MaRapPhim = txtMaRP.Text;
            a.TenRapPhim = txtTenRap.Text;
            a.DiaChi = txtDiaChi.Text;
            a.MaNhanVien = txtMaNV.Text;
            a.TenNhanVienQuanLy = cbbTenNhanVien.SelectedItem.ToString();
            return a;
        }
        private void butEdit_Click(object sender, EventArgs e)
        {
            string ma = GetRPOnFormQL().MaRapPhim;
            if (QLRP_BLL.Instance.EditRP_BLL(GetRPOnFormQL())) MessageBox.Show("Edit thành công!!!");
            else MessageBox.Show("Gặp lỗi khi Edit!!!");
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = QLRP_BLL.Instance.GetAllRecordRP_BLL();

        }

        private void butDel_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count >= 1)
            {
                string MaRP = dataGridView1.CurrentRow.Cells["MaRapPhim"].Value.ToString();
                if (QLRP_BLL.Instance.DelRP_BLL(MaRP))
                {
                    MessageBox.Show("Đã xóa thành công!!!");
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = QLRP_BLL.Instance.GetAllRecordRP_BLL();
                }
                else MessageBox.Show("Gặp lỗi khi xóa!!!");
              
            }
        }

        private void butSort_Click(object sender, EventArgs e)
        {
            string t = cbbSort.SelectedItem.ToString();
            dataGridView1.DataSource = QLRP_BLL.Instance.Sort_BLL(t);
        }

       
       
        

       

       

        
    }
}
