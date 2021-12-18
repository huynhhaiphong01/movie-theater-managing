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
using System.IO;
namespace QLRP
{
    public partial class QLP : Form
    {
        public QLP()
        {
            
            InitializeComponent();
            dv.DataSource = QLP_BLL.Instance.GetAllRecordPhim_BLL();
            SetCB();
        }

        private void butThem_Click(object sender, EventArgs e)
        {
            AddPhim f = new AddPhim();
            f.ShowDialog();
            dv.DataSource = QLP_BLL.Instance.GetAllRecordPhim_BLL();

        }

        Image ByteArrayToImage(byte[] b)
        {
            MemoryStream m = new MemoryStream(b);
            return Image.FromStream(m);
        }
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {

            if (dv.SelectedRows.Count == 1)
            {
                txtTenPhim.Text = dv.CurrentRow.Cells["TenPhim"].Value.ToString();
           
                    byte[] b = (byte[])(dv.CurrentRow.Cells["HinhAnh"].Value);
                    pictureBox1.Image = ByteArrayToImage(b);
                
                txtDaoDien.Text = dv.CurrentRow.Cells["DaoDien"].Value.ToString();
                txtMaPhim.Text = dv.CurrentRow.Cells["MaPhim"].Value.ToString();
                txtThoiGian.Text = dv.CurrentRow.Cells["ThoiLuong"].Value.ToString();
                txtNamSX.Text = dv.CurrentRow.Cells["NamSX"].Value.ToString();
                comboBox1.SelectedIndex = QLP_BLL.Instance.GetIdTL(dv.CurrentRow.Cells["TheLoai"].Value.ToString()) - 1;
                txtQuocgia.Text = dv.CurrentRow.Cells["QuocGia"].Value.ToString();
            }
        }

        public void SetCB()
        {
            foreach (TheLoai i in QLP_BLL.Instance.GetAllRecordTheLoai())
            {
                comboBox1.Items.Add(new CBBItem()
                {
                    Text = i.Theloai,
                    Value = i.id
                });
            }
            comboBox1.SelectedIndex = 0;
        }


        private void QLP_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public byte[] ImmageToByteArray1(Image img)
        {
            MemoryStream m = new MemoryStream();
            img.Save(m, System.Drawing.Imaging.ImageFormat.Png);
            return m.ToArray();
        }
        private PH GetPHOnForm()
        {
            PH a = new PH();
            a.DaoDien = txtDaoDien.Text;
            a.MaPhim = txtMaPhim.Text;
            a.NamSX = txtNamSX.Text;
            a.QuocGia = txtQuocgia.Text;
            a.TenPhim = txtTenPhim.Text;
            a.TheLoai = comboBox1.SelectedItem.ToString();
            a.ThoiLuong = txtThoiGian.Text;
            a.HinhAnh = ImmageToByteArray1(pictureBox1.Image);
            return a;
        }

        private void butEdit_Click(object sender, EventArgs e)
        {
            if (GetPHOnForm().MaPhim == "" || GetPHOnForm().TenPhim == "" || GetPHOnForm().HinhAnh == null) MessageBox.Show("Bạn chưa điền thông tin đầy đủ!!!");
            else if (QLP_BLL.Instance.EditPhim_BLL(GetPHOnForm()))
            {
                dv.DataSource = null;
                dv.DataSource = QLP_BLL.Instance.GetAllRecordPhim_BLL();
                MessageBox.Show("Edit thành công!!!");
               
            }
            else MessageBox.Show("Gặp lỗi khi Edit");
            
        }

        private void butDoiAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            if (open.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(open.FileName);
                this.Text = open.FileName;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dv.SelectedRows.Count >= 1)
            {
                string MaPH = dv.CurrentRow.Cells["MaPhim"].Value.ToString();
                if (QLP_BLL.Instance.DelPH_BLL(MaPH))
                {
                    MessageBox.Show("Đã xóa thành công!!!");
                    dv.DataSource = null;
                    dv.DataSource = QLP_BLL.Instance.GetAllRecordPhim_BLL();
                }
                else MessageBox.Show("Gặp lỗi khi xóa!!!");

            }
        }
       

      

        
    }
}
