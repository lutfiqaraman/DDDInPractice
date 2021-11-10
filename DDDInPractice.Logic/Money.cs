using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDDInPractice.Logic
{
    public sealed class Money
    {
        public int OneCentCount { get; set; }
        public int TenCentCount { get; set; }
        public int QuarterCount { get; set; }
        public int OneDollarCount { get; set; }
        public int FiveDollarCount { get; set; }
        public int TenDollarCount { get; set; }
        public int TwentyDollarCount { get; set; }


        public Money(
            int oneCentCount, 
            int tenCentCount, 
            int quarterCount, 
            int oneDollarCount,
            int fiveDollarCount,
            int tenDollarCount,
            int twentyDollarCount)
        {
            OneCentCount      = oneCentCount;
            TenCentCount      = tenCentCount;
            QuarterCount      = quarterCount;
            OneDollarCount    = oneDollarCount;
            FiveDollarCount   = fiveDollarCount;
            TenDollarCount    = tenDollarCount;
            TwentyDollarCount = twentyDollarCount;
        }

        public static Money operator +(Money amount1, Money amount2)
        {
            Money sum = new Money(
                amount1.OneCentCount + amount2.OneCentCount,
                amount1.TenCentCount + amount2.TenCentCount,
                amount1.QuarterCount + amount2.QuarterCount,
                amount1.OneDollarCount + amount2.OneDollarCount,
                amount1.FiveDollarCount + amount2.FiveDollarCount,
                amount1.TenDollarCount + amount2.TenDollarCount,
                amount1.TwentyDollarCount + amount2.TwentyDollarCount);

            return sum;
        }
    }
}
