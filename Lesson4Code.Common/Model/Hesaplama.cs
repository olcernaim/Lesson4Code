using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson4Code.Common.Model
{
    public abstract class Hesaplama
    {
        protected readonly int[] _numbers;

        public Hesaplama(int[] numbers)
        {
            _numbers = numbers;
        }

        public abstract int Hesapla();
    }
}
