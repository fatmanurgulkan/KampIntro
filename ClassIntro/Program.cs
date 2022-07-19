using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string adı = " engın";

            Kurs kurs1 = new Kurs();
            kurs1.KursAdı = "java";
            kurs1.KursunEgıtmenı = "engin";
            kurs1.izlenmeoranı = 10;


            Kurs kurs2 = new Kurs();
            kurs2.KursAdı = "python";
            kurs2.KursunEgıtmenı = "ali";
            kurs2.izlenmeoranı = 20;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdı = "c";
            kurs3.KursunEgıtmenı = "veli";
            kurs3.izlenmeoranı = 30;


            Kurs[] kurslar = new Kurs[] {kurs1,kurs2,kurs3 };
            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursunEgıtmenı);
            }



            

            Console.ReadLine();

        }

        class Kurs
        {
            public string KursAdı { get; set; }
            public string KursunEgıtmenı { get; set; }
            public int izlenmeoranı { get; set; }

        }
    }
}
