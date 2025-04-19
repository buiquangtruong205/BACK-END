using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAP1._3
{
    internal class NhanVien : CanBo
    {
        public string CongViec { get; set; }

        public override void NhapThongTin()
        {
            base.NhapThongTin();
            Console.Write("Cong Viec: ");
            CongViec = Console.ReadLine();
        }

        public override void HienThiThongTin()
        {
            base.HienThiThongTin();
            Console.WriteLine($"Cong Viec: {CongViec}");
        }

    }
}
