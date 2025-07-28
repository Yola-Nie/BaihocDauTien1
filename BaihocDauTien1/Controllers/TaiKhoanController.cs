using Microsoft.AspNetCore.Mvc;
using BaihocDauTien1.Models;
using BaihocDauTien1.Data;
using System.Linq;
using System;

namespace BaihocDauTien1.Controllers
{
    public class TaiKhoanController : Controller
    {
        public readonly ApplicationDbContext _context;

        public TaiKhoanController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult DangKy() => View();
        public IActionResult DangNhap() => View();

        [HttpPost]
        public IActionResult DangKy(TaiKhoan nd)
        {
            if (ModelState.IsValid)
            {
                _context.TaiKhoans.Add(nd);
                _context.SaveChanges();
                return RedirectToAction("DangNhap");
            }
            return View(nd);
        }
        [HttpPost]
        public IActionResult DangNhap(string tenDangNhap,string matKhau)
        {
            var user = _context.TaiKhoans
                .FirstOrDefault(x => x.TenDangNhap == tenDangNhap && x.MatKhau == matKhau);

            if (user != null)
            {
                Content("aloo");
                // Lưu session đơn giản
                //HttpContext.Session.SetString("username", user.TenDangNhap);
                return RedirectToAction("Index", "Home");
            }
            else
            {
                //return Content("Sai Toan khoan hoac mat khau");
                ViewBag.Loi = "Sai tài khoản hoặc mật khẩu";
                return View();
            }
        }

        //public IActionResult DangXuat()
        //{
        //    HttpContext.Session.Clear();
        //    return RedirectToAction("DangNhap");
        //}
        //public IActionResult Index()
        //{
        //    return View();
        //}
    }
}
