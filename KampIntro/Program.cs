using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string kategorietiketi = "kategori";//çift tırnak olmak zorunda
            Console.WriteLine(kategorietiketi);
            int ogrencisayisi = 32000; // tamsayılar
            double faizoranı = 1.45; //ondalıklı sayılar
            bool sistemegirisyapmismi = false;
            double dolardun = 7.35;
            double dolarbugun = 7.45;


            if (dolarbugun<dolardun)
            {
                Console.WriteLine("azalış");
            }
            else if (dolardun<dolarbugun)
            {
                Console.WriteLine("artış"); // cw yazıp 2xtab yapılırsa Console.Writeline bloğu tamamlanır.
            }
            else
            {
                Console.WriteLine("sabit");
            }
            if(sistemegirisyapmismi==true) //normal parantez içi şart, süslü parantezin içi sonuç
            {//if yazınca aşağıya açılan listeden 2xtab yapılırsa bu görünümü sağlar

                Console.WriteLine("ayarlar butonu");

            }
            else
            {
                Console.WriteLine("giriş yap");
            }

            // do not repeat yourself
        }
    }
}
