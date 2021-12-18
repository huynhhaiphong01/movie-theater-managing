using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLRP.DTO;
using System.Data;

namespace QLRP.DAL
{
    class QLRP_DAL
    {
        private static QLRP_DAL _instance;

        public static QLRP_DAL Instance
        {
            get
            {
                if (_instance == null) _instance = new QLRP_DAL();

                return _instance;
            }
            private set { _instance = value; }
        }
        private QLRP_DAL()
        {

        }
        public List<RP> GetAllRecordRP_DAL()
        {
            string query = "Select * from RAPPHIM";
            List<RP> rp = new List<RP>();
            foreach(DataRow i in DBHelper.Instance.GetRecord(query).Rows)
            {
                rp.Add(GetOneRP_DAL(i));
            }
            return rp;

        }
        public RP GetOneRP_DAL(DataRow i)
        {
            RP rp = new RP();
            rp.MaRapPhim = i["MaRapPhim"].ToString();
            rp.TenRapPhim = i["TenRapPhim"].ToString();
            rp.DiaChi = i["DiaChiCuaRapPhim"].ToString();
            rp.MaNhanVien = i["MaNV"].ToString();
            rp.TenNhanVienQuanLy = i["TenNhanVienQuanLy"].ToString();
            return rp;
        }
        public bool AddRP_DAL(RP a)
        {
            try
            {
                string t = "EXEC USP_Insert N'";
                t += a.MaRapPhim + "', N'" + a.TenRapPhim + "', N'" + a.DiaChi + "', N'" + a.TenNhanVienQuanLy + "', N'" + a.MaNhanVien + "'";
                DBHelper.Instance.ExcuteDB(t);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool EditRP_DAL(RP a)
        {

            string t = "UPDATE dbo.RAPPHIM set MaRapPhim = N'" + a.MaRapPhim +"', TenRapPhim = N'" + a.TenRapPhim +"', DiaChiCuaRapPhim = N'" + a.DiaChi +"', TenNhanVienQuanLy = N'"+ a.TenNhanVienQuanLy+"', MaNV = N'" + a.MaNhanVien+"' where MaRapPhim = N'" + a.MaRapPhim+"'";
            DBHelper.Instance.ExcuteDB(t);
            return true;


        }
        public bool DelRP_DAL(string MaRP)
        {
            string query = " DELETE dbo.RAPPHIM where MaRapPhim = N'" + MaRP +"'";
            DBHelper.Instance.ExcuteDB(query);
            return true;
        }

     
    }
}
