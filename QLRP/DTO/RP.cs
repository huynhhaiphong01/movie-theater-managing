using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLRP.DTO
{
    class RP
    {
       
        public string MaRapPhim { get; set; }
        public string TenRapPhim { get; set;}
        public string DiaChi { get; set; }
        public string TenNhanVienQuanLy { get; set;}
        [Browsable(false)]
        public string MaNhanVien { get; set; }
        public static bool CompareMRP(RP a, RP b)
        {
            if (String.Compare(a.MaRapPhim, b.MaRapPhim) < 0) return true;
            else return false;
        }
        public static bool CompareTRP(RP a ,RP b){
           if (String.Compare(a.TenRapPhim, b.TenRapPhim) < 0) return true;
           else return false;
        }
        public static bool CompareDiaChi(RP a, RP b)
        {
            if (String.Compare(a.DiaChi, b.DiaChi) < 0) return true;
            else return false;
        }
        public static bool CompareNameNV(RP a, RP b)
        {
            if (String.Compare(a.TenNhanVienQuanLy, b.TenNhanVienQuanLy) < 0) return true;
            else return false;
        }
        public static bool CompareMaNV(RP a, RP b)
        {
            if (String.Compare(a.MaNhanVien, b.MaNhanVien) < 0) return true;
            else return false;
        }
       }
    }

