using System;
namespace Input
{
    class Program
    {
        // tao 1 ham tu dinh nghia co tham so 
        public static void welcome(string name)
        {
            Console.WriteLine("Welcom " + name +" !");
        }

        // tao 1 ham tu dinh nghia khac
        public static void HaveAnice()
        {
            Console.WriteLine(" Have a nice day !");
        }


        static void Main(string[] args)
        {
            Console.WriteLine("******************");
            string str;
            Console.Write(" Nhap vao 1 ten :");
            str = Console.ReadLine();
            // goi 2 ham tu dinh nghia
            welcome(str);
            HaveAnice();
        }
    }
}
