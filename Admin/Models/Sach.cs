using System;
using System.Collections.Generic;

#nullable disable

namespace Admin.Models
{
    public partial class Sach
    {
        public Sach()
        {
            ChiTietDonHangs = new HashSet<ChiTietDonHang>();
            ThamGia = new HashSet<ThamGium>();
        }

        public int MaSach { get; set; }
        public string TenSach { get; set; }
        public decimal? GiaBan { get; set; }
        public string MoTa { get; set; }
        public string AnhBia { get; set; }
        public DateTime? NgayCapNhat { get; set; }
        public int? SoLuongTon { get; set; }
        public int? MaNxb { get; set; }
        public int? MaChuDe { get; set; }

        public virtual ChuDe MaChuDeNavigation { get; set; }
        public virtual NhaXuatBan MaNxbNavigation { get; set; }
        public virtual ICollection<ChiTietDonHang> ChiTietDonHangs { get; set; }
        public virtual ICollection<ThamGium> ThamGia { get; set; }
    }
}
