using System.Linq;

namespace Lesson4Code.Common.Model
{
    public class ToplamHesaplama :Hesaplama
    {
        public ToplamHesaplama(int[] numbers) : base(numbers)
        {
        }

        public override int Hesapla()
        {
            return _numbers.Sum();
        }
    }

    /// Eski Kod

    //public class ToplamHesaplama
    //{
    //    protected readonly int[] _numbers;

    //    public ToplamHesaplama(int[] numbers)
    //    {
    //        _numbers = numbers;
    //    }

    //    public virtual int Hesapla()
    //    {
    //        return _numbers.Sum();
    //    }
    //}
}
