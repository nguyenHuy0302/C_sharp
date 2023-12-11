using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_Sach
{
    internal class Book
    { // khai bao
        private string Name;
        private string Author;
        private string Producer;
        private string YearPublish;
        private float Price;
        // cai dat 2 constructor  , get set cho cac thuoc tinh 
        public string Name1 { get => Name; set => Name = value; }
        public string Author1 { get => Author; set => Author = value; }
        public string Producer1 { get => Producer; set => Producer = value; }
        public string YearPublish1 { get => YearPublish; set => YearPublish = value; }
        public float Price1 { get => Price; set => Price = value; }

        public Book()
        {

        }

        public Book(string name , string author , string producer , string yearPublish , float price )
        { // dung de gan gia tri nay vao thuoc tinh get set
            this .Name = name;
            this.Author = author;
            this.Producer = producer;
            this.YearPublish = yearPublish;
            this.Price = price;
        }
        // cai dat 2 phuong thuc  input() va display() de nhap va hien thi 
        public virtual void Input()
        {
            Console.Write(" Ten sach :");
            Name = Console.ReadLine();
            Console.Write(" Ten tac gia :");
            Author = Console.ReadLine();
            Console.Write(" Ten nha san xuat :");
            Producer = Console.ReadLine();
            Console.Write(" Nam xuat ban ");
            YearPublish = Console.ReadLine();
            Console.Write(" Gia ban:");
            Price = float.Parse(Console.ReadLine());
        }

        public virtual void Display()
        {
            Console.WriteLine( "Ten sach : {0} ," +
                               "Ten tac gia : {1} ," +
                               "Ten nha san xuat : {2} ," +
                               "Nam xuat ban : {3} ," +
                               "Gia ban : {4} ", Name, Author, Producer, YearPublish, Price 
                               );       
        }

        public virtual  string ToString()
        {
            return " Ten sach : " + Name + "; Ten tac gia : " + Author + " ; Nha san xuat : " + Producer + ";Nam san xuat : " + YearPublish + ";Gia ban : " + Price;
     
        }

        
    }
}
