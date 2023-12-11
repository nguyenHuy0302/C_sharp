
using System;
namespace HelloWorld
{
    internal class Program
    {
      static void Main(string[] args)
        {
            /* ep kieu gia tri */
            //string name = Console.ReadLine();
            //   int age = int.Parse(Console.ReadLine());
            //   double gpa = double.Parse(Console.ReadLine());
            //   Console.WriteLine("HName : " + name);
            //   Console.WriteLine("Age :" + age);
            //   Console.WriteLine("GPA :" + gpa);

            //int a = int.Parse(Console.ReadLine());
            //int b = int.Parse(Console.ReadLine());

            //Console.WriteLine("a + b = " + a + b);
            //Console.WriteLine("a - b = " + ( a - b));
            //Console.WriteLine("a * b = " + a * b);
            //Console.WriteLine("a / b = " + a / b);
            //Console.WriteLine("a % b = " + a % b); 

            string name = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("In 15 years , age of " + (name) + " will be " + (age+15));

        }    
    }
}
