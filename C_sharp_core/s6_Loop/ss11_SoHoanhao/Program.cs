using System; 
namespace Input
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" --------------SO HOAN HAO----------------");
            int sum = 0;
            Console.WriteLine(" Enter a number !");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" Cac uoc cua {0} la :", n);

            for(int i = 1; i<n; i++)
            {
                if (n % i == 0)
                {
                    sum += i;
                    Console.Write(" {0} ", i);
                }
            }
            Console.WriteLine("\n Tong cac uoc la {0}", sum);
            if(sum == n)
            {
                Console.WriteLine(" Day la so hoan hao ");
            }
            else
            {
                Console.WriteLine(" Day khong phai la so hoan hao ");
            }
        }
    }
}
