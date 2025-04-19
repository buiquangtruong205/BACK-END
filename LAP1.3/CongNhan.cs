using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAP1._3
{
    internal class CongNhan : CanBo
    {
        public string Bac { get; set; } // Ví dụ: "bậc 3/7"

        public override void NhapThongTin()
        {
            base.NhapThongTin();
            Console.Write("Bậc: ");
            Bac = Console.ReadLine();
        }

        public override void HienThiThongTin()
        {
            base.HienThiThongTin();
            Console.WriteLine($"Bậc: {Bac}");
        }
    }
}
