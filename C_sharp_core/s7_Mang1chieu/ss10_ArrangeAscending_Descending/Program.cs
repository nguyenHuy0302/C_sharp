using System;
namespace Input
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("! Arrange ascending and descending !");

            int[] arr = new int[100];
            int term;
            Console.Write(" Enter a Number elements : ");
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.Write(" Phan tu [{0}] :", i);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            // SX tang dan 
            Console.Write("Sau khi sap xep tang dan :");
            for(int i =0; i< n; i++)
            {
                for(int j = i+1; j< n; j++)
                {
                    if (arr[j] < arr[i])
                    {
                        term   = arr[i];
                        arr[i] = arr[j];
                        arr[j] = term;
                    }
                }
            }
            // SX giam dan
            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = i + 1; j < n; j++)
            //    {
            //        if (arr[j] > arr[i])
            //        {
            //            term = arr[i];
            //            arr[i] = arr[j];
            //            arr[j] = term;
            //        }
            //    }
            //}
            for (int i =0; i< n; i++)
            {
                Console.Write(" {0} ", arr[i]);
            }
        }
    }
}