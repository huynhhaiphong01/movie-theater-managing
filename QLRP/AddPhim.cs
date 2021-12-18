using QLRP.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using QLRP.BLL;
namespace QLRP
{
    public partial class AddPhim : Form
    {
        public AddPhim()
        {
            InitializeComponent();
            SetCBB();
        }

        private void butThemAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            if (open.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(open.FileName);
                this.Text = open.FileName;
            }
        }

        private PH GetPhimOnForm()
        {
            PH a = new PH();
            a.TenPhim = txtTen.Text;
            a.HinhAnh = ImmageToByteArray(pictureBox1.Image);
            a.DaoDien = txtDaoDien.Text;
            a.MaPhim = txtMa.Text;
            a.NamSX = txtNamSx.Text;
            a.QuocGia = txtQuocGia.Text;
            a.TheLoai = cbbTheLoai.SelectedItem.ToString();
            a.ThoiLuong = txtThoiLuong.Text;
            return a;
        }
        public byte[] ImmageToByteArray(Image img)
        {
            MemoryStream m = new MemoryStream();
            img.Save(m, System.Drawing.Imaging.ImageFormat.Png);
            return m.ToArray();
        }
        private void butOk_Click(object sender, EventArgs e)
        {
            if (QLP_BLL.Instance.AddPhim_BLL(GetPhimOnForm()))
            {
                MessageBox.Show("Thêm phim thành công!!!");
            }
            else MessageBox.Show("Gặp lỗi khi thêm phim !!!");
        }

        private void butExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void SetCBB()
        {
            foreach (TheLoai i in QLP_BLL.Instance.GetAllRecordTheLoai())
            {
               cbbTheLoai.Items.Add(new CBBItem()
                {
                    Text = i.Theloai,
                    Value = i.id
                });
            }
            cbbTheLoai.SelectedIndex = 0;
        }
        private void AddPhim_Load(object sender, EventArgs e)
        {

        }
    }
}
