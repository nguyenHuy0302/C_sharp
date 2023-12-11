using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace s14_BaiTap
{
    internal class Device : ISound
    {
        private string Name;
    
        public string Name1 { get => Name; set => Name = value; }

        private float Price;
        public float Price1 { get => Price; set => Price = value; }

        public Device()
        {

        }
        public void ShowSound()
        {
            Console.WriteLine(" Hien thi thong tin thiet bi");
        }
    }
}
