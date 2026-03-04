using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanHang.Data
{
    public class HoaDon
    {
        public int ID { get; set; }
        public int NhanVienID { get; set; }      // Foreign key
        public int KhachHangID { get; set; }     // Foreign key
        public DateTime NgayLap { get; set; } = DateTime.Now;
        public string? GhiChuHoaDon { get; set; }

        // Navigation properties
        public virtual List<HoaDon_ChiTiet> HoaDon_ChiTiet { get; set; } = new();

        public virtual NhanVien NhanVien { get; set; } = null!;
        public virtual KhachHang KhachHang { get; set; } = null!;
        public class DanhSachHoaDon
        {
            public int ID { get; set; }
            public int NhanVienID { get; set; }
            public string HoVaTenNhanVien { get; set; } // Thêm
            public int KhachHangID { get; set; }
            public string HoVaTenKhachHang { get; set; } // Thêm
            public DateTime NgayLap { get; set; }
            public string? GhiChuHoaDon { get; set; }
            public string? XemChiTiet { get; set; } // Thêm
            public double? TongTienHoaDon { get; set; } // Thêm
        }
    }
}
