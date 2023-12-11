using System;
namespace Input
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap chieu cao tuong ung (don vi cm) ");
            int chieu_cao;
            chieu_cao = Convert.ToInt32(Console.ReadLine()); 
            
            if (chieu_cao < 150.0)
            {
                Console.WriteLine(" nguoi lun! hihi ");
            }
            else if ((chieu_cao >= 150.0) && (chieu_cao <= 165.0)){
                Console.WriteLine(" chieu cao binh thuong");
            }
            else if ((chieu_cao >=165.0) &&  (chieu_cao <= 195.0))
            {
                Console.WriteLine(" nguoi cao");
            }
            else { Console.WriteLine(" chieu cao bat on"); }

        }
    }
}
