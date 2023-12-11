using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
// tao 1 lop aptechbook ke thua tu lop book
namespace QL_Sach
{
    internal class AptechBook : Book
    {
        private string Language;
        private int Semester;

        public string Language1 { get => Language; set => Language = value; }
        public int Semester1 { get => Semester; set => Semester = value; }

        public AptechBook() { }

        public AptechBook(string name, string author, string producer,
                         string yearPublish, float price,
                         string language , int semester) : base( name , author,producer,yearPublish,price)
        {
            this.Language = language;
            this.Semester = semester;
        }
        // overide cac phuong thuc display va input
        public override void Input()
        {
            base.Input();

            Console.Write(" Nhap ngon ngu :");
            Language = Console.ReadLine();
            Console.Write("Nhap hoc ki ;");
            Semester = int.Parse(Console.ReadLine());
            Console.WriteLine("----------------");
        }

        public override void Display()
        {
         base.Display();
            Console.WriteLine("Ngon ngu :" + Language);
            Console.WriteLine("Hoc Ky :" + Semester);

        }
        public override string ToString()
        {
            return base.ToString() + "; Ngon ngu : " + Language
                                   + "; Hoc Ky : " + Semester;
        }
    }
}
