using System;
namespace Input
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-PRINT UNIQUE ARRAY !-");

            int[] arr = new int[100];
            int dem = 0;

            Console.Write("Nhap so luong phan tu :");
            int n = Convert.ToInt32(Console.ReadLine());

            for(int i = 0; i<n; i++)
            {
                Console.Write("Phan tu [{0}] :", i );
                arr[i] = Convert.ToInt32(Console.ReadLine());   
            }
            Console.WriteLine(" Cac phan tu co 1 gia tri duy nhat trong mang :");
            for (int i = 0; i < n; i++)
            {
                dem = 0;

                // kiem tra cac phan tu giong nhau trc vi tri hien tai va tang bien dem them 1 neu tim thay
                for (int j =0; j < i -1; j++)
                {
                    //tang bien dem khi 2 phan tu giong nhau
                    if (arr[i] == arr[j])
                    {
                        dem++;
                    }
                }

                // kiem tra cac phan tu giong nhau sau vi tri hien tai va tang bien dem len 1 neu tim thay
                for(int k = i+1; k < n; k++)
                {
                    //
                    if (arr[i] == arr[k])
                    {
                        dem++;
                    }
                }

                if(dem== 0)
                {
                    Console.Write(" {0} ", arr[i]);
                }
            }

        }
    }
}
