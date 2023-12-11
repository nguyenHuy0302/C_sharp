using System;
using System.Collections.Generic;
namespace s14_BaiTap
{
    class Program
    {
        static void Main(string[] args)
        {
          List<ISound> sounds = new List<ISound>();

            sounds.Add(new Device());
            sounds.Add(new Device());

            sounds.Add(new Citizen());
            sounds.Add(new Citizen());

            sounds.Add(new Dog());
            sounds.Add(new Dog());

            sounds.Add(new Cat());
            sounds.Add(new Cat());

            foreach(ISound s in sounds)
            {
                s.ShowSound();
            }


        }
    }
}
