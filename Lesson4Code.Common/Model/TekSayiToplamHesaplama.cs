using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Lesson4Code.Common.Model
{
    public class TekSayiToplamHesaplama : ToplamHesaplama
    {
        public TekSayiToplamHesaplama(int[] numbers) : base(numbers)
        {
        }
        public override int Hesapla()
        {
            return _numbers.Where(p=>p%2 == 1).Sum();
        }
        /// <summary>
        /// Eski Kod
        /// </summary>
        /// <param name="numbers"></param>
        //public TekSayiToplamHesaplama(int[] numbers):base(numbers)
        //{ }

        //public override int Hesapla()
        //{
        //    return _numbers.Where(p => p % 2 == 1).Sum();
        //}
    }
}
