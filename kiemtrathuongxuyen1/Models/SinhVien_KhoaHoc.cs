using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace kiemtrathuongxuyen1.Models
{
    public class SinhVien_KhoaHoc
    {
        public KhoaHoc KhoaHoc { get; set; }
        public List<SinhVien> sinhViens { get; set; }
        public SinhVien_KhoaHoc()
        {
            KhoaHoc = new KhoaHoc();
            sinhViens = new List<SinhVien>();
        }
    }
}