using System;
namespace Input
{
    class Program
    {
        static void Main(string[] args)
        {   
            Console.WriteLine("----Menu (1->3)----");

            int chose, cd , cr , cc , ch , r ;
            double s = 0;

            Console.WriteLine("1.Calculate the area of a circle !");
            Console.WriteLine("2.Calculate the area of a rectangle ! ");
            Console.WriteLine("3.Calculate the area of a triangle !");
            Console.WriteLine("Nhap lua chon cua ban !");
            Console.WriteLine("Enter your selection ");

            chose = Convert.ToInt32(Console.ReadLine());

            switch (chose)
            {
                case 1:
                    Console.WriteLine(" Enter a radius ");
                    r = Convert.ToInt32(Console.ReadLine());
                    s = 3.14 * r * r;
                    break; 
                case 2:
                    Console.WriteLine(" Enter a length");
                    cd = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(" Enter a width");
                    cr = Convert.ToInt32(Console.ReadLine());
                    s = cd * cr;
                    break; 
                case 3:
                    Console.WriteLine(" enter a canh huyen !");
                    ch = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter a height");
                    cc = Convert.ToInt32(Console.ReadLine());
                    s = 0.5 * ch * cc;
                    break;         
            }
            Console.WriteLine("Dien tich la S={0}", s);
            Console.ReadKey();
        }
    }
}
