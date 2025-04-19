using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAP1._3
{
    internal class KiSu : CanBo
    {
        public string NganhDaoTao { get; set; }

        public override void NhapThongTin()
        {
            base.NhapThongTin();
            Console.Write("Ngành Đào Tạo: ");
            NganhDaoTao = Console.ReadLine();
        }

        public override void HienThiThongTin()
        {
            base.HienThiThongTin();
            Console.WriteLine($"Ngành Đào Tạo: {NganhDaoTao}");
        }
    }
}
