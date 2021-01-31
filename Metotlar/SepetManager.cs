using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager
    {
        //isimlendirme kuralı olarak "Ekle" baş harfi büyük olarak yazılır.
        public void Ekle(Product product)
        {

            Console.WriteLine("Sepete Eklendi"+product.Adi); // Araya + koyarak string toplama yapılır, iki string yan yana yazılır.

        }


        public void Ekle2(string urunAdi, string aciklama, double fiyat, int stok)

        {
            Console.WriteLine("Sepete eklendi"+urunAdi);
               // Bu şekildeki class kullanımı, kodun güncellenmesi ile ilgili sıkıtnı yaratmaktadır.

        }
    }
}
