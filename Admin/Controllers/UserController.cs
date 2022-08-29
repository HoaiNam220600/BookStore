using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Admin.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Admin.Controllers
{
    public class UserController : Controller
    {
        BookStoreContext db = new Models.BookStoreContext();
        public IActionResult Index()
        {
            //List<Sach> lst = db.Saches.ToList();
            //return View(lst);
            return View(db.Saches.Take(3).ToList());
        }
        [HttpGet]
        public async Task<IActionResult> GetBook(string search)
        {
                //TIM KIEM
            var Sach = from m in db.Saches select m;
            if (!String.IsNullOrEmpty(search))
            {
                Sach = Sach.Where(m => m.TenSach.Contains(search));
            }
            
            return View(await Sach.ToListAsync());
        }
        public IActionResult Detail(int id)
        {
            Sach dh = db.Saches.Where(x => x.MaSach == id).SingleOrDefault();
            return View(dh);
        }

        //public IActionResult Search(string SearchString"")
        //{
        //    if (SearchString !="")
        //    {
        //        Sach dh = db.Saches.Where(s => s.TenSach.ToUpper().Contains(SearchString.ToUpper()));
        //        return View(Sach.ToLÍ)
        //    }
        //}
        public IActionResult SelectCD1()
        {
            //Sach dh = db.Saches.Where(x => x.MaChuDe == 1).SingleOrDefault();
            //return View(dh);
            return View(db.Saches.Where(n => n.MaChuDe == 5).ToList());
        }
        public IActionResult SelectCD6()
        {
            return View(db.Saches.Where(n => n.MaChuDe == 6).ToList());
        }
        public IActionResult SelectCD3()
        {
            return View(db.Saches.Where(n => n.MaChuDe == 3).ToList());
        }
        public IActionResult SelectCD11()
        {
            return View(db.Saches.Where(n => n.MaChuDe == 1).ToList());
        }

        [HttpGet]
        public IActionResult DangKy()
        {

            return View();
        }
        [HttpPost]
        public IActionResult DangKy(FormCollection f)
        {
            string sTaiKhoan = f["TaiKhoan"].ToString();
            string sMatKhau = f["MatKhauKh"].ToString();
            KhachHang kh = db.KhachHangs.SingleOrDefault(n => n.TaiKhoan == sTaiKhoan && n.MatKhauKh == sMatKhau);
            if(kh!=null)
            {
                ViewBag.ThongBao = "Chúc mừng bạn đăng nhập thành công";
                //ISession["TaiKhoan"] = kh;
                return View();
            }
            ViewBag.ThongBao = "Tài khoản hoặc mật khẩu không chính xác vui lòng nhập lại";
            return View();
        }
        [HttpGet]
        public IActionResult Login()
        {

            return View();
        }
        [HttpPost]
        public IActionResult Login(KhachHang kh)
        {
            db.KhachHangs.Add(kh);
            db.SaveChanges();
            return RedirectToAction("DangKy");
        }
       

    }
}
