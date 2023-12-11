using System;
using System.Collections;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue MyQueue = new Queue();
            MyQueue.Enqueue("Huy dep trai");
            MyQueue.Enqueue("Huy ngu ngoc");
            MyQueue.Enqueue("Huy u u");
            MyQueue.Enqueue("HUYYYYY");

            // dem thu co bao nhieu phan tu
            Console.WriteLine(" So phan tu trong Queue la : {0}", MyQueue.Count);

            //Lưu ý ở đây ta chỉ muốn xem giá trị mà không muốn nó khỏi Queue thì ta sẽ dùng Peek.
            Console.WriteLine("Phan tu dau cua Queue la : {0}",MyQueue.Peek());

            // Thử kiểm tra lại số phần tử để chắc chắn rằng hàm Peek không xoá phần tử ra khỏi Queue
            Console.WriteLine("So phan tu trong Queue sau khi su dung ham peek la : {0}", MyQueue.Count);

            // Thực hiện xoá các phần tử ra khỏi Queue thông qua hàm Dequeue.
            Console.WriteLine(" Poping.......!");
            int length = MyQueue.Count;
            for(int i = 0; i < length;i++)
            {
                Console.Write("  |" +  MyQueue.Dequeue());
            }
            Console.WriteLine();
            // kiem tra so phan tu trong queue sau khi su dung ham dequeue
            Console.WriteLine(" So phan tu trong Queue sau khi sd ham Dequeue la : {0}", MyQueue.Count);
          
        }
    }
}
