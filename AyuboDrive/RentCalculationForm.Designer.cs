namespace AyuboDrive
{
    partial class RentCalculationForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.calculateBtn = new System.Windows.Forms.Button();
            this.rentedDateDtp = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.returnDateDtp = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.withoutDriverRadioBtn = new System.Windows.Forms.RadioButton();
            this.withDriverRadioBtn = new System.Windows.Forms.RadioButton();
            this.vehicleNoTxt = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.totalRentLabel = new System.Windows.Forms.Label();
            this.totalDriverCostLabel = new System.Windows.Forms.Label();
            this.driverRateLabel = new System.Windows.Forms.Label();
            this.totalDailyRentLabel = new System.Windows.Forms.Label();
            this.dailyRentLabel = new System.Windows.Forms.Label();
            this.totalWeeklyRentLabel = new System.Windows.Forms.Label();
            this.driverLabel = new System.Windows.Forms.Label();
            this.weeklyRentLabel = new System.Windows.Forms.Label();
            this.daysLabel = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.totalMonthlyRentLabel = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.weeksLabel = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.monthlyRateLabel = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.monthsLabel = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.vehicleNameTxt = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // calculateBtn
            // 
            this.calculateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculateBtn.Location = new System.Drawing.Point(651, 378);
            this.calculateBtn.Name = "calculateBtn";
            this.calculateBtn.Size = new System.Drawing.Size(94, 34);
            this.calculateBtn.TabIndex = 0;
            this.calculateBtn.Text = "Calculate";
            this.calculateBtn.UseVisualStyleBackColor = true;
            this.calculateBtn.Click += new System.EventHandler(this.calculateBtn_Click);
            // 
            // rentedDateDtp
            // 
            this.rentedDateDtp.Location = new System.Drawing.Point(133, 110);
            this.rentedDateDtp.Name = "rentedDateDtp";
            this.rentedDateDtp.Size = new System.Drawing.Size(200, 20);
            this.rentedDateDtp.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Rent Calculation";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Vehicle number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Rented date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(48, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Return date";
            // 
            // returnDateDtp
            // 
            this.returnDateDtp.Location = new System.Drawing.Point(133, 150);
            this.returnDateDtp.Name = "returnDateDtp";
            this.returnDateDtp.Size = new System.Drawing.Size(200, 20);
            this.returnDateDtp.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(48, 189);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "With driver";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.withoutDriverRadioBtn);
            this.groupBox1.Controls.Add(this.withDriverRadioBtn);
            this.groupBox1.Location = new System.Drawing.Point(133, 176);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(139, 35);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            // 
            // withoutDriverRadioBtn
            // 
            this.withoutDriverRadioBtn.AutoSize = true;
            this.withoutDriverRadioBtn.Location = new System.Drawing.Point(80, 10);
            this.withoutDriverRadioBtn.Name = "withoutDriverRadioBtn";
            this.withoutDriverRadioBtn.Size = new System.Drawing.Size(39, 17);
            this.withoutDriverRadioBtn.TabIndex = 1;
            this.withoutDriverRadioBtn.TabStop = true;
            this.withoutDriverRadioBtn.Text = "No";
            this.withoutDriverRadioBtn.UseVisualStyleBackColor = true;
            // 
            // withDriverRadioBtn
            // 
            this.withDriverRadioBtn.AutoSize = true;
            this.withDriverRadioBtn.Location = new System.Drawing.Point(7, 10);
            this.withDriverRadioBtn.Name = "withDriverRadioBtn";
            this.withDriverRadioBtn.Size = new System.Drawing.Size(43, 17);
            this.withDriverRadioBtn.TabIndex = 0;
            this.withDriverRadioBtn.TabStop = true;
            this.withDriverRadioBtn.Text = "Yes";
            this.withDriverRadioBtn.UseVisualStyleBackColor = true;
            // 
            // vehicleNoTxt
            // 
            this.vehicleNoTxt.Location = new System.Drawing.Point(133, 72);
            this.vehicleNoTxt.Name = "vehicleNoTxt";
            this.vehicleNoTxt.Size = new System.Drawing.Size(100, 20);
            this.vehicleNoTxt.TabIndex = 12;
            this.vehicleNoTxt.Leave += new System.EventHandler(this.vehicleNoTxt_Leave);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.totalRentLabel);
            this.panel1.Controls.Add(this.totalDriverCostLabel);
            this.panel1.Controls.Add(this.driverRateLabel);
            this.panel1.Controls.Add(this.totalDailyRentLabel);
            this.panel1.Controls.Add(this.dailyRentLabel);
            this.panel1.Controls.Add(this.totalWeeklyRentLabel);
            this.panel1.Controls.Add(this.driverLabel);
            this.panel1.Controls.Add(this.weeklyRentLabel);
            this.panel1.Controls.Add(this.daysLabel);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.totalMonthlyRentLabel);
            this.panel1.Controls.Add(this.label28);
            this.panel1.Controls.Add(this.label23);
            this.panel1.Controls.Add(this.weeksLabel);
            this.panel1.Controls.Add(this.label27);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.monthlyRateLabel);
            this.panel1.Controls.Add(this.label22);
            this.panel1.Controls.Add(this.label18);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.monthsLabel);
            this.panel1.Controls.Add(this.label21);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(363, 176);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(382, 178);
            this.panel1.TabIndex = 13;
            // 
            // totalRentLabel
            // 
            this.totalRentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalRentLabel.Location = new System.Drawing.Point(303, 140);
            this.totalRentLabel.Name = "totalRentLabel";
            this.totalRentLabel.Size = new System.Drawing.Size(44, 16);
            this.totalRentLabel.TabIndex = 5;
            this.totalRentLabel.Text = "label6";
            this.totalRentLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // totalDriverCostLabel
            // 
            this.totalDriverCostLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalDriverCostLabel.Location = new System.Drawing.Point(303, 105);
            this.totalDriverCostLabel.Name = "totalDriverCostLabel";
            this.totalDriverCostLabel.Size = new System.Drawing.Size(44, 16);
            this.totalDriverCostLabel.TabIndex = 5;
            this.totalDriverCostLabel.Text = "label6";
            this.totalDriverCostLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // driverRateLabel
            // 
            this.driverRateLabel.AutoSize = true;
            this.driverRateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.driverRateLabel.Location = new System.Drawing.Point(213, 105);
            this.driverRateLabel.Name = "driverRateLabel";
            this.driverRateLabel.Size = new System.Drawing.Size(44, 16);
            this.driverRateLabel.TabIndex = 4;
            this.driverRateLabel.Text = "label6";
            this.driverRateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // totalDailyRentLabel
            // 
            this.totalDailyRentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalDailyRentLabel.Location = new System.Drawing.Point(303, 77);
            this.totalDailyRentLabel.Name = "totalDailyRentLabel";
            this.totalDailyRentLabel.Size = new System.Drawing.Size(44, 16);
            this.totalDailyRentLabel.TabIndex = 5;
            this.totalDailyRentLabel.Text = "label6";
            this.totalDailyRentLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // dailyRentLabel
            // 
            this.dailyRentLabel.AutoSize = true;
            this.dailyRentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dailyRentLabel.Location = new System.Drawing.Point(213, 77);
            this.dailyRentLabel.Name = "dailyRentLabel";
            this.dailyRentLabel.Size = new System.Drawing.Size(44, 16);
            this.dailyRentLabel.TabIndex = 4;
            this.dailyRentLabel.Text = "label6";
            this.dailyRentLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // totalWeeklyRentLabel
            // 
            this.totalWeeklyRentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalWeeklyRentLabel.Location = new System.Drawing.Point(303, 50);
            this.totalWeeklyRentLabel.Name = "totalWeeklyRentLabel";
            this.totalWeeklyRentLabel.Size = new System.Drawing.Size(44, 16);
            this.totalWeeklyRentLabel.TabIndex = 5;
            this.totalWeeklyRentLabel.Text = "label6";
            this.totalWeeklyRentLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // driverLabel
            // 
            this.driverLabel.AutoSize = true;
            this.driverLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.driverLabel.Location = new System.Drawing.Point(137, 105);
            this.driverLabel.Name = "driverLabel";
            this.driverLabel.Size = new System.Drawing.Size(44, 16);
            this.driverLabel.TabIndex = 3;
            this.driverLabel.Text = "label6";
            this.driverLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // weeklyRentLabel
            // 
            this.weeklyRentLabel.AutoSize = true;
            this.weeklyRentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weeklyRentLabel.Location = new System.Drawing.Point(213, 50);
            this.weeklyRentLabel.Name = "weeklyRentLabel";
            this.weeklyRentLabel.Size = new System.Drawing.Size(44, 16);
            this.weeklyRentLabel.TabIndex = 4;
            this.weeklyRentLabel.Text = "label6";
            this.weeklyRentLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // daysLabel
            // 
            this.daysLabel.AutoSize = true;
            this.daysLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.daysLabel.Location = new System.Drawing.Point(137, 77);
            this.daysLabel.Name = "daysLabel";
            this.daysLabel.Size = new System.Drawing.Size(44, 16);
            this.daysLabel.TabIndex = 3;
            this.daysLabel.Text = "label6";
            this.daysLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(112, 140);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(14, 16);
            this.label14.TabIndex = 2;
            this.label14.Text = "=";
            // 
            // totalMonthlyRentLabel
            // 
            this.totalMonthlyRentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalMonthlyRentLabel.Location = new System.Drawing.Point(303, 24);
            this.totalMonthlyRentLabel.Name = "totalMonthlyRentLabel";
            this.totalMonthlyRentLabel.Size = new System.Drawing.Size(44, 16);
            this.totalMonthlyRentLabel.TabIndex = 5;
            this.totalMonthlyRentLabel.Text = "label6";
            this.totalMonthlyRentLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.Location = new System.Drawing.Point(112, 105);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(14, 16);
            this.label28.TabIndex = 2;
            this.label28.Text = "=";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(282, 105);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(14, 16);
            this.label23.TabIndex = 2;
            this.label23.Text = "=";
            // 
            // weeksLabel
            // 
            this.weeksLabel.AutoSize = true;
            this.weeksLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weeksLabel.Location = new System.Drawing.Point(137, 50);
            this.weeksLabel.Name = "weeksLabel";
            this.weeksLabel.Size = new System.Drawing.Size(44, 16);
            this.weeksLabel.TabIndex = 3;
            this.weeksLabel.Text = "label6";
            this.weeksLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(112, 77);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(14, 16);
            this.label27.TabIndex = 2;
            this.label27.Text = "=";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(282, 77);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(14, 16);
            this.label17.TabIndex = 2;
            this.label17.Text = "=";
            // 
            // monthlyRateLabel
            // 
            this.monthlyRateLabel.AutoSize = true;
            this.monthlyRateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthlyRateLabel.Location = new System.Drawing.Point(213, 24);
            this.monthlyRateLabel.Name = "monthlyRateLabel";
            this.monthlyRateLabel.Size = new System.Drawing.Size(44, 16);
            this.monthlyRateLabel.TabIndex = 4;
            this.monthlyRateLabel.Text = "label6";
            this.monthlyRateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(192, 105);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(15, 16);
            this.label22.TabIndex = 2;
            this.label22.Text = "X";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(112, 50);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(14, 16);
            this.label18.TabIndex = 2;
            this.label18.Text = "=";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(282, 50);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(14, 16);
            this.label11.TabIndex = 2;
            this.label11.Text = "=";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(192, 77);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(15, 16);
            this.label16.TabIndex = 2;
            this.label16.Text = "X";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(19, 140);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(63, 16);
            this.label13.TabIndex = 0;
            this.label13.Text = "Total rent";
            // 
            // monthsLabel
            // 
            this.monthsLabel.AutoSize = true;
            this.monthsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthsLabel.Location = new System.Drawing.Point(137, 24);
            this.monthsLabel.Name = "monthsLabel";
            this.monthsLabel.Size = new System.Drawing.Size(44, 16);
            this.monthsLabel.TabIndex = 3;
            this.monthsLabel.Text = "label6";
            this.monthsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(19, 105);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(71, 16);
            this.label21.TabIndex = 0;
            this.label21.Text = "Driver cost";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(192, 50);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(15, 16);
            this.label10.TabIndex = 2;
            this.label10.Text = "X";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(112, 24);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(14, 16);
            this.label12.TabIndex = 2;
            this.label12.Text = "=";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(19, 77);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(63, 16);
            this.label15.TabIndex = 0;
            this.label15.Text = "Daily rent";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(282, 24);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(14, 16);
            this.label9.TabIndex = 2;
            this.label9.Text = "=";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(19, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "Weekly rent";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(192, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(15, 16);
            this.label8.TabIndex = 2;
            this.label8.Text = "X";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Monthly rent";
            // 
            // vehicleNameTxt
            // 
            this.vehicleNameTxt.AutoSize = true;
            this.vehicleNameTxt.Location = new System.Drawing.Point(253, 75);
            this.vehicleNameTxt.Name = "vehicleNameTxt";
            this.vehicleNameTxt.Size = new System.Drawing.Size(71, 13);
            this.vehicleNameTxt.TabIndex = 3;
            this.vehicleNameTxt.Text = "Vehicle name";
            // 
            // RentCalculationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.vehicleNoTxt);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.returnDateDtp);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.vehicleNameTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rentedDateDtp);
            this.Controls.Add(this.calculateBtn);
            this.Name = "RentCalculationForm";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button calculateBtn;
        private System.Windows.Forms.DateTimePicker rentedDateDtp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker returnDateDtp;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton withoutDriverRadioBtn;
        private System.Windows.Forms.RadioButton withDriverRadioBtn;
        private System.Windows.Forms.TextBox vehicleNoTxt;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label totalDriverCostLabel;
        private System.Windows.Forms.Label driverRateLabel;
        private System.Windows.Forms.Label totalDailyRentLabel;
        private System.Windows.Forms.Label dailyRentLabel;
        private System.Windows.Forms.Label totalWeeklyRentLabel;
        private System.Windows.Forms.Label driverLabel;
        private System.Windows.Forms.Label weeklyRentLabel;
        private System.Windows.Forms.Label daysLabel;
        private System.Windows.Forms.Label totalMonthlyRentLabel;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label weeksLabel;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label monthlyRateLabel;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label monthsLabel;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label totalRentLabel;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label vehicleNameTxt;
    }
}

