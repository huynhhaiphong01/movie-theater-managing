using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using QLRP.BLL;
using QLRP.DAL;
using QLRP.DTO;
namespace QLRP
{
    public partial class QLNV : Form
    {
        public QLNV()
        {
           // dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            InitializeComponent();
            SetCBBSort();
            dg1.DataSource = QLNV_BLL.Instance.GetAllRecordNV_BLL();
            rdNam.Checked = true;
        }

        private void dg1_SelectionChanged(object sender, EventArgs e)
        {
            if (dg1.SelectedRows.Count == 1)
            {
                txtMaNV.Text = dg1.CurrentRow.Cells["MaNhanVien"].Value.ToString();
                txtTen.Text = dg1.CurrentRow.Cells["TenNhanVien"].Value.ToString();
                txtChucVu.Text = dg1.CurrentRow.Cells["ChucVu"].Value.ToString();
                dateNgsinh.Value = Convert.ToDateTime(dg1.CurrentRow.Cells["NgaySinh"].Value.ToString());
                txtDiaChi.Text = dg1.CurrentRow.Cells["DiaChi"].Value.ToString();
                txtSdt.Text = dg1.CurrentRow.Cells["SDT"].Value.ToString();
                txtCMND.Text = dg1.CurrentRow.Cells["SoCC"].Value.ToString();
                if (Convert.ToBoolean(dg1.CurrentRow.Cells["GioiTinh"].Value.ToString()) == true) rdNam.Checked = true;
                else rdNu.Checked = true;
                txtTk.Text = dg1.CurrentRow.Cells["TK"].Value.ToString();
                txtMk.Text = dg1.CurrentRow.Cells["MK"].Value.ToString();
            }
        }
        public void refreshData()
        {
            dg1.DataSource = null;
            dg1.DataSource = QLNV_BLL.Instance.GetAllRecordNV_BLL();
        }
        private void butThem_Click(object sender, EventArgs e)
        {
            NV1 nv = new NV1();
            nv.ShowDialog();
            refreshData();
        }
        private NV GetRPOnFormNV()
        {
            NV a = new NV();
            a.ChucVu = txtChucVu.Text;
            a.DiaChi = txtDiaChi.Text;
            a.MaNhanVien = txtMaNV.Text;
            a.MK = txtMk.Text;
            a.NgaySinh = Convert.ToDateTime(dateNgsinh.Value.ToString());
            a.SDT = txtSdt.Text;
            a.SoCC = txtCMND.Text;
            a.TenNhanVien = txtTen.Text;
            a.TK = txtTk.Text;
            if (rdNam.Checked == true) a.GioiTinh = true;
            else a.GioiTinh = false;

            return a;
        }
        private void butSua_Click(object sender, EventArgs e)
        {
            if(GetRPOnFormNV().MaNhanVien == "" || GetRPOnFormNV().TenNhanVien == "" || GetRPOnFormNV().SoCC == "") MessageBox.Show("Thông tin chưa đầy đủ!!!");
            else if(QLNV_BLL.Instance.EditNV_BLL(GetRPOnFormNV())) MessageBox.Show("Edit thành công!!!");
            else MessageBox.Show("Gặp lỗi khi Edit!!!");
            refreshData();
        }

        private void butXoa_Click(object sender, EventArgs e)
        {
            if (dg1.SelectedRows.Count >= 1)
            {
                string MaNV = dg1.CurrentRow.Cells["MaNhanVien"].Value.ToString();
                if (QLNV_BLL.Instance.DelNV_BLL(MaNV))
                {
                    MessageBox.Show("Đã xóa thành công!!!");
                    dg1.DataSource = null;
                    dg1.DataSource = QLNV_BLL.Instance.GetAllRecordNV_BLL();
                }
                else MessageBox.Show("Gặp lỗi khi xóa!!!");

            }
        }

        private void butThoat_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        public void SetCBBSort()
        {
            cbbSort.Items.AddRange(new object[]{
                "MaNhanVien","TenNhanVien","ChucVu","NgaySinh","SoCC"
            });
            cbbSort.SelectedIndex = 0;
        }

        private void butSort_Click(object sender, EventArgs e)
        {
            string t = cbbSort.SelectedItem.ToString();
            dg1.DataSource = null;
            dg1.DataSource = QLNV_BLL.Instance.SortNV_BLL(t);
        }

      

      

      
    }
}
