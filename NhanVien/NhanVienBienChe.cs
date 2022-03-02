using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NhanVien
{
    internal class NhanVienBienChe : NhanVien,  Iluong
    {
        double heSoLuong, luongCanBan;

        public double HeSoLuong { get => heSoLuong; set => heSoLuong = value; }
        public double ThucLinh { get => luongCanBan; set => luongCanBan = value; }
        public override void nhap()
        {
            base.nhap();
            Console.Write("Nhap vao he so luong :");
            heSoLuong = double.Parse(Console.ReadLine());
            Console.Write("Nhap vao luong can ban :");
            luongCanBan = double.Parse(Console.ReadLine()); 
        }
        public override void xuat()
        {
            base.xuat();
            Console.Write("he so luong la {0} \n luong can ban la {1}", heSoLuong, luongCanBan);
        }
        public double phucap()
        {
            return this.luongCanBan / 10;
        }
        public double thuclinh()
        {
            return heSoLuong * luongCanBan + phucap();
        }
    }
}
