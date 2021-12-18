using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLRP.DTO;
using System.Data;
namespace QLRP.DAL
{
    class Login_DAL
    {
         private static Login_DAL _instance;

        public static Login_DAL Instance
        {
            get
            {
                if (_instance == null) _instance = new Login_DAL();

                return _instance;
            }
            private set { _instance = value; }
        }
        private Login_DAL()
        {

        }
        public List<Login> GetAllTaiKhoan_DAL()
        {
            string query = "Select ChucVu,TaiKhoan,MatKhau from NHANVIEN";
            List<Login> a = new List<Login>();
            foreach (DataRow i in DBHelper.Instance.GetRecord(query).Rows)
            {
                a.Add(GetOneLogin_DAL(i));
            }
            return a;
        }
        public Login GetOneLogin_DAL(DataRow i)
        {
            Login b = new Login();
            b.ChucVu = i["ChucVu"].ToString();
            b.TK = i["TaiKhoan"].ToString();
            b.MK = i["MatKhau"].ToString();
            return b;
        }
    }
}
