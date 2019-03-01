using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoanCalculator
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // 贷款总金额, 默认值: 10000 元
            txtTotal.Text = "10000";

            // 总期数，默认选项: 12 期
            cmbPeriods.SelectedIndex = 11;

            // 利率, 默认值: 0.045%
            txtRate.Text = "0.045";

            // 利率模式，默认选项: 日利率
            cmbRateMode.SelectedIndex = 0;

            // 计息方式，默认选项: 等额本息
            cmbCalcMode.SelectedIndex = 1;

            // 每月天数, 默认值为 30 天.
            txtMonthDays.Text = "30";

            // 首月优惠天数, 默认值: 7天
            txtDismountDays.Text = "7";
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            btnCalculate.Focus();
        }

        private double CalcalateLoan(double total, double rate, int periods, int rateMode, int calcMode,
                                     int monthDays, int dismountDays, ref string calcHistory)
        {
            double repaymentTotal = 0.0;

            try
            {
                DecInterestCalculator calculator = new DecInterestCalculator(total, rate, periods, rateMode);
                calculator.SetMonthDays(monthDays);
                calculator.SetDismountDays(dismountDays);
                repaymentTotal = calculator.Calculate(ref calcHistory);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
            }

            return repaymentTotal;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double total = 10000.0;
            double rate = 0.045;
            int periods = 12;
            int rateMode = 0;
            int calcMode = 1;
            int monthDays = 0;
            int dismountDays = 0;

            try
            {
                total = Double.Parse(txtTotal.Text);
                rate = Double.Parse(txtRate.Text);
                periods = Int32.Parse(cmbPeriods.Text);
                rateMode = cmbRateMode.SelectedIndex;
                calcMode = cmbCalcMode.SelectedIndex;
                monthDays = Int32.Parse(txtMonthDays.Text);
                dismountDays = Int32.Parse(txtDismountDays.Text);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
            }

            // 清空还款总额
            txtRepayment.Text = "";

            // 计算还款总额
            string calcHistory = "";
            double repayment = CalcalateLoan(total, rate, periods, rateMode, calcMode,
                                             monthDays, dismountDays, ref calcHistory);

            // 显示还款总额
            txtRepayment.Text = String.Format("{0:0.00}", repayment);

            // 显示还款历史
            txtHistory.Text = calcHistory;
            txtHistory.SelectionStart = 0;
            txtHistory.SelectionLength = 0;
        }
    }
}
