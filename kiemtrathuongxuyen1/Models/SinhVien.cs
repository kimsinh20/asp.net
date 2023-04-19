using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace kiemtrathuongxuyen1.Models
{
    public class SinhVien
    {
        public int masv { get; set; }
        public String tensv { get; set; }
        public double diemtb { get; set; }

        public SinhVien(int masv, String tensv, double diemtb)
        {
            this.masv = masv;
            this.tensv = tensv;
            this.diemtb = diemtb;
        } 
        public SinhVien()
        {
            this.masv = 0;
            this.tensv = "";
            this.diemtb = 0;
        }
    }
}