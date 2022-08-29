using System;
using System.Collections.Generic;

#nullable disable

namespace Admin.Models
{
    public partial class NhaXuatBan
    {
        public NhaXuatBan()
        {
            Saches = new HashSet<Sach>();
        }

        public int MaNxb { get; set; }
        public string TenNxb { get; set; }
        public string Diachi { get; set; }
        public string DienThoai { get; set; }

        public virtual ICollection<Sach> Saches { get; set; }
    }
}
