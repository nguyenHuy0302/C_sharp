using System;
namespace Input
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Thuat toan noi bot Bubble Sort");

            int[] a = { 1, 2, 3, -1, 8, 4, 6 };
            int term;
            Console.WriteLine(" Mang ban dau la : ");
            foreach (int aa in a)
                Console.Write(aa + " ");
            for (int p = 0; p <= a.Length - 2; p++)
            {
                for (int i = 0; i <= a.Length - 2; i++)
                {
                    if (a[i] > a[i + 1])
                    {
                        term = a[i + 1];
                        a[i + 1] = a[i];
                        a[i] = term;
                    }
                }
            }
            Console.WriteLine("\n" + "Mang da qua sap xep:");
            foreach (int aa in a)
                Console.Write(aa + " ");
            Console.Write("\n");

            Console.ReadKey();
        }
    }
}

