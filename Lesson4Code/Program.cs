using Lesson4Code.Common.Model;
using System;

namespace Lesson4Code
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new int[] { 5,7,9,8,1,6,4};

            Hesaplama sumObj = new ToplamHesaplama(numbers);
            //Eski Kod
            //ToplamHesaplama sumObj = new ToplamHesaplama(numbers);

            var sum = sumObj.Hesapla();

            Console.WriteLine("Tüm sayıların toplamı : " + sum);

            //TekSayiToplamHesaplama tekSayiToplamObj = new TekSayiToplamHesaplama(numbers);

            //var tekSayiToplam = tekSayiToplamObj.Hesapla();

            //Console.WriteLine("Tek sayıların toplamı : " + tekSayiToplam);

            Hesaplama tekSayiToplamObj = new TekSayiToplamHesaplama(numbers);
            //Eski Kod
            //ToplamHesaplama tekSayiToplamObj = new TekSayiToplamHesaplama(numbers);

            var tekSayiToplam = tekSayiToplamObj.Hesapla();

            Console.WriteLine("Tek sayıların toplamı : " + tekSayiToplam);

        }
    }
}
