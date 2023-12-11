using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace s14_BaiTap
{
    internal class Citizen : ISound
    {
        private string Name;

        public string Name1 { get => Name; set => Name = value; }
        public int Age1 { get => Age; set => Age = value; }

        private int Age;

        public Citizen()
        {

        }
        public void ShowSound()
        {
            Console.WriteLine(" Hien thi am thanh cua nguoi ");
        }
    }
}
