using System;
using System.Collections;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*   // khoi tao 1 stack rong
              Stack MyStack = new Stack();

              // khoi tao 1 stack  vaf chi dinh suc chua la 5
              Stack MyStack2 = new Stack(5);

              // khoi tao 1 mang bat ky 
              ArrayList MyArrayList = new ArrayList();
              MyArrayList.Add(5);
              MyArrayList.Add(9);
              MyArrayList.Add(10);

              // khoi tao 1 stack va sao chep gia tri phan tu tu arraylist vao stack
              // Stack MyStack3 = new Stack(MyArrayList);
             */
            //SD STACK

            Stack MyStack4 = new Stack();
            MyStack4.Push("Education !");
            MyStack4.Push("Free");
            MyStack4.Push("HowKteam");

            Console.WriteLine("so phan tu hien tai  cua stack la : {0}", MyStack4.Count);

            // check gia tri dau muon no khoi stack thi dung peek
            Console.WriteLine("Phan tu dau cua stack la : {0}", MyStack4.Peek());

            // kiem tra lai phan tu đe sure rang peek ko xoa phan tu
            Console.WriteLine("Phan tu sau khi goi peek laf : {0}", MyStack4.Count);

            // xoa các phần tử ra khỏi stack (pop)
            Console.WriteLine(" Popingg.....");
            int length = MyStack4.Count;
            for (int i = 0; i < length; i++)
            {
                Console.Write(" " + MyStack4.Pop());
            }

            // Kiểm tra lại số phần tử của Stack sau khi Pop
            Console.WriteLine(" So phan tu cua Stack sau khi Pop la: {0}", MyStack4.Count);
            Console.ReadLine();
        }
    }
}
