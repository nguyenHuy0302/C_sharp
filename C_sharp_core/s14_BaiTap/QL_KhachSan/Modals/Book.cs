using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QL_KhachSan.Modals;
using System.Collections.Generic;

namespace QL_KhachSan.Modals
{
    internal class Book
    {
        private string CMTND;
        private string HotelCode;
        private string RoomNo;
        private DateTime CheckIn;
        private DateTime CheckOut;

        public string CMTND1 { get => CMTND; set => CMTND = value; }
        public string HotelCode1 { get => HotelCode; set => HotelCode = value; }
        public string RoomNo1 { get => RoomNo; set => RoomNo = value; }
        public DateTime CheckIn1 { get => CheckIn; set => CheckIn = value; }
        public DateTime CheckOut1 { get => CheckOut; set => CheckOut = value; }

        public Book() { }

        public void Input(List<Customer> customers, List<Hotel> hotels)
        {
            // TH neu hotel rong -> ct se chayj vo han --> cach xu li
            if(hotels.Count == 0)
            {
                Console.WriteLine(" Khong co du lieu !");
                return;
            }
                 

            Console.WriteLine(" Nhap CMTND :");
            CMTND = Console.ReadLine();

            // Kiem tra cmnd co ton tai hay ko
            bool isFind = false;

            // Kiem tra tung phan tu trong mang
            foreach (Customer item in customers)
            {
                if (item.CMTND1.Equals(CMTND))
                {
                    isFind = true;
                    break;
                }
            }
            if(!isFind) // neu khong tim thay thi ta se nhap moi
            {
                Customer customer = new Customer(); // khai bao 1 customer
                customer.CMTND1 = CMTND1;
                customer.InputWithoutCMTND(); // nhap customer vao

                customers.Add(customer); // luu customer vao mang

            }

 // Ma khach san       
            Console.Write("Nhap ma khach san :");
            HotelCode = Console.ReadLine();

            for(; ; )
            {
                Hotel currentHotel = null;
                foreach (Hotel item in hotels)
                {
                    Console.WriteLine("Ma Ks : {0}, Ten KS : {1} ",item.HotelCode1,item.Name1 );
                }
                 HotelCode1 = Console.ReadLine();

                foreach(Hotel item in hotels)
                {
                    if (item.HotelCode1.Equals(HotelCode1))
                    {
                        currentHotel = item;
                        break;
                    }
                }
                if(currentHotel != null)
                {
                    break;
                }
                Console.WriteLine(" Nhap lai :");
            }

            // Nhap ma Phong
            Console.Write("Nhap ma phong :");
            RoomNo1 = Console.ReadLine();
            

            Console.Write(" Ngay CheckIn (dd/MM/yyyy) ");
            string dateTime = Console.ReadLine();
            CheckIn = ConvertStringToDateTime(dateTime);

            Console.Write("Ngay CheckOut (dd/MM/yyyy) ");
            dateTime = Console.ReadLine();
            CheckOut = ConvertStringToDateTime(dateTime);
        }

        public DateTime ConvertStringToDateTime(string value)
        {
            DateTime myDate = DateTime.ParseExact(value, "dd/MM/yyyy", null);
            return myDate;
        }

    }
}
