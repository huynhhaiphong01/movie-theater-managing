using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLRP.DAL;
using QLRP.DTO;
namespace QLRP.BLL
{
    class QLNV_BLL
    {
         private static QLNV_BLL _instance;

        public static QLNV_BLL Instance
        {
            get
            {
                if (_instance == null) _instance = new QLNV_BLL();

                return _instance;
            }
            private set { _instance = value; }
        }
        private QLNV_BLL()
        {

        }
        public List<NV> GetAllRecordNV_BLL()
        {
            return QLNV_DAL.Instance.GetAllRecordNV_DAL();
        }
        public string GetMaNV(string name)
        {
            string ma = "";
            foreach (NV i in QLNV_DAL.Instance.GetAllRecordNV_DAL())
            {
                if (i.TenNhanVien == name) ma = i.MaNhanVien.ToString();
            }
            return ma;
        }
        public bool AddNV_BLL(NV a)
        {
            if (QLNV_DAL.Instance.AddNV_DAL(a)) return true;
            else return false;
        }
        public bool EditNV_BLL(NV a)
        {
            if (QLNV_DAL.Instance.EditNV_DAL(a)) return true;
            else return false;
        }
        public bool DelNV_BLL(string ma)
        {
            if (QLNV_DAL.Instance.DelNV_DAL(ma)) return true;
            else return false;
        }
        public delegate bool Compare(NV a, NV b);
        public List<NV> SortNV_BLL(string t)
        {
            if (t == "MaNhanVien")
            {
              return  SortNV1_BLL(NV.CompareMNV);
            }
            else if (t == "TenNhanVien") return SortNV1_BLL(NV.CompareTen);
            else if (t == "ChucVu") return SortNV1_BLL(NV.CompareChucVu);
            else if (t == "NgaySinh") return SortNV1_BLL(NV.CompareNS);
            else return SortNV1_BLL(NV.CompareCC);
        }
        public List<NV> SortNV1_BLL(Compare k)
        {

            List<NV> list = new List<NV>();
            list = QLNV_BLL.Instance.GetAllRecordNV_BLL();
            for (int i = 0; i < list.Count; i++)
            {
                for (int j = 0; j < list.Count; j++)
                {
                    if (k(list[i], list[j]))
                    {
                        NV b = new NV();
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
