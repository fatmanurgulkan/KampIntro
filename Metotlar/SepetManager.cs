using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar
{
    class SepetManager
    {
        //namıng conventıon 
        public void ekle(Product urun)
        {
            Console.WriteLine( " tebrikler ===ürün sepetinize başarılı bir şekilde  eklendi: "+ urun.Adı + "  " + "fiyatı= "+ urun.Fiyatı);

        }
        public void Ekle2(string urunAdı,string acıklama , double fıyatı, int stokadedi)
        {
            Console.WriteLine(" tebrikler " + urunAdı     +"eklendi");

        }
     


    }
}
