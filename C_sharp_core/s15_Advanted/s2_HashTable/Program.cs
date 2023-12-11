using System;
using System.Collections;
namespace HashTable
{
    class Program
    {
        static void Main(string[] args)
        {
            // khoi tao hashtable trong
            Hashtable MyHash = new Hashtable(); // khoi tao 1 hashtable rong
            Hashtable MyHash2 = new Hashtable(5);// khoi tao  1 hashtable va chi dinhj capacity ban dau la 5

            MyHash2.Add(" K ", "Kteam");
            MyHash2.Add("FE", "Free Education");

            /*
             * Khoi tao  1 hashtable co kic thuoc bang vs MyHash2
             * sao chep toan bo phan tu  trong myhash2 vao myhash3
             */
            Hashtable MyHash3 = new Hashtable(MyHash2);

            //tao 1 hashtable voi 3 phan tu 
            Hashtable hash = new Hashtable();
            hash.Add("K", "Kteam");
            hash.Add("H", "HowKteam");
            hash.Add("FE", "Free Education");


        }
    }
}
