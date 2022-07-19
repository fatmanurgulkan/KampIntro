using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "kodlamaio";
            string kurs2 = "java";
            string kurs3 = "python";


            string[] kurslar = new string[] {"yazılım","java","python","aaaaa","bbbb","cccc" };
                 
            for (int i =0;  i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }
            Console.WriteLine( "for bitti-------------------------------");

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }

            Console.ReadLine();
        
        }
    }
}
