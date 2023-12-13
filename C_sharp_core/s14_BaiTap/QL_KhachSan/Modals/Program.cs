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
                    case 4: FindBookingAvaiable(hotels,books);
                        // nhap vao 1 nay book va ngay tra phong , in ra tat ca  cac phong co the dap ung yeu cau tren                     
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


        //Find Booking avaiable
        static void FindBookingAvaiable(List<Hotel> hotels , List<Book> books)
        {
            if(hotels.Count == 0)
            {
                Console.WriteLine("Khong co du lieu !");
                return;
            }
            Hotel currentHotel = null;
            for(; ; )
            {
                foreach(Hotel item in hotels)
                {
                    Console.WriteLine("Ma Ks : {0} , Ten KS : {1}", item.HotelCode1, item.Name1);

                }
                string HotelCode1 = Console.ReadLine();
                foreach(Hotel item in hotels)
                {
                    if (item.HotelCode1.Equals(HotelCode1))
                    {
                        currentHotel = item; 
                        break;
                    }               
                }
                if(currentHotel == null)
                {
                    break;
                }
                if(currentHotel != null)
                {
                    break;
                }
                Console.WriteLine(" Vui Long nhap lai !");

            }
            if(currentHotel.RoomList1.Count== 0)
            {
                Console.WriteLine("Khong co data");
                return;
            }
            Console.Write(" Ngay CheckIn (dd/MM/yyyy) ");
            string dateTime = Console.ReadLine();
            DateTime CheckIn1 = DateTime.ParseExact(dateTime, "dd/MM/yyyy", null);

            Console.Write("Ngay CheckOut (dd/MM/yyyy) ");
            dateTime = Console.ReadLine();
            DateTime CheckOut1 = DateTime.ParseExact(dateTime, "dd/MM/yyyy", null);

            foreach (Room room in currentHotel.RoomList1)
            {
                //Tim da danh sach booking cho phong room.
                List<Book> currentBooking = new List<Book>();
                foreach (Book book in books)
                {
                    if (book.HotelCode1.Equals(currentHotel.HotelCode1) && book.RoomNo1.Equals(room.RoomNo1))
                    {
                        currentBooking.Add(book);
                    }
                }
                //Kiem tra phong nay co kha nang book hay ko
                bool isFind = false;
                foreach (Book book in currentBooking)
                {
                    if (DateTime.Compare(book.CheckIn1, CheckOut1) > 0 || DateTime.Compare(book.CheckOut1, CheckIn1) < 0)
                    {
                        //OK
                    }
                    else
                    {
                        isFind = true;
                        break;
                    }
                }

                if (!isFind)
                {
                    Console.WriteLine("Phòng số: {0}, Tên phòng: {1}", room.RoomNo1, room.RoomName1);
                }
            }
        }


        //Booking
        static void Booking(List<Customer> customers , List<Hotel> hotels , List<Book> books)
        {
            Book book = new Book();
            book.Input(customers , hotels);

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
