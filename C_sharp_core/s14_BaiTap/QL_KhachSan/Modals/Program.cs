using System;
using System.Collections.Generic;
using QL_KhachSan.Modals;

/* 1.nhap thong tin khach san
 * 2.hien thi thong tin ks
 * 3.dat phong nghi
 * 4.tim phong con trong
 * 5.thong kedanh thu ks
 * 6.tim kiem thong tin khach hang
 * 7.thoat chuong trinh
 *  y/c:
 */

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Customer> customers = new List<Customer>();
            List<Hotel> hotels = new List<Hotel>();
            List<Book> books = new List<Book>();

            int choose;
            do
            {
                ShowMenu();
                choose = int.Parse(Console.ReadLine());

                switch(choose)
                {
                    case 1: InputHotel(hotels);
                        break;
                    case 2: DisplayHotel(hotels);
                        break; 
                    case 3: Booking(customers, hotels, books);// book de luu / hotel,customers -> luu va quan li
                        break;
                    case 4:
                        break; 
                    case 5:
                        break;
                    case 6:
                        break;
                    case 7:  Console.WriteLine(" Thoat chuong trinh ");
                        break;
                    default: Console.WriteLine("Nhap sai ! Vui long Nhap lai !");
                        break;
                }
            } while (choose != 7);
        }
        //Booking
        static void Booking(List<Customer> customers , List<Hotel> hotels , List<Book> books)
        {
            Book book = new Book();
            book.Input();

            books.Add(book);


        }

        // Input
        static void InputHotel(List<Hotel> hotels)
        {
            for(; ; )
            {
                Hotel hotel = new Hotel(); // khhoi tao 1 hotel rong
                hotel.Input();

                hotels.Add(hotel);

                Console.WriteLine("Ban co muon tiep tuc nhap khong ? YN");
                string option = Console.ReadLine();

                if (option.ToUpper().Equals("N"))
                {
                    break;
                }
            }
        }

        static void DisplayHotel(List<Hotel> hotels)
        {
           foreach (Hotel item in hotels)
            {
                item.Display();
            }
        }
        
        static void ShowMenu()
        {
            Console.WriteLine("1. Nhao thong tin Khach San ");
            Console.WriteLine("2. Hien thi thong tin khach san");
            Console.WriteLine("3. Dat phong");
            Console.WriteLine("4. Tim Phong trong");
            Console.WriteLine("5. Thong ke doanh thu Ks");
            Console.WriteLine("6. Tim kiem thong tin khach hang");
            Console.WriteLine("7. Thoat chuong trinh");
            Console.WriteLine(" Nhap lua chon cua ban ..");         
        }
    }
}
