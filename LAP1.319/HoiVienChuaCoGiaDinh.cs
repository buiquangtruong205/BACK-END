using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAP1._319
{
    internal class HoiVienChuaCoGiaDinh : HoiVien
    {
        public HoiVienChuaCoGiaDinh(string hoTen, string diaChi)
       : base(hoTen, diaChi) { }

        public override void InThongTin()
        {
            base.InThongTin();
        }
    }
}
