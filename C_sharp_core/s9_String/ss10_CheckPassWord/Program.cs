using System;
namespace Input
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Check pass word :");

            string username, password;
            int ctr = 0;

            do
            {
                Console.Write(" Nhap user name :");
                username = Console.ReadLine();
                Console.Write("Nhap password :");
                password = Console.ReadLine();

                if(username != "huy"  || password != "1234")
                {
                    ctr++;
                }
                else
                {
                    ctr = -1;
                }
            }
            while ((username != "huy" || password != "1234") && (ctr !=3));
            if (ctr == 3)
                Console.Write("\nBan da nhap sai username va password qua 3 lan. Xin hay thu lai!\n\n");
            else
                Console.Write("\nBan da nhap mat khau dung!\n\n");
        }
    }
}
