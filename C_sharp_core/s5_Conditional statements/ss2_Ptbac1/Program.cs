using System;

namespace Input // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int A, B;
            string strA, strB;
            double Nghiem;

            Console.WriteLine("**************************************");
            Console.WriteLine("         phuong trinh bac 1           ");
            Console.WriteLine("**************************************");

            Console.WriteLine(" Nhap he so a :");
            strA = Console.ReadLine();
            Console.WriteLine("Nhap he so b :");
            strB = Console.ReadLine();

            if (int.TryParse(strA, out A) == false || int.TryParse(strB, out B) == false)
            {
                Console.WriteLine(" Du lieu nhap sai !");
            }
            else
            {
               Console.WriteLine("Phuong trinh vua nhap la : {0}x + {1} = 0 ", A , B);
                if (A == 0)
                {
                    Console.WriteLine(" Phuong trinh co vo so nghiem ");
                }
                else if (B == 0)
                {
                    Console.WriteLine("Phuong trinh co 1 nghiem x= 0");
                }
                else 
                {
                    Nghiem = (double)-B / A;
                    Console.WriteLine("Phuong trinh co nghiem x={0}", Nghiem);
                }
            }

        }
    }
}
