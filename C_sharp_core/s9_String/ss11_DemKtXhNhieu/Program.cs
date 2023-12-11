using System;
namespace Input
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Dem so ky tu xuat hien nhieu nhat :");
            Console.WriteLine("Nhap vao 1 chuoi :");
            string str = Console.ReadLine();
            // khai bao vaf su dung class dictionary luu ky tu va so luong
            Dictionary<char , int> dict = new Dictionary<char , int>();
            //su dung vong lap foreach de lap tung ky tu
            // neu chua co trong dic thi them vao va tang ky tu do len 1
            // neu ton tai rooi thi tang ky ti do len 1
            foreach (char ch in str.Replace(" ", string.Empty))
            {
                if (dict.ContainsKey(ch))
                {
                    dict[ch] = dict[ch] + 1;
                }
                else
                {
                    dict.Add(ch, 1);
                }
            }
            //hien thi ky tu va so lan xuat hien len man hinh 
             foreach(var item in dict.Keys)
            {
                Console.WriteLine(item + " " + dict[item]);
            }
        }

    }
}
