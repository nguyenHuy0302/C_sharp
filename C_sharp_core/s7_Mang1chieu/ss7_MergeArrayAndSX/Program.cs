using System;
namespace Input
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--Gop 2 mang va sap xep tang dan");

            int[] arr1 = new int[100];
            int[] arr2 = new int[100]; 
            int[] arr3 = new int[100];
            int s3; int i;
            Console.Write("--Nhap so luong mang arr1 :");
            int s1 = Convert.ToInt32(Console.ReadLine());
            for ( i = 0; i < s1; i++)
            {
                Console.Write(" Phan tu [{0}] :", i);
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("--Nhap so luong mang arr2 :");
            int s2 = Convert.ToInt32(Console.ReadLine());
            for (int j = 0; j < s2; j++)
            {
                Console.Write(" Phan tu [{0}]:", j);
                arr2[j] = Convert.ToInt32(Console.ReadLine());
            }
            // tong kich co s1 va s2 = s3
            s3 = s1 + s2;
            //chen phan tu cua 2 mang arr1 va arr2 vao mang thu 3 (arr3)
            for( i = 0 ; i < s1; i++)
            {
                arr3[i] = arr1[i];
            }
            for(int j = 0; j < s2; j++)
            {
                arr3[i] = arr2[j];
                i++;              
            }
            //Sap xep tang dan 

            // in mang arr3
            for(i = 0 ; i < s3; i++)
            {
                Console.Write("{0}", arr3[i]);
            }

        }
    }
}

