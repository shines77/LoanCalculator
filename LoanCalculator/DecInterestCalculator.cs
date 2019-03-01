using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoanCalculator
{
    class DecInterestCalculator : ICalculator
    {
        private double total = 0;
        private double rate = 0.0;
        private int periods = 0;
        private int rateMode = 0;

        public DecInterestCalculator(double total, double rate, int periods, int rateMode)
        {
            this.total = RoundToMinUint(total);
            this.rate = rate;
            this.periods = periods;
            this.rateMode = rateMode;
        }

        public override double Calculate(ref string calcHistory)
        {
            // 每月天数, 默认值为 30 天.
            int monthDays = MonthDays();
            // 首月优惠天数, 默认值为 0 天.
            int discountDays = DismountDays();
            // 还款总额, 返回值
            double repaymentTotal = 0.0;
            // 当前本金
            double nowTotal = total;
            // 当前余额
            double nowBalance = total;
            // 每月应归还本金
            double monthRepayment;
            if (periods > 0)
                monthRepayment = RoundToMinUint(total / periods);
            else
                monthRepayment = 0.0;
            // 防止优惠天数溢出
            if (discountDays > monthDays)
                discountDays = monthDays;

            string totalHistory = string.Format("每月天数：{0} 天，首月优惠天数：{1} 天\r\n\r\n",
                                                monthDays, discountDays);
            for (int month = 0; month < periods; month++)
            {
                double repayment;
                if (month != 0)
                    repayment = nowTotal * (rate * 0.01) * monthDays;
                else
                    repayment = nowTotal * (rate * 0.01) * (monthDays - discountDays);

                repayment = RoundToMinUint(repayment);
                repaymentTotal += repayment;

                if (month >= (periods - 1))
                    monthRepayment = nowTotal;

                nowTotal -= monthRepayment;
                if (nowTotal < 0.0)
                    nowTotal = 0.0;
                nowBalance = RoundToMinUint(nowTotal);

                nowBalance -= monthRepayment + repayment;
                nowBalance = RoundToMinUint(nowBalance);

                double balance;
                if (nowTotal > 0.0)
                    balance = nowTotal;
                else
                    balance = 0.0;

                string monthHistory = string.Format(
                    "第{0,-2}期，每月还款本金：{1,8:0.00} 元，利息：{2,8:0.00} 元，余额：{3,8:0.00} 元\r\n",
                    month + 1, monthRepayment, repayment, balance);
                totalHistory += monthHistory;
            }

            totalHistory += "\r\n";
            calcHistory = totalHistory;

            return RoundToMinUint(total + repaymentTotal);
        }
    }
}
