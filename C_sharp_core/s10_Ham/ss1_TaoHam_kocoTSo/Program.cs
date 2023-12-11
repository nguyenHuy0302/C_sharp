using System;
namespace Input
{
    class Program
    {
        // tao ham tu dinh nghia welcome
        public static void welcome()
        {
            Console.WriteLine(" Welcome to Huy");
        }
        // tao ham tu dinh nghia HaveAnice
        public static void HaveAnice()
        {
            Console.WriteLine(" HaveAnice a day");
        }

        static void Main(string[] args)
        {
            Console.WriteLine(" Tao ham dinh nghia ko cos tham so");
            //goi 2 ham tu dinh nghia
            welcome();
            HaveAnice();
            Console.WriteLine();
        }
    }
}
