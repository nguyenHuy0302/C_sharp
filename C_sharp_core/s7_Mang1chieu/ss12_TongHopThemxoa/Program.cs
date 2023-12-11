using System;
namespace Input
{
    class TongHop
    {
        static void Main()
        {
            int[] arr,n, x;
            NhapMang(out arr);
            Console.Write("Mang duoc in :");
            HienMang(arr, arr.Length-1);
            Console.Write("Mang sau khi them vao cuoi ");
            NumberLast(arr, arr.Length-1);

        }

        private static void HienMang(int[] arr, int size)
        {
            for (int i = 0; i <= size; i++)
            {
                Console.Write("{0}", arr[i]);
            }
            
        }

        static void NhapMang(out int[] arr)
        {
            Console.Write("Nhap so luong phan tu :");
             int n = Convert.ToInt32(Console.ReadLine());
            if (n> 0)
            {
                arr = new int[n];
                for(int i = 0; i < n; i++)
                {
                    Console.Write(" Phan tu [{0}] :", i);
                    arr[i] = Convert.ToInt32(Console.ReadLine());
                }
            }
            else
            {
                Console.Write(" Nhap so phan tu > 0");
                arr = new int[0];
            }
        }

        public void NumberLast (out int[] arr , out int n , int x)
        {
             
        }



    }
}
