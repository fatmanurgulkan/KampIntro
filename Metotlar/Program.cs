using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Product urun1 = new Product();
            urun1.Adı = "elma";
            urun1.Fiyatı = 15;
            urun1.Acıklama = "amasya elması";
            urun1.Id = 100;

            Product urun2 = new Product();
            urun2.Adı = "karpuz";
            urun2.Fiyatı = 12;
            urun2.Acıklama = "dıyarbakır karpuzu";
            urun2.Id = 2000;

            Product urun3 = new Product();
            urun3.Adı = "muz";
            urun3.Fiyatı = 20;
            urun3.Acıklama = "yenı muz";
            urun3.Id = 3000;


            Product[] urunler = new Product[] { urun1,urun2,urun3};
            foreach (var urun in urunler)
            {
              
                Console.WriteLine(urun.Adı + " " + urun.Fiyatı + " " + urun.Acıklama + " "+ urun.Id );
                Console.WriteLine("------------------------------------");
            }

            Console.WriteLine(  "---metotlar----");


            SepetManager sepetManager = new SepetManager();
            sepetManager.ekle(urun1);
            sepetManager.ekle(urun2);
            sepetManager.ekle(urun3);
            sepetManager.Ekle2("armut", "yesil elma", 10,1);
            






            Console.ReadLine();
        }
    }
}

//dont repeat  yourself--------------------------
