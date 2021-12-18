using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLRP.DTO;
using System.Data;
namespace QLRP.DAL
{
    class QLNV_DAL
    {
        private static QLNV_DAL _instance;

        public static QLNV_DAL Instance
        {
            get
            {
                if (_instance == null) _instance = new QLNV_DAL();

                return _instance;
            }
            private set { _instance = value; }
        }
        private QLNV_DAL()
        {

        }
        public List<NV> GetAllRecordNV_DAL()
        {
            string query = "Select * from NHANVIEN";
            List<NV> nv = new List<NV>();
            foreach (DataRow i in DBHelper.Instance.GetRecord(query).Rows)
            {
                nv.Add(GetOneNV_DAL(i));
            }
            return nv;

        }
        public NV GetOneNV_DAL(DataRow i)
        {
            NV a = new NV();
            a.MaNhanVien = i["MaNhanVien"].ToString();
            a.TenNhanVien = i["TenNhanVien"].ToString();
            a.DiaChi = i["DiaChi"].ToString();
            a.NgaySinh = Convert.ToDateTime(i["NgaySinh"].ToString());
            a.ChucVu = i["ChucVu"].ToString();
            a.SDT = i["SoDienThoai"].ToString();
            a.SoCC = i["SoCC"].ToString();
            a.TK = i["TaiKhoan"].ToString();
            a.MK = i["MatKhau"].ToString();
            a.GioiTinh = Convert.ToBoolean(i["GioiTinh"].ToString());
            return a;
        }
        public bool AddNV_DAL(NV a)
        {
            try
            {
                string t = "EXEC USP_InsertNV N'";
                t += a.MaNhanVien + "', N'" + a.TenNhanVien + "', N'" + a.ChucVu + "', N'" + a.NgaySinh + "', N'" + a.DiaChi + "', N'" + a.SDT + "', N'"+ a.SoCC + "', N'" + a.TK + "', N'"+a.MK+"', N'"+a.GioiTinh+"'";
                DBHelper.Instance.ExcuteDB(t);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool EditNV_DAL(NV a)
        {
            try
            {
                string t = "UPDATE dbo.NHANVIEN set MaNhanVien = N'" + a.MaNhanVien + "', TenNhanVien = N'"
                + a.TenNhanVien + "', ChucVu = N'" + a.ChucVu + "', NgaySinh = '" + a.NgaySinh
                + "', DiaChi = N'" + a.DiaChi + "', SoDienThoai = '" + a.SDT + "', SoCC = '"
                + a.SoCC + "', TaiKhoan = N'" + a.TK + "', MatKhau = '" + a.MK + "', GioiTinh ="
                + Convert.ToInt32(a.GioiTinh) + " where MaNhanVien = N'" + a.MaNhanVien + "'";
                DBHelper.Instance.ExcuteDB(t);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool DelNV_DAL(string ma)
        {
            try
            {


                string query = " DELETE dbo.NHANVIEN where MaNhanVien = N'" + ma + "'";
                DBHelper.Instance.ExcuteDB(query);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
           
        }
    }
}
