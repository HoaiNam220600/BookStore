using System;
using System.Collections.Generic;

#nullable disable

namespace Admin.Models
{
    public partial class KhachHang
    {
        public KhachHang()
        {
            DonHangs = new HashSet<DonHang>();
        }

        public int MaKh { get; set; }
        public string HoTenKh { get; set; }
        public string TaiKhoan { get; set; }
        public string MatKhauKh { get; set; }
        public string EmailKh { get; set; }
        public string DiaChiKh { get; set; }
        public string DienThoaiKh { get; set; }
        public string GioiTinhKh { get; set; }
        public DateTime? NgaySinhKh { get; set; }

        public virtual ICollection<DonHang> DonHangs { get; set; }
    }
}
