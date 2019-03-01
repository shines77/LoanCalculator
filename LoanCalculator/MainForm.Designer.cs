namespace LoanCalculator
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlLoan = new System.Windows.Forms.Panel();
            this.gpbLoan = new System.Windows.Forms.GroupBox();
            this.cmbRateMode = new System.Windows.Forms.ComboBox();
            this.lblRateMode = new System.Windows.Forms.Label();
            this.lblRate = new System.Windows.Forms.Label();
            this.cmbPeriods = new System.Windows.Forms.ComboBox();
            this.txtRate = new System.Windows.Forms.TextBox();
            this.lblPeriods = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.lblYuan = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblPercent = new System.Windows.Forms.Label();
            this.cmbCalcMode = new System.Windows.Forms.ComboBox();
            this.lblCalcMode = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRepayment = new System.Windows.Forms.TextBox();
            this.lblYuan2 = new System.Windows.Forms.Label();
            this.txtHistory = new System.Windows.Forms.TextBox();
            this.lblDay = new System.Windows.Forms.Label();
            this.lblDismountDays = new System.Windows.Forms.Label();
            this.txtDismountDays = new System.Windows.Forms.TextBox();
            this.pnlLoan.SuspendLayout();
            this.gpbLoan.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlLoan
            // 
            this.pnlLoan.Controls.Add(this.gpbLoan);
            this.pnlLoan.Location = new System.Drawing.Point(12, 11);
            this.pnlLoan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlLoan.Name = "pnlLoan";
            this.pnlLoan.Size = new System.Drawing.Size(631, 617);
            this.pnlLoan.TabIndex = 8;
            // 
            // gpbLoan
            // 
            this.gpbLoan.Controls.Add(this.lblDay);
            this.gpbLoan.Controls.Add(this.lblDismountDays);
            this.gpbLoan.Controls.Add(this.txtDismountDays);
            this.gpbLoan.Controls.Add(this.txtHistory);
            this.gpbLoan.Controls.Add(this.lblYuan2);
            this.gpbLoan.Controls.Add(this.label1);
            this.gpbLoan.Controls.Add(this.txtRepayment);
            this.gpbLoan.Controls.Add(this.cmbCalcMode);
            this.gpbLoan.Controls.Add(this.lblCalcMode);
            this.gpbLoan.Controls.Add(this.lblPercent);
            this.gpbLoan.Controls.Add(this.btnCalculate);
            this.gpbLoan.Controls.Add(this.lblYuan);
            this.gpbLoan.Controls.Add(this.cmbRateMode);
            this.gpbLoan.Controls.Add(this.lblRateMode);
            this.gpbLoan.Controls.Add(this.lblRate);
            this.gpbLoan.Controls.Add(this.cmbPeriods);
            this.gpbLoan.Controls.Add(this.txtRate);
            this.gpbLoan.Controls.Add(this.lblPeriods);
            this.gpbLoan.Controls.Add(this.lblTotal);
            this.gpbLoan.Controls.Add(this.txtTotal);
            this.gpbLoan.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.gpbLoan.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.gpbLoan.Location = new System.Drawing.Point(20, 13);
            this.gpbLoan.Margin = new System.Windows.Forms.Padding(4);
            this.gpbLoan.Name = "gpbLoan";
            this.gpbLoan.Padding = new System.Windows.Forms.Padding(4);
            this.gpbLoan.Size = new System.Drawing.Size(594, 590);
            this.gpbLoan.TabIndex = 10;
            this.gpbLoan.TabStop = false;
            this.gpbLoan.Text = "贷款利息";
            // 
            // cmbRateMode
            // 
            this.cmbRateMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRateMode.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbRateMode.FormattingEnabled = true;
            this.cmbRateMode.Items.AddRange(new object[] {
            "日利率",
            "月利率",
            "年利率"});
            this.cmbRateMode.Location = new System.Drawing.Point(190, 162);
            this.cmbRateMode.Margin = new System.Windows.Forms.Padding(4);
            this.cmbRateMode.Name = "cmbRateMode";
            this.cmbRateMode.Size = new System.Drawing.Size(137, 24);
            this.cmbRateMode.TabIndex = 23;
            // 
            // lblRateMode
            // 
            this.lblRateMode.AutoSize = true;
            this.lblRateMode.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblRateMode.Location = new System.Drawing.Point(93, 166);
            this.lblRateMode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRateMode.Name = "lblRateMode";
            this.lblRateMode.Size = new System.Drawing.Size(88, 16);
            this.lblRateMode.TabIndex = 22;
            this.lblRateMode.Text = "利率模式：";
            // 
            // lblRate
            // 
            this.lblRate.AutoSize = true;
            this.lblRate.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblRate.Location = new System.Drawing.Point(125, 121);
            this.lblRate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRate.Name = "lblRate";
            this.lblRate.Size = new System.Drawing.Size(56, 16);
            this.lblRate.TabIndex = 21;
            this.lblRate.Text = "利率：";
            // 
            // cmbPeriods
            // 
            this.cmbPeriods.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPeriods.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbPeriods.FormattingEnabled = true;
            this.cmbPeriods.Items.AddRange(new object[] {
            "1期",
            "2期",
            "3期",
            "4期",
            "5期",
            "6期",
            "7期",
            "8期",
            "9期",
            "10期",
            "11期",
            "12期",
            "13期",
            "14期",
            "15期",
            "16期",
            "17期",
            "18期",
            "19期",
            "20期",
            "21期",
            "22期",
            "23期",
            "24期"});
            this.cmbPeriods.Location = new System.Drawing.Point(189, 73);
            this.cmbPeriods.Margin = new System.Windows.Forms.Padding(4);
            this.cmbPeriods.Name = "cmbPeriods";
            this.cmbPeriods.Size = new System.Drawing.Size(139, 24);
            this.cmbPeriods.TabIndex = 20;
            // 
            // txtRate
            // 
            this.txtRate.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtRate.Location = new System.Drawing.Point(189, 117);
            this.txtRate.Margin = new System.Windows.Forms.Padding(4);
            this.txtRate.Name = "txtRate";
            this.txtRate.Size = new System.Drawing.Size(139, 26);
            this.txtRate.TabIndex = 19;
            // 
            // lblPeriods
            // 
            this.lblPeriods.AutoSize = true;
            this.lblPeriods.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblPeriods.Location = new System.Drawing.Point(109, 76);
            this.lblPeriods.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPeriods.Name = "lblPeriods";
            this.lblPeriods.Size = new System.Drawing.Size(72, 16);
            this.lblPeriods.TabIndex = 18;
            this.lblPeriods.Text = "总期数：";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblTotal.Location = new System.Drawing.Point(77, 33);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(104, 16);
            this.lblTotal.TabIndex = 17;
            this.lblTotal.Text = "贷款总金额：";
            // 
            // txtTotal
            // 
            this.txtTotal.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtTotal.Location = new System.Drawing.Point(189, 29);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(4);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(139, 26);
            this.txtTotal.TabIndex = 16;
            // 
            // lblYuan
            // 
            this.lblYuan.AutoSize = true;
            this.lblYuan.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblYuan.Location = new System.Drawing.Point(339, 33);
            this.lblYuan.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblYuan.Name = "lblYuan";
            this.lblYuan.Size = new System.Drawing.Size(104, 16);
            this.lblYuan.TabIndex = 24;
            this.lblYuan.Text = "元（人民币）";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCalculate.Location = new System.Drawing.Point(199, 293);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(121, 25);
            this.btnCalculate.TabIndex = 26;
            this.btnCalculate.Text = "计算利息";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblPercent
            // 
            this.lblPercent.AutoSize = true;
            this.lblPercent.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblPercent.Location = new System.Drawing.Point(339, 121);
            this.lblPercent.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPercent.Name = "lblPercent";
            this.lblPercent.Size = new System.Drawing.Size(16, 16);
            this.lblPercent.TabIndex = 27;
            this.lblPercent.Text = "%";
            // 
            // cmbCalcMode
            // 
            this.cmbCalcMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCalcMode.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbCalcMode.FormattingEnabled = true;
            this.cmbCalcMode.Items.AddRange(new object[] {
            "等额本金",
            "等额本息",
            "现金分期"});
            this.cmbCalcMode.Location = new System.Drawing.Point(191, 206);
            this.cmbCalcMode.Margin = new System.Windows.Forms.Padding(4);
            this.cmbCalcMode.Name = "cmbCalcMode";
            this.cmbCalcMode.Size = new System.Drawing.Size(137, 24);
            this.cmbCalcMode.TabIndex = 31;
            // 
            // lblCalcMode
            // 
            this.lblCalcMode.AutoSize = true;
            this.lblCalcMode.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblCalcMode.Location = new System.Drawing.Point(93, 209);
            this.lblCalcMode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCalcMode.Name = "lblCalcMode";
            this.lblCalcMode.Size = new System.Drawing.Size(88, 16);
            this.lblCalcMode.TabIndex = 30;
            this.lblCalcMode.Text = "计息方式：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(93, 253);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 16);
            this.label1.TabIndex = 35;
            this.label1.Text = "还款总额：";
            // 
            // txtRepayment
            // 
            this.txtRepayment.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtRepayment.Location = new System.Drawing.Point(191, 249);
            this.txtRepayment.Margin = new System.Windows.Forms.Padding(4);
            this.txtRepayment.Name = "txtRepayment";
            this.txtRepayment.Size = new System.Drawing.Size(139, 26);
            this.txtRepayment.TabIndex = 34;
            // 
            // lblYuan2
            // 
            this.lblYuan2.AutoSize = true;
            this.lblYuan2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblYuan2.Location = new System.Drawing.Point(339, 254);
            this.lblYuan2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblYuan2.Name = "lblYuan2";
            this.lblYuan2.Size = new System.Drawing.Size(104, 16);
            this.lblYuan2.TabIndex = 37;
            this.lblYuan2.Text = "元（人民币）";
            // 
            // txtHistory
            // 
            this.txtHistory.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtHistory.Location = new System.Drawing.Point(7, 336);
            this.txtHistory.Multiline = true;
            this.txtHistory.Name = "txtHistory";
            this.txtHistory.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtHistory.Size = new System.Drawing.Size(580, 247);
            this.txtHistory.TabIndex = 39;
            this.txtHistory.WordWrap = false;
            // 
            // lblDay
            // 
            this.lblDay.AutoSize = true;
            this.lblDay.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblDay.Location = new System.Drawing.Point(481, 210);
            this.lblDay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDay.Name = "lblDay";
            this.lblDay.Size = new System.Drawing.Size(24, 16);
            this.lblDay.TabIndex = 45;
            this.lblDay.Text = "天";
            // 
            // lblDismountDays
            // 
            this.lblDismountDays.AutoSize = true;
            this.lblDismountDays.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblDismountDays.Location = new System.Drawing.Point(397, 173);
            this.lblDismountDays.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDismountDays.Name = "lblDismountDays";
            this.lblDismountDays.Size = new System.Drawing.Size(120, 16);
            this.lblDismountDays.TabIndex = 44;
            this.lblDismountDays.Text = "首月优惠天数：";
            // 
            // txtDismountDays
            // 
            this.txtDismountDays.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtDismountDays.Location = new System.Drawing.Point(400, 204);
            this.txtDismountDays.Margin = new System.Windows.Forms.Padding(4);
            this.txtDismountDays.Name = "txtDismountDays";
            this.txtDismountDays.Size = new System.Drawing.Size(73, 26);
            this.txtDismountDays.TabIndex = 43;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 641);
            this.Controls.Add(this.pnlLoan);
            this.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "贷款利息计算器";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.pnlLoan.ResumeLayout(false);
            this.gpbLoan.ResumeLayout(false);
            this.gpbLoan.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlLoan;
        private System.Windows.Forms.GroupBox gpbLoan;
        private System.Windows.Forms.ComboBox cmbRateMode;
        private System.Windows.Forms.Label lblRateMode;
        private System.Windows.Forms.Label lblRate;
        private System.Windows.Forms.ComboBox cmbPeriods;
        private System.Windows.Forms.TextBox txtRate;
        private System.Windows.Forms.Label lblPeriods;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label lblYuan;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblPercent;
        private System.Windows.Forms.ComboBox cmbCalcMode;
        private System.Windows.Forms.Label lblCalcMode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRepayment;
        private System.Windows.Forms.Label lblYuan2;
        private System.Windows.Forms.TextBox txtHistory;
        private System.Windows.Forms.Label lblDay;
        private System.Windows.Forms.Label lblDismountDays;
        private System.Windows.Forms.TextBox txtDismountDays;
    }
}

