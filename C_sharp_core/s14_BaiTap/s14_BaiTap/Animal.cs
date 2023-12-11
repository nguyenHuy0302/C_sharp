using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace s14_BaiTap
{
    public abstract class Animal : ISound
    {
        private string Name;

        public string Name1 { get => Name; set => Name = value; }
        public string FoodType1 { get => FoodType; set => FoodType = value; }

        private string FoodType;

        public Animal()
        {
           
        }
        public abstract void ShowSound();
        
    }
}
