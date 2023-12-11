using System;
namespace Input
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" READ AND PRINT ELEMENTS !");
            
            int[] arr = new int[10];
            Console.WriteLine("Nhap 10 phan tu trong mang !");
            for(int i =0; i<10; i++)
            {
                Console.Write(" Phan tu [{0}] : ", i);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.Write("In mang ra man hinh :");
            for(int i =0; i<10; i++)
            {
                Console.Write(" {0} ", arr[i]);
            }
            Console.WriteLine();
        }
    }
}
