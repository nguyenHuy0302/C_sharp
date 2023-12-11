using System;
namespace Input
{

    class MauSac
    {
        public static string MauChuDao;
        static MauSac()
        {
            // Khai bao  doi tuong ngay va gio  va lay ngay gio hien tai cua he thong 
            DateTime now = DateTime.Now;

            // Lay ra  thu  cua ngay hien tai  va so sanh voi  7 ngay trong tuan 
            switch (now.DayOfWeek)
            {
                case DayOfWeek.Friday:
                    MauChuDao = "Black";
                    break;
                case DayOfWeek.Monday:
                    MauChuDao = "Blue";
                    break;
                case DayOfWeek.Saturday:
                    MauChuDao = "Green";
                    break;
                case DayOfWeek.Sunday:
                    MauChuDao = "Yellow";
                    break;
                case DayOfWeek.Thursday:
                    MauChuDao = "Pink";
                    break;
                case DayOfWeek.Tuesday:
                    MauChuDao = "Red";
                    break;
                case DayOfWeek.Wednesday:
                    MauChuDao = "Purple";
                    break;
            }
        }
        class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine(" Mau chu dao hom nay la " + MauSac.MauChuDao);
            }

        }
    }
}
