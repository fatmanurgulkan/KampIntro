using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev1product
{
    class Program
    {
        static void Main(string[] args)
        {
            Product urun1 = new Product();
            urun1.urunadı = "ayran";
            urun1.ucretı = 10;
            urun1.skt= 02082022;


            Product urun2 = new Product();
            urun2.urunadı = "yogurt";
            urun2.ucretı = 20;
            urun2.skt = 02082022;

            Product urun3 = new Product();
            urun3.urunadı = "yag";
            urun3.skt = 02082022;

            Product[] urunler = new Product[] {urun1,urun2,urun3 };

            foreach ( var urun in urunler)
            {
                Console.WriteLine(urun.urunadı);
            }
            Console.WriteLine("foreach bitti-------------------------");
            for (int i = 0; i < urunler.Length; i++)
            {
                Console.WriteLine(urunler[i].urunadı);
            }
            Console.WriteLine("for bitti------------------------");


            Console.ReadLine();
        }
        class Product
        {
            public string urunadı{ get; set; }
            public int ucretı{ get; set; }

            public int skt { get; set; }




        }
    }
}
