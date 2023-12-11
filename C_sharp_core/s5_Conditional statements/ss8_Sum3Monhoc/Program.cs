using System;
namespace Input
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("** XET TUYEN THI DAI HOC !! **");
            float diemToan, diemLy, diemHoa;
            Console.WriteLine("Diem toan >=6.5");
            Console.WriteLine("Diem ly >=5.5");
            Console.WriteLine("Diem hoa >=5.0");
            Console.WriteLine("tong 3 mon  >=18.0 --- hoac toan+ly = 14.0");
            Console.WriteLine("--------------------");

            Console.WriteLine("Nhap diem toan :");
            diemToan = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Nhap diem Ly :");
            diemLy = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Nhap diem Hoa :");
            diemHoa = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Tong 3 mon la {0} diem ! ", diemToan + diemLy + diemHoa);
            Console.WriteLine(" Tong 2 mon Toan va Ly la {0} diem !", diemLy + diemToan);

            if (diemToan >= 6.5)
            {
                if(diemLy >= 5.5)
                {
                    if(diemHoa >= 5.0)
                    {
                        if ((diemHoa + diemToan + diemLy ) >= 18.0 || (diemLy + diemToan) >= 14.0)
                        {
                            Console.WriteLine("Chuc mung !! Ban da trung tuyen !!");
                        }
                        else
                        {
                            Console.WriteLine(" rat tiec .. Ban da chua trung tuyen hihi !");
                        }
                    }
                    else
                    {
                        Console.WriteLine(" rat tiec .. Ban da chua trung tuyen hihi !");
                    }
                }
                else
                {
                    Console.WriteLine(" rat tiec .. Ban da chua trung tuyen hihi !");
                }
            }
            else
            {
                Console.WriteLine(" rat tiec .. Ban da chua trung tuyen hihi !");
            }
        }
    }
}
