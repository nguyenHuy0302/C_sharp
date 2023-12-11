using System;
namespace Input
{

    class Cat
    {
        private int weight;
        public int Weight
        {
            get { return weight; }
            set { weight = value; }
        }
        private int height;
        public int Height
        {
            get { return height; }
            set { height = value; }
        }
       /* Khai bao 1 bien  static  ten Count de chua so luong  meo hien tai
        moi lan co 1 doi tuong  dc tao ra thi ta se tang count len
        */
       public static int Count = 0;
        public Cat()
        {
            Weight = 20;
            Height = 50;
            // vi constructor chi dc goi khi  co doi tuong  dc tao ra nen se tang count nen se tang count o day
            Count++;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" So luong meo ban dau: " + Cat.Count);
            Cat BlackCat = new Cat(); // Tạo ra con mèo đầu tiên

            Console.WriteLine(" So luong meo hien tai: " + Cat.Count);

            Cat WhiteCat = new Cat(); // Tạo ra con mèo thứ 2
            Console.WriteLine(" So luong meo hien tai: " + Cat.Count);
        }
    }
}
