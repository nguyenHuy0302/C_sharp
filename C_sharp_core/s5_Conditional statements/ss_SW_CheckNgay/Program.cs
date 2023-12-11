using System;
namespace Input
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Day");
            int ns;
            Console.Write("Nhap so tu 1->7 de hien thi thu : ");

            ns = Convert.ToInt32(Console.ReadLine());

            switch (ns)
            {
                case 1: Console.WriteLine(" Hom nay la thu hai");
                    break;
                case 2: Console.WriteLine(" Hom nay la thu ba");
                    break;
                case 3: Console.WriteLine(" Hom nay la thu tu");
                    break;
                case 4: Console.WriteLine("Hom nay la thu nam");
                    break;
                case 5: Console.WriteLine("Hom nay la thu sau");
                    break;
                case 6: Console.WriteLine("Hom nay la thu bay");
                    break;
                case 7: Console.WriteLine("Hom nay la chu nhat");
                    break;
                default: Console.WriteLine("Vui long nhap lai ! (1-->7)");
                    break;
            }

        }
    }
}
