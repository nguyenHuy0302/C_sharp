using QL_KhachSan.Modals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_KhachSan.Modals
{
    internal class Room
    {
        private string RoomName;
        private float Price;
        private string RoomNo;
        private int PeopleMax;
        private int Floor;

        public string RoomName1 { get => RoomName; set => RoomName = value; }
        public float Price1 { get => Price; set => Price = value; }
        public string RoomNo1 { get => RoomNo; set => RoomNo = value; }
        public int PeopleMax1 { get => PeopleMax; set => PeopleMax = value; }
        public int Floor1 { get => Floor; set => Floor = value; }

        public Room() { }

        public void Input()
        {
            Console.Write("Nhap Ma Phong :");
            RoomNo = Console.ReadLine();

            Console.Write("Nhap Ten Phong :");
            RoomName = Console.ReadLine();

            Console.Write("Nhap So Nguoi Toi Da :");
            PeopleMax = int.Parse(Console.ReadLine());

            Console.Write("Nhap Tang :");
            Floor = int.Parse(Console.ReadLine());

            Console.Write("Nhap Gia :");
            Price =float.Parse(Console.ReadLine());
        }

        public void Display()
        {
            Console.WriteLine(" Ma phong : {0} , Ten Phong : {1} , So nguoi toi da : {2} , Tang : {3} , Gia : {4}", RoomNo,RoomName,PeopleMax,Floor,Price);
        }

    }
}
