using System;
namespace Input
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" -----------------------");

            string str;
            char[] arr;
            char term;
            Console.Write(" Nhap vao 1 chuoi :");
            str = Console.ReadLine();
            arr = str.ToCharArray(0,str.Length);

            for(int i = 0; i < str.Length; i++)
            {
                for(int j = 0; j< str.Length -1; j++)
                {
                    if (arr[j] > arr[j+1])
                    {
                        term = arr[j];
                        arr[j] = arr[j+1];
                        arr[j+1] = term;
                    }
                }
            }
            Console.Write("Sau khi sap xep , chuoi co dang :");
            foreach( char item in arr )
            {
                term = item;
                Console.Write("{0} ",term);
            }
        }
    }
}
