using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_KhachSan.Modals
{
    internal class Hotel
    {
        private string HotelCode;
        private string Name;
        private string Address;
        private string Type;
        private List<Room> RoomList;



        public Hotel()
        {
            RoomList = new List<Room>();
        }

        public string HotelCode1 { get => HotelCode; set => HotelCode = value; }
        public string Name1 { get => Name; set => Name = value; }
        public string Address1 { get => Address; set => Address = value; }
        public string Type1 { get => Type; set => Type = value; }
        internal List<Room> RoomList1 { get => RoomList; set => RoomList = value; }

        public void Input()
        {
            Console.Write(" Nhap Ma Khach San :");
            HotelCode = Console.ReadLine();

            Console.Write(" Nhap ten khach san :");
            Name = Console.ReadLine();

            Console.Write(" Nhap Dia chi khach san :");
            Address = Console.ReadLine();

            Console.Write(" Nhap Loai (VIP / Binh Dan) :");
            Type = Console.ReadLine();

            // theo cac for --> sau moi lan nhap thif se co cau hoi
            for (; ; )
            {
                Room room = new Room();
                room.Input();

                RoomList.Add(room);

                Console.WriteLine(" Co tiep tuc nhap hay khong ? Y/N");
                string option = Console.ReadLine();

                if (option.ToUpper().Equals("N"))
                {
                    break;
                }
            }
        }
       public void Display()
        {
            Console.WriteLine("Ma khach san : {0} , Ten khach san : {1} , Dia chi : {2} , Loai : {3}", HotelCode, Name, Address, Type);

            foreach (Room room in RoomList)
            {
                room.Display();
            }
        }


    }
}
