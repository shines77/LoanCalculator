using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoanCalculator
{
    abstract class ICalculator
    {
        private const double kPrecision = 0.01;

        // 每月天数, 默认值为 30 天.
        private int monthDays = 30;
        // 首月优惠天数, 默认值为 0 天.
        private int dismountDays = 0;

        public int MonthDays()
        {
            return monthDays;
        }

        public void SetMonthDays(int monthDays)
        {
            this.monthDays = monthDays;
        }

        public int DismountDays()
        {
            return dismountDays;
        }

        public void SetDismountDays(int dismountDays)
        {
            this.dismountDays = dismountDays;
        }

        public static double RoundToMinUint(double value)
        {
            return Math.Floor(value / kPrecision + 0.5) * kPrecision;
        }

        public static double RoundToMinUint(double value, double precision)
        {
            return Math.Floor(value / precision + 0.5) * precision;
        }

        public abstract double Calculate(ref String calcHistory);
    }
}
