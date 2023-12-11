/* cai dat lop test
 * 1.nhap thong tin n cuon sach cua aptech 
 * 2. hien thi thong tin vua nhap
 * 3.sap xep giam dan theo nam xuat ban  va hien thi
 * 4. tim kiem  theo ten sach 
 * 5. tim kiem theo ten tac gia
 * 6 . thoat
 */
using QL_Sach;
using System;
using System.Collections.Generic;
namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Test
    {
        static void Main(string[] args)
        {
            List<AptechBook> aptechBooks = new List<AptechBook>();
            int choose;
            do
            {
                ShowMenu();
                choose = Int32.Parse(Console.ReadLine());
                switch (choose)
                {
                    case 1:
                        Input(aptechBooks); // goi ham
                        break;
                    case 2:
                        Display(aptechBooks);
                        break; 
                    case 3:
                        Sort(aptechBooks);
                        break;
                    case 4:
                        SearchingByBookName(aptechBooks);
                        break;
                    case 5:
                        SearchingByBookAuthor(aptechBooks);
                        break;
                    case 6:
                        Console.WriteLine("Ket thuc chuong trinh !");
                        break;
                    default:
                        Console.WriteLine(" Nhap sai . Vui long nhap lai !");
                        break;
                }
            } while (choose != 6);
        }
        // yeu cau 1 ..goi ham
        static void Input(List<AptechBook> aptechBooks)
        {
            Console.Write(" nhap so sach can them : ");
            int n = Int32.Parse(Console.ReadLine());
            for(int i = 0; i<n; i++)
            {
                AptechBook book = new AptechBook(); // khoi tao gia tri boook
                book.Input();
                aptechBooks.Add(book);// luu du lieu vao mang aptechbook
            }
        }
        //yc2
        static void Display(List<AptechBook> aptechBooks)
        {
            for(int i =0; i<aptechBooks.Count; i++)
            {
                aptechBooks[i].Display();
            }
        }
        //yc3 sap xep   
        static void Sort(List<AptechBook> aptechBooks)
        {
            aptechBooks.Sort((AptechBook o1, AptechBook o2) =>
            {
                return string.Compare(o1.YearPublish1, o2.YearPublish1);
            });
            Display(aptechBooks);
        }
        //yc4
        static void SearchingByBookName(List<AptechBook> aptechBooks)
        {
            Console.Write(" Nhap ten sach can tim :");
            String searching = Console.ReadLine();
            for(int i = 0; i < aptechBooks.Count; i++)
            {
                if (aptechBooks[i].Name1.Equals(searching))
                    // kiem tra cos trung hay ko neeu co thi display
                {
                    aptechBooks[i].Display();
                }
            }
        }
        //yc5
        static void SearchingByBookAuthor(List<AptechBook> aptechBooks)
        {
            Console.Write("Nhap ten tac gia can tim :");
            String searching = Console.ReadLine();  
            for(int i = 0; i <aptechBooks.Count; i++)
            {
                if (aptechBooks[i].Author1.Equals(searching))
                {
                    aptechBooks[i].Display();
                }
            }
        }


        static void ShowMenu()
        {
            Console.WriteLine("1.Nhap thong tin n cuon sach Aptech");
            Console.WriteLine("2.Hien thi thong tin vua nhap");
            Console.WriteLine("3.Sap xep thong tin giam dan theo nam xuat ban va hien thi");
            Console.WriteLine("4.Tim kiem theo ten sach");
            Console.WriteLine("5.Tim kiem theo ten tac gia");
            Console.WriteLine("6.Thoat");
            Console.WriteLine(" Lua chon  cua ban :");
        }
    }
}