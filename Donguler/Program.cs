using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {

            string kurs1 = "c#";
            string kurs2 = "JAva";
            string kurs3 = "phyton";

            Console.WriteLine(kurs1);
            Console.WriteLine(kurs2);
            Console.WriteLine(kurs3);                                       //bu şekilde 50 adet kurs olsa hepsini ayrı ayrı tanımlamak zorunda kalırız. Bu sebeple diziler (array) kullanılır.

            //array - dizi
            string[] kurslar = new string[] {"c#", "java", "phyton", "cw++" }; // [] şeklindeki parantez dizi (array) oluşumunu sağlar

            for (int i = 0; i < kurslar.Length; i++)                        //Lenghth (baş harfi büyük) komutu ile i<3 gibi yazılması önlenir ve kod dinamik bir hal alır.
                                                                            // 2xtab ile döngü bloğu oluşturulabilir.
            {                                                               //i++ i değişkenini birer birer arttır anlamına gelmektedir.
                                                                            //i=i+n n kadar arttırarak yaz.
                                                                            //i+=n n kadar arttırarak yaz.
                                                                            //c# sıfırdan saymaya başlar.
                Console.WriteLine(kurslar[i]);                              //array'den veri çekmek için köşeli parantez ile yazılması gerekir.
            }

            foreach (string kurs in kurslar)                                //dizi temelli yapıları tek tek dönmeye yarar. Sadece dizilerde kullanılır.
            {
                Console.WriteLine(kurs);
            }


            Console.WriteLine("sayfa sonu");
        }
    }
}
