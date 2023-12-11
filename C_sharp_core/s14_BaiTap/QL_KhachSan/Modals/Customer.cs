using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_KhachSan.Modals
{
    internal class Customer
    {
        private string CMTND;
        private string FullName;
        private string Age;
        private string Gender;
        private string Address;

        

        public Customer() { }

        public string CMTND1 { get => CMTND; set => CMTND = value; }
        public string FullName1 { get => FullName; set => FullName = value; }
        public string Age1 { get => Age; set => Age = value; }
        public string Gender1 { get => Gender; set => Gender = value; }
        public string Address1 { get => Address; set => Address = value; }

        public void Input()
        {
            Console.Write(" Nhap CMTND :");
            CMTND = Console.ReadLine();

            InputWithoutCMTND();
        }

        public void InputWithoutCMTND()
        {
            Console.Write(" Nhap CMTND :");
            CMTND = Console.ReadLine();

            Console.Write(" Nhap Ho va Ten :");
            FullName = Console.ReadLine();

            Console.Write(" Nhap Tuoi :");
            Age = Console.ReadLine();

            Console.Write(" Nhap Gioi Tinh :");
            Gender = Console.ReadLine();

            Console.Write(" Nhap Dia Chi :");
            Address = Console.ReadLine();
        }
        public void Display()
        {
            Console.WriteLine("CMTND : {0} ,Ten : {1} , Tuoi : {2} , Gioi Tinh : {3} , Dia Chi : {4} ", CMTND, FullName,Age,Gender,Address);
        }
    }
}
