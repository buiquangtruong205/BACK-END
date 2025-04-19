using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAP1._37
{
    internal class TheMuon : Sinhvien
    {
        public string SoPhieuMuon { get; set; }
        public DateTime NgayMuon { get; set; }
        public DateTime HanTra { get; set; }
        public string SoHieuSach { get; set; }

        public void NhapTheMuon()
        {
            base.NhapThongTin();
            Console.Write("Nhập số phiếu mượn: ");
            SoPhieuMuon = Console.ReadLine();
            Console.Write("Nhập ngày mượn (dd/MM/yyyy): ");
            NgayMuon = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);
            Console.Write("Nhập hạn trả (dd/MM/yyyy): ");
            HanTra = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);
            Console.Write("Nhập số hiệu sách: ");
            SoHieuSach = Console.ReadLine();
        }

        public void HienThiTheMuon()
        {
            base.HienThiThongTin();
            Console.WriteLine($"Số phiếu mượn: {SoPhieuMuon}, Ngày mượn: {NgayMuon:dd/MM/yyyy}, Hạn trả: {HanTra:dd/MM/yyyy}, Số hiệu sách: {SoHieuSach}");
        }
    }
}
