using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLRP.DTO
{
    class NV
    {
        public string MaNhanVien { get; set; }
        public string TenNhanVien { get; set;}
        public string ChucVu { get; set; }
        public DateTime NgaySinh { get; set; }
        public string DiaChi { get; set; }
        public string SDT { get; set; }
        public string SoCC { get; set; }
        public string TK { get; set; }
        public string MK { get; set; }
        public bool GioiTinh { get;set; }

        public static bool CompareMNV(NV a, NV b)
        {
            if (String.Compare(a.MaNhanVien, b.MaNhanVien) < 0) return true;
            else return false;
        }
        public static bool CompareTen(NV a, NV b)
        {
            if (String.Compare(a.TenNhanVien, b.TenNhanVien) < 0) return true;
            else return false;
        }
        public static bool CompareDiaChi(NV a, NV b)
        {
            if (String.Compare(a.DiaChi, b.DiaChi) < 0) return true;
            else return false;
        }
        public static bool CompareChucVu(NV a, NV b)
        {
            if (String.Compare(a.ChucVu, b.ChucVu) < 0) return true;
            else return false;
        }
        public static bool CompareCC(NV a, NV b)
        {
            if (String.Compare(a.SoCC, b.SoCC) < 0) return true;
            else return false;
        }
        public static bool CompareNS(NV a, NV b)
        {
            if (a.NgaySinh.Year > b.NgaySinh.Year)
            {
                return true;
            }
            else return false;
        }
    }
}
