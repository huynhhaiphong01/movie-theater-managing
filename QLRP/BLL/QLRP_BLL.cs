using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLRP.DAL;
using QLRP.DTO;
namespace QLRP.BLL
{
    class QLRP_BLL
    {
        private static QLRP_BLL _instance;

        public static QLRP_BLL Instance
        {
            get
            {
                if (_instance == null) _instance = new QLRP_BLL();

                return _instance;
            }
            private set { _instance = value; }
        }
        private QLRP_BLL()
        {

        }

        public List<RP> GetAllRecordRP_BLL(){
            return QLRP_DAL.Instance.GetAllRecordRP_DAL();
        }
        public bool AddRP_BLL(RP a)
        {
            if (QLRP_DAL.Instance.AddRP_DAL(a)) return true;
            else return false;
        }
        public bool EditRP_BLL(RP a)
        {
            if (QLRP_DAL.Instance.EditRP_DAL(a)) return true;
            else return false;
        }
        public bool DelRP_BLL(string MaRP)
        {
            if (QLRP_DAL.Instance.DelRP_DAL(MaRP)) return true;
            else return false;
        }
        public delegate bool Compare(RP a, RP b);
        public List<RP> Sort_BLL(string t)
        {
            if (t == "MaRapPhim") return SortRP_BLL(RP.CompareMRP);
            else if (t == "TenRapPhim") return SortRP_BLL(RP.CompareTRP);
            else if (t == "DiaChi") return SortRP_BLL(RP.CompareDiaChi);
            else if (t == "TenNhanVienQuanLy") return SortRP_BLL(RP.CompareNameNV);
            else return SortRP_BLL(RP.CompareMaNV);
        }
        public List<RP> SortRP_BLL(Compare k)
        {

            List<RP> list = new List<RP>();
            list = QLRP_BLL.Instance.GetAllRecordRP_BLL();
            for (int i = 0; i < list.Count; i++)
            {
                for (int j = 0; j < list.Count; j++)
                {
                    if (k(list[i], list[j]))
                    {
                        RP b = new RP();
                        b = list[i];
                        list[i] = list[j];
                        list[j] = b;
                    }


                }
            }

            return list;
        }
    }
}
