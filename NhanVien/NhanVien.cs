namespace NhanVien
{
    class NhanVien
    {
        string hoTen, gioiTinh, cmnd, maNv;
        DateTime namSinh;

        public string HoTen { get => hoTen; set => hoTen = value; }
        public string GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        public string Cmnd { get => cmnd; set => cmnd = value; }
        public string MaNv { get => maNv; set => maNv = value; }
        public DateTime NamSinh { get => namSinh; set => namSinh = value; }

        public virtual void nhap()
        {
            Console.Write("nhap ho ten :");
            HoTen = Console.ReadLine();
            Console.Write("nhap gioi tinh :");
            gioiTinh = Console.ReadLine();
            Console.Write("nhap cmnd :");
            cmnd = Console.ReadLine();
            Console.Write("nhap ma nhan vien :");
            maNv = Console.ReadLine();
            Console.Write("nhap nam sinh :");
            namSinh = DateTime.Parse(Console.ReadLine());
        }
        public virtual void xuat()
        {
            Console.Write("ho ten la {0} \n gioi tinh la {1} \n cmnd la {2} \n ma nhan vien la {3} \n nam sinh la {4} ", hoTen, gioiTinh, cmnd, maNv, namSinh);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Nguyen Thanh Tung");
            DanhSachNhanVien ds = new DanhSachNhanVien();
            ds.nhap();
            ds.xuat();
        }
    }
}
