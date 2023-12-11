
    using System;
    using System.Collections.Generic;
    using System.Text;

    namespace NguyenDinhHuy_08312_CS464_C
    {
        class NHANVIENBIENCHE : NHANVIEN, ILUONG
        {
            float heSoluong;
            public float Hesoluong
            {
                get { return heSoluong; }
                set { heSoluong = value; }
            }

            float luongCoban;
            public float LuongCoban
            {
                get { return luongCoban; }
                set { luongCoban = value; }
            }
            public override void nhap()
            {
                Console.WriteLine("---------Nhập thông tin nhân viên biên chế--------");
                base.nhap();
                Console.WriteLine("Nhap he so luong: "); this.Hesoluong = float.Parse(Console.ReadLine());
                Console.WriteLine("Nhap luong co ban: "); this.LuongCoban = float.Parse(Console.ReadLine());
            }
            public override void xuat()
            {
                Console.WriteLine("-----Xuất thông tin nhân viên biên chế------");
                base.xuat();
                Console.WriteLine("He so luong la: {0}", this.Hesoluong);
                Console.WriteLine("Luong co ban la: {0}", this.LuongCoban);
            }
            public override double TinhThamNien()
            {
                int yearnow = DateTime.Today.Year;
                int yearvaolam = Ngayvaolam.Year;
                return yearnow - yearvaolam - 1;
            }
            public double TinhPhuCap()
            {
                return LuongCoban / 10;
            }
            public double ThucLinh()
            {
                return Hesoluong * LuongCoban + TinhPhuCap();
            }
        }
    }
