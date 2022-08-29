using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Admin.Models;
namespace Admin.Controllers
{
    public class AdminController : Controller
    {
        BookStoreContext db = new Models.BookStoreContext();
        public IActionResult Index()
        {
            return View();
        }
        //public IActionResult Login()
        //{
        //    return View();
        //}
        public IActionResult GellAllBook()
        {
            List<Sach> lst = db.Saches.ToList();
            
            return View(lst);
        }
        public IActionResult GetAllNV()
        {
            List<QuanLy> lst = db.QuanLies.ToList();
            return View(lst);
        }
        public IActionResult GetAllKH()
        {
            List<KhachHang> lst = db.KhachHangs.ToList();
            return View(lst);
        }
        public IActionResult GellChuDe()
        {
            List<ChuDe> lst = db.ChuDes.ToList();
            return View(lst);
        }
        public IActionResult GetlAllNXB()
        {
            List<NhaXuatBan> lst = db.NhaXuatBans.ToList();
            return View(lst);
        }
        public IActionResult GetAllTacGia()
        {
            List<TacGium> lst = db.TacGia.ToList();
            return View(lst);
        }
        public IActionResult DonHang()
        {
            List<DonHang> lst = db.DonHangs.ToList();
            return View(lst);
        }
        [HttpGet]
        public IActionResult DetailDonHang(int id)
        {
            ChiTietDonHang dh = db.ChiTietDonHangs.Where(x => x.MaDonHang == id).SingleOrDefault();
            return View(dh);
        }
        //[HttpPost]
        //public IActionResult DetailDonHang(ChiTietDonHang dh)
        //{
        //    ChiTietDonHang ca = db.ChiTietDonHangs.Where(x => x.MaDonHang == dh.MaDonHang).SingleOrDefault();
          
        //    db.SaveChanges();
        //    return RedirectToAction("DonHang");
        //}
        public IActionResult AddBook()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddBook(Sach sach)
        {
            //insert db
            db.Saches.Add(sach);
            db.SaveChanges();
            return RedirectToAction("GellAllBook");
        }
        public IActionResult AddChuDe()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddChuDe(ChuDe cd)
        {
            //insert db
            db.ChuDes.Add(cd);
            db.SaveChanges();
            return RedirectToAction("GellChuDe");
        }
        public IActionResult AddNXB()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddNXB(NhaXuatBan nx)
        {
            //insert db
            db.NhaXuatBans.Add(nx);
            db.SaveChanges();
            return RedirectToAction("GetlAllNXB");
        }
        public IActionResult AddTacGia()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddTacGia(TacGium tg)
        {
            //insert db
            db.TacGia.Add(tg);
            db.SaveChanges();
            return RedirectToAction("GetAllTacGia");
        }
        public IActionResult EditBook(int id)
        {
            Sach ss = db.Saches.Where(x => x.MaSach == id).SingleOrDefault();
            return View(ss);
        }

        [HttpPost]
        public IActionResult EditBook(Sach ss)
        {
            Sach sa = db.Saches.Where(x => x.MaSach == ss.MaSach).SingleOrDefault();
            if (sa != null)
            {
                sa.SoLuongTon = ss.SoLuongTon;
                sa.TenSach = ss.TenSach;
                sa.NgayCapNhat = ss.NgayCapNhat;
                sa.MaNxb = ss.MaNxb;
                sa.MaChuDe = ss.MaChuDe;
                sa.GiaBan = ss.GiaBan;
                sa.MoTa = ss.MoTa;
            }
            db.SaveChanges();
            return RedirectToAction("GellAllBook");
        }
        public IActionResult EditChuDe(int id)
        {
            ChuDe cd = db.ChuDes.Where(x => x.MaChuDe == id).SingleOrDefault();
            return View(cd);
        }
        [HttpPost]
        public IActionResult EditChuDe(ChuDe cd)
        {
            ChuDe ce = db.ChuDes.Where(x => x.MaChuDe == cd.MaChuDe).SingleOrDefault();
            if (ce != null)
            {
                ce.TenChuDe = cd.TenChuDe;
            }
            db.SaveChanges();
            return RedirectToAction("GellChuDe");
        }
        public IActionResult EditTacGia(int id)
        {
            TacGium tg = db.TacGia.Where(x => x.MaTacGia == id).SingleOrDefault();
            return View(tg);
        }
        [HttpPost]
        public IActionResult EditTacGia(TacGium tg)
        {
            TacGium ta = db.TacGia.Where(x => x.MaTacGia == tg.MaTacGia).SingleOrDefault();
            if (ta != null)
            {
                ta.TenTacGia = tg.TenTacGia;
                ta.DiaChi = tg.DiaChi;
                ta.TieuSu = tg.TieuSu;
                ta.DienThoai = tg.DienThoai;
            }
            db.SaveChanges();
            return RedirectToAction("GetAllTacGia");
        }
        public IActionResult EditNXB(int id)
        {
            NhaXuatBan nb = db.NhaXuatBans.Where(x => x.MaNxb == id).SingleOrDefault();
            return View(nb);
        }
        [HttpPost]
        public IActionResult EditNXB(NhaXuatBan nx)
        {
            NhaXuatBan nb = db.NhaXuatBans.Where(x => x.MaNxb == nx.MaNxb).SingleOrDefault();
            if (nb != null)
            {
                nb.TenNxb = nx.TenNxb;
                nb.Diachi = nx.Diachi;
                nb.DienThoai = nx.DienThoai;
            }
            db.SaveChanges();
            return RedirectToAction("GetlAllNXB");
        }
        public IActionResult DeleteBook(int id)
        {
            Sach sa = db.Saches.Where(x => x.MaSach == id).SingleOrDefault();
            db.Saches.Remove(sa);
            db.SaveChanges();

            return RedirectToAction("GellAllBook");
        }
        public IActionResult DeleteTacGia(int id)
        {
            TacGium ta = db.TacGia.Where(x => x.MaTacGia == id).SingleOrDefault();
            db.TacGia.Remove(ta);
            db.SaveChanges();
            return RedirectToAction("GetAllTacGia");
        }
        public IActionResult DeleteNXB(int id)
        {
            NhaXuatBan nx = db.NhaXuatBans.Where(x => x.MaNxb == id).SingleOrDefault();
            db.NhaXuatBans.Remove(nx);
            db.SaveChanges();
            return RedirectToAction("GetlAllNXB");
        }
        public IActionResult DeleteChuDe(int id)
        {
            ChuDe cd = db.ChuDes.Where(x => x.MaChuDe == id).SingleOrDefault();
            db.ChuDes.Remove(cd);
            db.SaveChanges();
            return RedirectToAction("GellChuDe");
        }
     
    }
}
