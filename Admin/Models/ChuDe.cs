using System;
using System.Collections.Generic;

#nullable disable

namespace Admin.Models
{
    public partial class ChuDe
    {
        public ChuDe()
        {
            Saches = new HashSet<Sach>();
        }

        public int MaChuDe { get; set; }
        public string TenChuDe { get; set; }

        public virtual ICollection<Sach> Saches { get; set; }
    }
}
