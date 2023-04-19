using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using kiemtrathuongxuyen1.Models;

namespace kiemtrathuongxuyen1.Controllers
{
    public class SchoolController : Controller
    {
        // GET: School
        public ActionResult Index()
        {
            return View();
        } 
        [HttpPost]
        public ActionResult KetQuaThem(SinhVien sv)
        {
            return View(sv);
        }
        public ActionResult DanhSachSinhVien()
        {
            List<SinhVien> sinhViens = new List<SinhVien>();
            sinhViens.Add(new SinhVien(1, "sinh", 9));
            sinhViens.Add(new SinhVien(2, "minh", 9));
            sinhViens.Add(new SinhVien(3, "linh", 9));
            sinhViens.Add(new SinhVien(4, "tu", 9));
            sinhViens.Add(new SinhVien(5, ";lanh", 9));
            return View(sinhViens);
        }

        public ActionResult DanhSachKhoaHoc()
        {
            SinhVien_KhoaHoc sv_kh = new SinhVien_KhoaHoc();
            sv_kh.KhoaHoc.makhoahoc = 1;
            sv_kh.KhoaHoc.tenkhoahoc = "toan cao cap";
            List<SinhVien> sinhViens = new List<SinhVien>();
            sinhViens.Add(new SinhVien(1, "sinh", 9));
            sinhViens.Add(new SinhVien(2, "minh", 9));
            sinhViens.Add(new SinhVien(3, "linh", 9));
            sinhViens.Add(new SinhVien(4, "tu", 9));
            sinhViens.Add(new SinhVien(5, ";lanh", 9));
            sv_kh.sinhViens = sinhViens;
            return View(sv_kh);
        }
        public ActionResult TwoDanhSachSinhVien()
        {
            List<SinhVien> sinhViens1 = new List<SinhVien>();
            sinhViens1.Add(new SinhVien(1, "sinh", 9));
            sinhViens1.Add(new SinhVien(2, "minh", 9));
            sinhViens1.Add(new SinhVien(3, "linh", 9));
            sinhViens1.Add(new SinhVien(4, "tu", 9));
            sinhViens1.Add(new SinhVien(5, ";lanh", 9));
            List<SinhVien> sinhViens2 = new List<SinhVien>();
            sinhViens2.Add(new SinhVien(1, "sinh", 9));
            sinhViens2.Add(new SinhVien(2, "minh", 9));
            sinhViens2.Add(new SinhVien(3, "linh", 9));
            sinhViens2.Add(new SinhVien(4, "tu", 9));
            sinhViens2.Add(new SinhVien(5, ";lanh", 9));
            ViewBag.sinhviens1 = sinhViens1;
            ViewBag.sinhviens2 = sinhViens2;
            return View();
        }
    }
}