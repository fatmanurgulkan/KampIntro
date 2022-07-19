using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string kategoriEtiketi = "kategori";
            int ogrenciSayısı = 32000;
            double faizoranı = 1.45;
            bool sistemegiris = true;
            double Dolardun = 7.55;
            double Dolarbugun = 7.45;

            if (Dolardun > Dolarbugun)
            {
                Console.WriteLine("azalış oku");
            }
            else if (Dolardun<Dolarbugun)
            {
                Console.WriteLine("artıs oku");


            }
            else
            {
                Console.WriteLine("degişmedi");
            }







            if (sistemegiris == false)
            {
                Console.WriteLine("ayarlar butonu");
            }
            else
            {
                Console.WriteLine("giriş yap butonu");
            }
        


            Console.WriteLine(kategoriEtiketi);





            Console.ReadLine();
      
        }
    }
}
