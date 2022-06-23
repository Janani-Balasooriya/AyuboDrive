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
            this.rentedDateDtp = new System.Windows.Forms.DateTimePicker();
            this.returnDateDtp = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.withoutDriverRadioBtn = new System.Windows.Forms.RadioButton();
            this.withDriverRadioBtn = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.totalRentLabel = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.materialDivider2 = new MaterialSkin.Controls.MaterialDivider();
            this.totalDriverCostLabel = new System.Windows.Forms.Label();
            this.driverRateLabel = new System.Windows.Forms.Label();
            this.totalDailyRentLabel = new System.Windows.Forms.Label();
            this.dailyRentLabel = new System.Windows.Forms.Label();
            this.totalWeeklyRentLabel = new System.Windows.Forms.Label();
            this.driverLabel = new System.Windows.Forms.Label();
            this.weeklyRentLabel = new System.Windows.Forms.Label();
            this.daysLabel = new System.Windows.Forms.Label();
            this.totalMonthlyRentLabel = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.weeksLabel = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.monthlyRateLabel = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.monthsLabel = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.vehicleNoComboTxt = new System.Windows.Forms.ComboBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.calculateBtn = new MaterialSkin.Controls.MaterialButton();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.materialCard1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rentedDateDtp
            // 
            this.rentedDateDtp.Location = new System.Drawing.Point(370, 128);
            this.rentedDateDtp.Name = "rentedDateDtp";
            this.rentedDateDtp.Size = new System.Drawing.Size(237, 20);
            this.rentedDateDtp.TabIndex = 1;
            this.rentedDateDtp.TabStop = false;
            // 
            // returnDateDtp
            // 
            this.returnDateDtp.Location = new System.Drawing.Point(370, 199);
            this.returnDateDtp.Name = "returnDateDtp";
            this.returnDateDtp.Size = new System.Drawing.Size(237, 20);
            this.returnDateDtp.TabIndex = 7;
            this.returnDateDtp.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.withoutDriverRadioBtn);
            this.groupBox1.Controls.Add(this.withDriverRadioBtn);
            this.groupBox1.Location = new System.Drawing.Point(37, 189);
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
            this.withDriverRadioBtn.Text = "Yes";
            this.withDriverRadioBtn.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.materialCard1);
            this.panel1.Controls.Add(this.materialDivider2);
            this.panel1.Controls.Add(this.totalDriverCostLabel);
            this.panel1.Controls.Add(this.driverRateLabel);
            this.panel1.Controls.Add(this.totalDailyRentLabel);
            this.panel1.Controls.Add(this.dailyRentLabel);
            this.panel1.Controls.Add(this.totalWeeklyRentLabel);
            this.panel1.Controls.Add(this.driverLabel);
            this.panel1.Controls.Add(this.weeklyRentLabel);
            this.panel1.Controls.Add(this.daysLabel);
            this.panel1.Controls.Add(this.totalMonthlyRentLabel);
            this.panel1.Controls.Add(this.label28);
            this.panel1.Controls.Add(this.weeksLabel);
            this.panel1.Controls.Add(this.label27);
            this.panel1.Controls.Add(this.monthlyRateLabel);
            this.panel1.Controls.Add(this.label22);
            this.panel1.Controls.Add(this.label18);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.monthsLabel);
            this.panel1.Controls.Add(this.label21);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(38, 327);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(569, 191);
            this.panel1.TabIndex = 13;
            this.panel1.Visible = false;
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.totalRentLabel);
            this.materialCard1.Controls.Add(this.label13);
            this.materialCard1.Controls.Add(this.label14);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(14, 135);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(544, 40);
            this.materialCard1.TabIndex = 19;
            // 
            // totalRentLabel
            // 
            this.totalRentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalRentLabel.Location = new System.Drawing.Point(461, 10);
            this.totalRentLabel.Name = "totalRentLabel";
            this.totalRentLabel.Size = new System.Drawing.Size(70, 16);
            this.totalRentLabel.TabIndex = 5;
            this.totalRentLabel.Text = "label6";
            this.totalRentLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(8, 10);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(63, 16);
            this.label13.TabIndex = 0;
            this.label13.Text = "Total rent";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(112, 10);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(14, 16);
            this.label14.TabIndex = 2;
            this.label14.Text = "=";
            // 
            // materialDivider2
            // 
            this.materialDivider2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider2.Depth = 0;
            this.materialDivider2.Location = new System.Drawing.Point(447, 24);
            this.materialDivider2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider2.Name = "materialDivider2";
            this.materialDivider2.Size = new System.Drawing.Size(10, 128);
            this.materialDivider2.TabIndex = 18;
            this.materialDivider2.Text = "materialDivider1";
            // 
            // totalDriverCostLabel
            // 
            this.totalDriverCostLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalDriverCostLabel.Location = new System.Drawing.Point(474, 105);
            this.totalDriverCostLabel.Name = "totalDriverCostLabel";
            this.totalDriverCostLabel.Size = new System.Drawing.Size(70, 16);
            this.totalDriverCostLabel.TabIndex = 5;
            this.totalDriverCostLabel.Text = "label6";
            this.totalDriverCostLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // driverRateLabel
            // 
            this.driverRateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.driverRateLabel.Location = new System.Drawing.Point(324, 105);
            this.driverRateLabel.Name = "driverRateLabel";
            this.driverRateLabel.Size = new System.Drawing.Size(70, 16);
            this.driverRateLabel.TabIndex = 4;
            this.driverRateLabel.Text = "label6";
            this.driverRateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // totalDailyRentLabel
            // 
            this.totalDailyRentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalDailyRentLabel.Location = new System.Drawing.Point(474, 77);
            this.totalDailyRentLabel.Name = "totalDailyRentLabel";
            this.totalDailyRentLabel.Size = new System.Drawing.Size(70, 16);
            this.totalDailyRentLabel.TabIndex = 5;
            this.totalDailyRentLabel.Text = "label6";
            this.totalDailyRentLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // dailyRentLabel
            // 
            this.dailyRentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dailyRentLabel.Location = new System.Drawing.Point(324, 77);
            this.dailyRentLabel.Name = "dailyRentLabel";
            this.dailyRentLabel.Size = new System.Drawing.Size(70, 16);
            this.dailyRentLabel.TabIndex = 4;
            this.dailyRentLabel.Text = "label6";
            this.dailyRentLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // totalWeeklyRentLabel
            // 
            this.totalWeeklyRentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalWeeklyRentLabel.Location = new System.Drawing.Point(474, 50);
            this.totalWeeklyRentLabel.Name = "totalWeeklyRentLabel";
            this.totalWeeklyRentLabel.Size = new System.Drawing.Size(70, 16);
            this.totalWeeklyRentLabel.TabIndex = 5;
            this.totalWeeklyRentLabel.Text = "label6";
            this.totalWeeklyRentLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // driverLabel
            // 
            this.driverLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.driverLabel.Location = new System.Drawing.Point(205, 105);
            this.driverLabel.Name = "driverLabel";
            this.driverLabel.Size = new System.Drawing.Size(70, 16);
            this.driverLabel.TabIndex = 3;
            this.driverLabel.Text = "label6";
            this.driverLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // weeklyRentLabel
            // 
            this.weeklyRentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weeklyRentLabel.Location = new System.Drawing.Point(324, 50);
            this.weeklyRentLabel.Name = "weeklyRentLabel";
            this.weeklyRentLabel.Size = new System.Drawing.Size(70, 16);
            this.weeklyRentLabel.TabIndex = 4;
            this.weeklyRentLabel.Text = "label6";
            this.weeklyRentLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // daysLabel
            // 
            this.daysLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.daysLabel.Location = new System.Drawing.Point(205, 77);
            this.daysLabel.Name = "daysLabel";
            this.daysLabel.Size = new System.Drawing.Size(70, 16);
            this.daysLabel.TabIndex = 3;
            this.daysLabel.Text = "label6";
            this.daysLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // totalMonthlyRentLabel
            // 
            this.totalMonthlyRentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalMonthlyRentLabel.Location = new System.Drawing.Point(474, 24);
            this.totalMonthlyRentLabel.Name = "totalMonthlyRentLabel";
            this.totalMonthlyRentLabel.Size = new System.Drawing.Size(70, 16);
            this.totalMonthlyRentLabel.TabIndex = 5;
            this.totalMonthlyRentLabel.Text = "label6";
            this.totalMonthlyRentLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.Location = new System.Drawing.Point(126, 105);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(14, 16);
            this.label28.TabIndex = 2;
            this.label28.Text = "=";
            // 
            // weeksLabel
            // 
            this.weeksLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weeksLabel.Location = new System.Drawing.Point(205, 50);
            this.weeksLabel.Name = "weeksLabel";
            this.weeksLabel.Size = new System.Drawing.Size(70, 16);
            this.weeksLabel.TabIndex = 3;
            this.weeksLabel.Text = "label6";
            this.weeksLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(126, 77);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(14, 16);
            this.label27.TabIndex = 2;
            this.label27.Text = "=";
            // 
            // monthlyRateLabel
            // 
            this.monthlyRateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthlyRateLabel.Location = new System.Drawing.Point(324, 24);
            this.monthlyRateLabel.Name = "monthlyRateLabel";
            this.monthlyRateLabel.Size = new System.Drawing.Size(70, 16);
            this.monthlyRateLabel.TabIndex = 4;
            this.monthlyRateLabel.Text = "label6";
            this.monthlyRateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(306, 105);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(15, 16);
            this.label22.TabIndex = 2;
            this.label22.Text = "X";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(126, 50);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(14, 16);
            this.label18.TabIndex = 2;
            this.label18.Text = "=";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(306, 77);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(15, 16);
            this.label16.TabIndex = 2;
            this.label16.Text = "X";
            // 
            // monthsLabel
            // 
            this.monthsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthsLabel.Location = new System.Drawing.Point(205, 24);
            this.monthsLabel.Name = "monthsLabel";
            this.monthsLabel.Size = new System.Drawing.Size(70, 16);
            this.monthsLabel.TabIndex = 3;
            this.monthsLabel.Text = "label6";
            this.monthsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(21, 105);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(71, 16);
            this.label21.TabIndex = 0;
            this.label21.Text = "Driver cost";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(306, 50);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(15, 16);
            this.label10.TabIndex = 2;
            this.label10.Text = "X";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(126, 24);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(14, 16);
            this.label12.TabIndex = 2;
            this.label12.Text = "=";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(21, 77);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(63, 16);
            this.label15.TabIndex = 0;
            this.label15.Text = "Daily rent";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(21, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "Weekly rent";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(306, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(15, 16);
            this.label8.TabIndex = 2;
            this.label8.Text = "X";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Monthly rent";
            // 
            // vehicleNoComboTxt
            // 
            this.vehicleNoComboTxt.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.vehicleNoComboTxt.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.vehicleNoComboTxt.FormattingEnabled = true;
            this.vehicleNoComboTxt.Items.AddRange(new object[] {
            ""});
            this.vehicleNoComboTxt.Location = new System.Drawing.Point(38, 131);
            this.vehicleNoComboTxt.Name = "vehicleNoComboTxt";
            this.vehicleNoComboTxt.Size = new System.Drawing.Size(237, 21);
            this.vehicleNoComboTxt.TabIndex = 15;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(37, 100);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(112, 19);
            this.materialLabel1.TabIndex = 16;
            this.materialLabel1.Text = "Vehicle Number";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(372, 102);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(87, 19);
            this.materialLabel2.TabIndex = 16;
            this.materialLabel2.Text = "Rented Date";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(374, 173);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(101, 19);
            this.materialLabel3.TabIndex = 16;
            this.materialLabel3.Text = "Returned Date";
            // 
            // materialDivider1
            // 
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Location = new System.Drawing.Point(314, 100);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(10, 128);
            this.materialDivider1.TabIndex = 18;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.Location = new System.Drawing.Point(37, 173);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(90, 19);
            this.materialLabel4.TabIndex = 16;
            this.materialLabel4.Text = "With Driver ?";
            // 
            // calculateBtn
            // 
            this.calculateBtn.AutoSize = false;
            this.calculateBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.calculateBtn.Depth = 0;
            this.calculateBtn.DrawShadows = true;
            this.calculateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculateBtn.HighEmphasis = true;
            this.calculateBtn.Icon = null;
            this.calculateBtn.Location = new System.Drawing.Point(37, 249);
            this.calculateBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.calculateBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.calculateBtn.Name = "calculateBtn";
            this.calculateBtn.Size = new System.Drawing.Size(570, 44);
            this.calculateBtn.TabIndex = 19;
            this.calculateBtn.TabStop = false;
            this.calculateBtn.Text = "Calculate Rent";
            this.calculateBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.calculateBtn.UseAccentColor = false;
            this.calculateBtn.UseVisualStyleBackColor = true;
            this.calculateBtn.Click += new System.EventHandler(this.calculateBtn_Click);
            // 
            // RentCalculationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 545);
            this.Controls.Add(this.calculateBtn);
            this.Controls.Add(this.materialDivider1);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.rentedDateDtp);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.vehicleNoComboTxt);
            this.Controls.Add(this.returnDateDtp);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Name = "RentCalculationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rent Calculation";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker rentedDateDtp;
        private System.Windows.Forms.DateTimePicker returnDateDtp;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton withoutDriverRadioBtn;
        private System.Windows.Forms.RadioButton withDriverRadioBtn;
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
        private System.Windows.Forms.Label weeksLabel;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label monthlyRateLabel;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label monthsLabel;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label totalRentLabel;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox vehicleNoComboTxt;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialButton calculateBtn;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialDivider materialDivider2;
        private System.Windows.Forms.Label label14;
    }
}

