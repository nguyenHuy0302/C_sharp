using System;
using System.Collections.Generic;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Dictionary<string, string> MyDic = new Dictionary<string, string>();
            MyDic.Add("Ok" , "Goat");
            MyDic.Add("M10", "Messi");
            MyDic.Add("CR7", "Ronaldo");
            // in dictionary
            Console.WriteLine("IN Ban Hien Tai :");
            foreach(KeyValuePair<string, string> item in MyDic)
            {
                Console.WriteLine(item + " ");
            }

            //xoa doi tuong key xuat hien dau tien
            //
            MyDic.Remove("Ok");
            Console.WriteLine(" Doi tuong key sau khi remove :");

            foreach (KeyValuePair<string, string> item in MyDic)
            {
                Console.WriteLine(item + " ");
            }
            // kiem tra su ton tai cua key trong Dictionary
            // vi du check su ton tai cua Key " M10"
            if (MyDic.ContainsKey("M10"))
            {
                Console.WriteLine("Key : M10 is present");
            }
            else
            {
                Console.WriteLine("Key : M10 is absent");
            }

            if (MyDic.ContainsValue("Mesi"))
            {
                Console.WriteLine("Value : Messi is present");
            }
            else
            {
                Console.WriteLine(" Value : Messi is absent");
            }
        }
    }
}