using System;
using System.Collections.Generic;

#nullable disable

namespace Admin.Models
{
    public partial class ThamGium
    {
        public int MaSach { get; set; }
        public int MaTacGia { get; set; }
        public string VaiTro { get; set; }
        public string ViTri { get; set; }

        public virtual Sach MaSachNavigation { get; set; }
        public virtual TacGium MaTacGiaNavigation { get; set; }
    }
}
