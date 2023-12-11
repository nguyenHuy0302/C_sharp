using s1_ArrayList;
using System;
using System.Collections;
using System.Collections.Generic;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList MyArray = new ArrayList();
            ArrayList MyArray2 = new ArrayList(5);

            // khoi tao  1 arraylist co kich thuoc  bag voi  myarray2
            // sao chep toan bo phan tu  trong array2 vao array3
            
            ArrayList MyArray3 = new ArrayList(MyArray2);
            ArrayList MyArray4 = MyArray2;

            // tao 1 danh sach  kieu arraylist rong
            ArrayList arrPersons = new ArrayList();

            // them 3 doi tuong vao danh sach 
            arrPersons.Add(new Person("Nguyen Van A ", 18));
            arrPersons.Add(new Person("Nguyen Van B ", 25));
            arrPersons.Add(new Person("Nguyen Van C ", 20));

            // in danh sach ban dau 
            Console.WriteLine(" Danh sach Person ban dau :");
            foreach(Person item in arrPersons)
            {
                Console.WriteLine(item.ToString());
            }
            Console.ReadLine();

            arrPersons.Sort(new SortPersons());

            // In danh sách Person đã được sắp xếp ra màn hình.
            Console.WriteLine();
            Console.WriteLine("Danh sach Person da duoc sap xep theo tuoi tang dan: ");
            foreach (Person item in arrPersons)
            {
                Console.WriteLine(item.ToString());
            }
        }
        
    }

    public class SortPersons : IComparer
    {
        public int Compare(object x, object y)
        {
            // Ép kiểu 2 object truyền vào về Person.
            Person p1 = x as Person;
            Person p2 = y as Person;

            /*
             * Vì có thể 2 object truyền vào không phải Person khi đó ta không thể so sánh được.
             * Trường hợp này tốt nhất ta nên ném ra lỗi để lập trình viên sửa chữa.
             * Chi tiết về exception sẽ được trình bày ở những bài học sau.
             */
            if (p1 == null || p2 == null)
            {
                throw new InvalidOperationException();
            }
            else
            {
                /*
                 * Khi dữ liệu đã ok thì ta thực hiện so sánh và trả về các giá trị 1 0 -1 tương ứng
                 * lớn hơn, bằng, bé hơn.
                 */
                if (p1.Age1 > p2.Age1)
                {
                    return 1;
                }
                else if (p1.Age1 == p2.Age1)
                {
                    return 0;
                }
                else
                {
                    return -1;
                }
            }
        }
    }




}
