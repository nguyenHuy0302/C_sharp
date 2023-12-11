using System;
using System.Collections.Generic;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // tao 1 list kieu string va them 2 phan tu vao list
           List<string> MyList = new List<string>();
            MyList.Add(" Dinh Huy ");
            MyList.Add("Ai Tram");

            // In cac gia tri trong list
            Console.WriteLine(" List Ban Dau :");
            Console.WriteLine(" So luong phan tu trong List : {0}", MyList.Count);

            foreach(string item in MyList)
            {
                Console.Write(item + " ");
            }

            // chen 1 phan tu  vao dau List 
           
            MyList.Insert(0, "AT");

            //In lai cac phan tu trong List de xem da chen hay chua
            Console.WriteLine(" List sau khi Insert :");

            Console.WriteLine(" So luong phan tu trong List sau khi chen : {0}",MyList.Count);
            foreach(string item in MyList)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            // kiem tra  1 phan tu co ton tai trong  List hay khong
            bool isExists = MyList.Contains("Ai Tram");
            if(!isExists)
            {
                Console.WriteLine("Khong tim thay !");
            }
            else
            {
                Console.WriteLine(" Chuc 2 ban hanh phuc !");
            }
            // kiem tra su ton tai cua Key trong Dictionary


        }
    }
}