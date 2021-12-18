using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLRP.DTO;
using QLRP.DAL;
namespace QLRP.BLL
{
    class Login_BLL
    {
        private static Login_BLL _instance;

        public static Login_BLL Instance
        {
            get
            {
                if (_instance == null) _instance = new Login_BLL();

                return _instance;
            }
            private set { _instance = value; }
        }
        private Login_BLL()
        {

        }
        public List<Login> GetAllTaiKhoan_BLL()
        {
            return Login_DAL.Instance.GetAllTaiKhoan_DAL();
        }
        public bool CheckQuanLy_BLL(string a, string b)
        {
            List<Login> list = new List<Login>();
            list = GetAllTaiKhoan_BLL();
            Login lg = new Login();

            int k = 0;
            foreach (Login i in list)
            {
                if (i.TK == a)
                {
                    if (i.ChucVu == "Quản lý rạp phim") k = 1;
                }
            }
            if ((k == 1))
            {
                return true;
            }
            else return false;
        }
        public bool CheckNhanVien_BLL(string a, string b)
        {

            List<Login> list = new List<Login>();
            list = GetAllTaiKhoan_BLL();
            Login lg = new Login();

            int k = 0;
            foreach (Login i in list)
            {
                if (i.TK == a)
                {
                    if (i.ChucVu == "Nhan Vien") k = 1; 
                }
            }
            if ((k==1))
            {
                return true;
            }
            else return false;

        }
    }
}