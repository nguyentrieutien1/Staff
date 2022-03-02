using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NhanVien
{
    internal class NhanVienHopDong: NhanVien, Iluong
    {
        double mucLuong;

        public double MucLuong { get => mucLuong; set => mucLuong = value; }
        public override void nhap()
        {
            base.nhap();
            Console.Write("Nhap vao muc luong :");
            mucLuong = double.Parse(Console.ReadLine());
        }
        public override void xuat()
        {
            base.xuat();
            Console.Write("Muc luong la {0}", mucLuong);
        }
        public double phucap()
        {
            return mucLuong / 10;
        }
        public double thuclinh()
        {
            return  mucLuong + phucap();
        }
    }
}
