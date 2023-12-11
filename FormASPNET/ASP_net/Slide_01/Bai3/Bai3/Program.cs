using System;
using System.Text;

namespace Bai3
{
    class PTbac2
    {
          static void giaiPTbac2 (float a, float b , float c)
        {  if( a==0)
            {  if(b==0)
                {
                    Console.Write(" Phương trình vô nghiệm !");
                }    else
                {
                    Console.Write(" Phương trình có 1 nghiệm: x= {0} "+ (-c/b));
                }
                return;        
            }
          
            // tinh delta
            float delta = b * b - 4 * a * c;
            float x1;
            float x2;
            if( delta >0)
            {
                x1 = (float)((-b + Math.Sqrt(delta)) / (2 * a));
                x2 = (float)((-b - Math.Sqrt(delta)) / (2 * a));
                Console.Write("Phương trình có 2 nghiệm: x1 = {0} va x2 = {1}", x1, x2);
            }
            else if (delta == 0)
            {
                x1 = (-b / (2 * a));
                Console.Write("Phương trình có nghiệm kép : x1 = x2 ={0}", x1);
            }
            else
            {
                Console.Write("Phương trình vô nghiệm !");
            } 
                
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode; 
            float a, b, c;
            Console.Write("Nhập hệ số bậc  2, a = ");
            String valA = Console.ReadLine();
            a = Convert.ToInt32(valA);
            Console.Write("Nhập hệ số bậc 1, b = ");
            String valB = Console.ReadLine();
            b = Convert.ToInt32(valB);
            Console.Write("Nhập hệ số , c = ");
            String valC = Console.ReadLine();
            c = Convert.ToInt32(valC);
            giaiPTbac2(a, b, c);

        }
    }
}
