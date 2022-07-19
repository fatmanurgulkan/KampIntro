using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Degervereferanstıpler
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayı1 = 10;
            int sayı2 = 30;
            sayı1 = sayı2;
            sayı2 = 65;
            Console.WriteLine(sayı1); //30

            int[] array1 = new int[] { 10, 20, 30 };
            int[] array2 = new int[] { 100, 200, 300 };
            array1 = array2;
            array2[0] = 999;
            Console.WriteLine(array1[0]); //999


            // int decimal float double boolean = deger tıp
            // array clas ınterface = referance tıp   

            // bellekte stack ve head var . degerler stackte tanımlanır.burda olay deger atamaktır.
            // referance tıpte headte tanımlanır(new) demek. adresi yanı 
            // degeri degisirse eski adres silinir yeniye esitlenir.
           





            Console.ReadLine();
        }
    }
}
