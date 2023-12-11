using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace s14_BaiTap
{
    internal class Cat : ISound
    {
        public Cat() { }

        public  void ShowSound()
        {
            Console.WriteLine(" Meo ...Meo..");
        }
    }
}
