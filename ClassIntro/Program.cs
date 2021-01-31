using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string ad = "ilhan";
            int yas = 27;

            Kurs kurs1 = new Kurs();
            kurs1.Kursadi="C#";
            kurs1.Egitmen = "İlhan";
            kurs1.Izlenme = 68;

            Kurs kurs2 = new Kurs();
            kurs2.Kursadi = "C++";
            kurs2.Egitmen = "M.İlhan";
            kurs2.Izlenme = 79;


            //Console.WriteLine(kurs1.Kursadi+" "+kurs1.Egitmen );    //KursAdı + Boşluk + Eğitmen

            Kurs[] kurslar = new Kurs[] { kurs1, kurs2 }; //Artık string ile tanımlama yapmadan doğrudan "kurs" değişkeni olarak tanımlayabiliyoruz.

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.Kursadi);
            }

            Console.WriteLine("Hello World!");
        }

        class Kurs
        {
            public string Kursadi { get; set; }                 //prop yazıp 2xtab yapınca çıkıyor.
            public string Egitmen { get; set; }
            public int Izlenme { get; set; }
        }
    }
}
