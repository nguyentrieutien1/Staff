using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NhanVien
{
    internal class DanhSachNhanVien
    {
        Dictionary<string, NhanVien> list = new Dictionary<string, NhanVien>();
       public void nhap()
        {
            Console.Write("nhap so nhan vien :");
            int number = int.Parse(Console.ReadLine()); 
            Console.Write("Nhap vao loai nhan vien muon nhap :");
            string loaiNhanVien = Console.ReadLine();
            for (int i = 0; i < number; i++)
            {
                if(loaiNhanVien == "BC")
                {
                    NhanVienBienChe bc = new NhanVienBienChe();
                    bc.nhap();
                    list.Add(bc.Cmnd, bc);
                }
                else
                {
                    NhanVienHopDong hd = new NhanVienHopDong();
                    hd.nhap();
                    list.Add(hd.Cmnd, hd);
                }
            }
        }
      public  void xuat()
        {
            Console.Write("Nhap vao loai nhan vien muon xuat :");
            string loai = Console.ReadLine().Trim();
            if(loai == "HD")
            {
                int count = 0;
                foreach(var item  in list.Keys)
                {
                    NhanVienHopDong nv = (NhanVienHopDong)list[item];
                    Console.Write("Thong tin cua nhan vien thu co so CMND  {0} la \n", nv.Cmnd);
                    Console.Write("Ma NV {0} \n Gioi tinh {1} \n Ho ten {2} \n Cmnd {3} \n Muc luong {4} \n Phu cap {5} \n Thuc linh {6}", nv.MaNv, nv.GioiTinh, nv.HoTen, nv.Cmnd, nv.MucLuong, nv.phucap(), nv.thuclinh());
                }
            }
            else
            {
                int count = 0;
                foreach (var item in list.Keys)
                {
                    NhanVienBienChe nv = (NhanVienBienChe)list[item];
                    Console.Write("Thong tin cua nhan vien thu co so CMND  {0} la \n", nv.Cmnd);
                    Console.Write("Ma NV {0} \n Gioi tinh {1} \n Ho ten {2} \n Cmnd {3} \n Muc luong {4} \n Phu cap {5} \n Thuc linh {6}", nv.MaNv, nv.GioiTinh, nv.HoTen, nv.Cmnd, nv.HeSoLuong, nv.phucap(), nv.thuclinh());
                }
            }
        }

        public void tongQuyLuong()
        {
            Console.Write("Nhap vao loai nhan vien muon xuat :");
            string loai = Console.ReadLine().Trim();
            if(loai == "HD")
            {
                foreach (var item in list.Keys)
                {
                    NhanVienHopDong nv = (NhanVienHopDong)list[item];
                    Console.Write("Tong Quy Luong cua nhan vien co so CMND   {0} la : {1} \n", nv.Cmnd, nv.phucap() + nv.thuclinh());
                }
            }
            else
            {
                foreach (var item in list.Keys)
                {
                    NhanVienBienChe nv = (NhanVienBienChe)list[item];
                    Console.Write("Tong Quy Luong cua nhan vien co so CMND   {0} la : {1} \n", nv.Cmnd, nv.phucap() + nv.thuclinh());
                }
            }
          
        }
        void tim(string cmnd)
        {
            if(list.ContainsKey(cmnd))
            {
                Console.Write("Ho ten cua nguoi do la {0}", list[cmnd].HoTen);
            }
            else
            {
                Console.Write("not fount !");
            }
        }
        void xoa (string cmnd)
        {
            if(list.ContainsKey(cmnd))
            {
                list.Remove(cmnd);
                Console.Write("Da xoa nguoi co so cmnd {0}", cmnd);
            }
            else
            {
                Console.Write("not fount !")
            }
        }
    }
}
