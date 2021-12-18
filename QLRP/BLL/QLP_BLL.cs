using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLRP.DAL;
using QLRP.DTO;
namespace QLRP.BLL
{
    class QLP_BLL
    {
        private static QLP_BLL _instance;

        public static QLP_BLL Instance
        {
            get
            {
                if (_instance == null) _instance = new QLP_BLL();

                return _instance;
            }
            private set { _instance = value; }
        }
        private QLP_BLL()
        {

        }
        public DataTable GetAllRecordPhim_BLL()
        {
            
            return QLP_DAL.Instance.GetAllRecordPhim_DAL();
        }
        public List<TheLoai> GetAllRecordTheLoai()
        {
            return QLP_DAL.Instance.GetAllRecordTheLoai();
        }
        public bool AddPhim_BLL(PH a)
        {
            if (QLP_DAL.Instance.AddPhim_DAL1(a)) return true;
            else return false;
        }
        public bool EditPhim_BLL(PH a)
        {
            if (QLP_DAL.Instance.EditPhim_DAL1(a)) return true;
            else return false;
        }
        public int GetIdTL(string name)
        {
            int id = 0;
            foreach(TheLoai i in QLP_DAL.Instance.GetAllRecordTheLoai())
            {
                if (i.Theloai == name) id = i.id;
            }
            return id;
        }
        public bool DelPH_BLL(string ma)
        {
            if (QLP_DAL.Instance.DelPH_DAL(ma)) return true;
            else return false;
        }
    }
}
