namespace AyuboDrive
{
    partial class DayTourHireCalculationForm
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
            this.packageTypeCombo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.vehicleNoTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.startTimeDtp = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.startKmReadingTxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.endKmReadingTxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.endTimeDtp = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.totalHireLabel = new System.Windows.Forms.Label();
            this.waitingChargeLabel = new System.Windows.Forms.Label();
            this.waitingChargeRateLabel = new System.Windows.Forms.Label();
            this.extraKmChargeLabel = new System.Windows.Forms.Label();
            this.extraKmChargeRateLabel = new System.Windows.Forms.Label();
            this.extraHoursLabel = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.baseHireChargeLabel = new System.Windows.Forms.Label();
            this.extraKmsLabel = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.maxKmLimitLabel = new System.Windows.Forms.Label();
            this.maxHoursLabel = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label28 = new System.Windows.Forms.Label();
            this.tourDurationLabel = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.distanceTravelledLabel = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // calculateBtn
            // 
            this.calculateBtn.Location = new System.Drawing.Point(44, 313);
            this.calculateBtn.Name = "calculateBtn";
            this.calculateBtn.Size = new System.Drawing.Size(75, 23);
            this.calculateBtn.TabIndex = 0;
            this.calculateBtn.Text = "Calculate";
            this.calculateBtn.UseVisualStyleBackColor = true;
            this.calculateBtn.Click += new System.EventHandler(this.calculateBtn_Click);
            // 
            // packageTypeCombo
            // 
            this.packageTypeCombo.FormattingEnabled = true;
            this.packageTypeCombo.Location = new System.Drawing.Point(129, 72);
            this.packageTypeCombo.Name = "packageTypeCombo";
            this.packageTypeCombo.Size = new System.Drawing.Size(121, 21);
            this.packageTypeCombo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Package type";
            // 
            // vehicleNoTxt
            // 
            this.vehicleNoTxt.Location = new System.Drawing.Point(129, 29);
            this.vehicleNoTxt.Name = "vehicleNoTxt";
            this.vehicleNoTxt.Size = new System.Drawing.Size(100, 20);
            this.vehicleNoTxt.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Vehicle no";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Start time";
            // 
            // startTimeDtp
            // 
            this.startTimeDtp.CustomFormat = "HH:mm:ss";
            this.startTimeDtp.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.startTimeDtp.Location = new System.Drawing.Point(129, 117);
            this.startTimeDtp.Name = "startTimeDtp";
            this.startTimeDtp.ShowUpDown = true;
            this.startTimeDtp.Size = new System.Drawing.Size(200, 20);
            this.startTimeDtp.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "End time";
            // 
            // startKmReadingTxt
            // 
            this.startKmReadingTxt.Location = new System.Drawing.Point(137, 200);
            this.startKmReadingTxt.Name = "startKmReadingTxt";
            this.startKmReadingTxt.Size = new System.Drawing.Size(100, 20);
            this.startKmReadingTxt.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Start Km Reading";
            // 
            // endKmReadingTxt
            // 
            this.endKmReadingTxt.Location = new System.Drawing.Point(137, 226);
            this.endKmReadingTxt.Name = "endKmReadingTxt";
            this.endKmReadingTxt.Size = new System.Drawing.Size(100, 20);
            this.endKmReadingTxt.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(41, 226);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Start Km Reading";
            // 
            // endTimeDtp
            // 
            this.endTimeDtp.CustomFormat = "HH:mm:ss";
            this.endTimeDtp.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.endTimeDtp.Location = new System.Drawing.Point(129, 150);
            this.endTimeDtp.Name = "endTimeDtp";
            this.endTimeDtp.ShowUpDown = true;
            this.endTimeDtp.Size = new System.Drawing.Size(200, 20);
            this.endTimeDtp.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.totalHireLabel);
            this.panel1.Controls.Add(this.waitingChargeLabel);
            this.panel1.Controls.Add(this.waitingChargeRateLabel);
            this.panel1.Controls.Add(this.extraKmChargeLabel);
            this.panel1.Controls.Add(this.extraKmChargeRateLabel);
            this.panel1.Controls.Add(this.extraHoursLabel);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.baseHireChargeLabel);
            this.panel1.Controls.Add(this.extraKmsLabel);
            this.panel1.Controls.Add(this.label27);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.label18);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label19);
            this.panel1.Location = new System.Drawing.Point(341, 172);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(447, 178);
            this.panel1.TabIndex = 14;
            // 
            // totalHireLabel
            // 
            this.totalHireLabel.AutoSize = true;
            this.totalHireLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalHireLabel.Location = new System.Drawing.Point(334, 140);
            this.totalHireLabel.Name = "totalHireLabel";
            this.totalHireLabel.Size = new System.Drawing.Size(44, 16);
            this.totalHireLabel.TabIndex = 5;
            this.totalHireLabel.Text = "label6";
            this.totalHireLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // waitingChargeLabel
            // 
            this.waitingChargeLabel.AutoSize = true;
            this.waitingChargeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.waitingChargeLabel.Location = new System.Drawing.Point(334, 54);
            this.waitingChargeLabel.Name = "waitingChargeLabel";
            this.waitingChargeLabel.Size = new System.Drawing.Size(44, 16);
            this.waitingChargeLabel.TabIndex = 5;
            this.waitingChargeLabel.Text = "label6";
            this.waitingChargeLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // waitingChargeRateLabel
            // 
            this.waitingChargeRateLabel.AutoSize = true;
            this.waitingChargeRateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.waitingChargeRateLabel.Location = new System.Drawing.Point(223, 54);
            this.waitingChargeRateLabel.Name = "waitingChargeRateLabel";
            this.waitingChargeRateLabel.Size = new System.Drawing.Size(44, 16);
            this.waitingChargeRateLabel.TabIndex = 4;
            this.waitingChargeRateLabel.Text = "label6";
            this.waitingChargeRateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // extraKmChargeLabel
            // 
            this.extraKmChargeLabel.AutoSize = true;
            this.extraKmChargeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.extraKmChargeLabel.Location = new System.Drawing.Point(334, 84);
            this.extraKmChargeLabel.Name = "extraKmChargeLabel";
            this.extraKmChargeLabel.Size = new System.Drawing.Size(44, 16);
            this.extraKmChargeLabel.TabIndex = 5;
            this.extraKmChargeLabel.Text = "label6";
            this.extraKmChargeLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // extraKmChargeRateLabel
            // 
            this.extraKmChargeRateLabel.AutoSize = true;
            this.extraKmChargeRateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.extraKmChargeRateLabel.Location = new System.Drawing.Point(223, 84);
            this.extraKmChargeRateLabel.Name = "extraKmChargeRateLabel";
            this.extraKmChargeRateLabel.Size = new System.Drawing.Size(44, 16);
            this.extraKmChargeRateLabel.TabIndex = 4;
            this.extraKmChargeRateLabel.Text = "label6";
            this.extraKmChargeRateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // extraHoursLabel
            // 
            this.extraHoursLabel.AutoSize = true;
            this.extraHoursLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.extraHoursLabel.Location = new System.Drawing.Point(148, 54);
            this.extraHoursLabel.Name = "extraHoursLabel";
            this.extraHoursLabel.Size = new System.Drawing.Size(44, 16);
            this.extraHoursLabel.TabIndex = 3;
            this.extraHoursLabel.Text = "label6";
            this.extraHoursLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(128, 140);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(14, 16);
            this.label14.TabIndex = 2;
            this.label14.Text = "=";
            // 
            // baseHireChargeLabel
            // 
            this.baseHireChargeLabel.AutoSize = true;
            this.baseHireChargeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.baseHireChargeLabel.Location = new System.Drawing.Point(334, 24);
            this.baseHireChargeLabel.Name = "baseHireChargeLabel";
            this.baseHireChargeLabel.Size = new System.Drawing.Size(44, 16);
            this.baseHireChargeLabel.TabIndex = 5;
            this.baseHireChargeLabel.Text = "label6";
            this.baseHireChargeLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // extraKmsLabel
            // 
            this.extraKmsLabel.AutoSize = true;
            this.extraKmsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.extraKmsLabel.Location = new System.Drawing.Point(148, 84);
            this.extraKmsLabel.Name = "extraKmsLabel";
            this.extraKmsLabel.Size = new System.Drawing.Size(44, 16);
            this.extraKmsLabel.TabIndex = 3;
            this.extraKmsLabel.Text = "label6";
            this.extraKmsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(128, 54);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(14, 16);
            this.label27.TabIndex = 2;
            this.label27.Text = "=";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(313, 54);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(14, 16);
            this.label17.TabIndex = 2;
            this.label17.Text = "=";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(128, 84);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(14, 16);
            this.label18.TabIndex = 2;
            this.label18.Text = "=";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(313, 84);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(14, 16);
            this.label11.TabIndex = 2;
            this.label11.Text = "=";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(203, 54);
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
            this.label13.Text = "Total hire";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(203, 84);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(15, 16);
            this.label10.TabIndex = 2;
            this.label10.Text = "X";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(19, 54);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(97, 16);
            this.label15.TabIndex = 0;
            this.label15.Text = "Waiting charge";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(313, 24);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(14, 16);
            this.label9.TabIndex = 2;
            this.label9.Text = "=";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(19, 84);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "Extra Km charge";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(19, 24);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(109, 16);
            this.label19.TabIndex = 0;
            this.label19.Text = "Base hire charge";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Maximum Km Limit";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(197, 18);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(58, 13);
            this.label21.TabIndex = 15;
            this.label21.Text = "Max Hours";
            // 
            // maxKmLimitLabel
            // 
            this.maxKmLimitLabel.AutoSize = true;
            this.maxKmLimitLabel.Location = new System.Drawing.Point(136, 19);
            this.maxKmLimitLabel.Name = "maxKmLimitLabel";
            this.maxKmLimitLabel.Size = new System.Drawing.Size(29, 13);
            this.maxKmLimitLabel.TabIndex = 16;
            this.maxKmLimitLabel.Text = "label";
            // 
            // maxHoursLabel
            // 
            this.maxHoursLabel.AutoSize = true;
            this.maxHoursLabel.Location = new System.Drawing.Point(307, 18);
            this.maxHoursLabel.Name = "maxHoursLabel";
            this.maxHoursLabel.Size = new System.Drawing.Size(29, 13);
            this.maxHoursLabel.TabIndex = 16;
            this.maxHoursLabel.Text = "label";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(116, 18);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(14, 16);
            this.label23.TabIndex = 2;
            this.label23.Text = "=";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(281, 17);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(14, 16);
            this.label24.TabIndex = 2;
            this.label24.Text = "=";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label28);
            this.panel2.Controls.Add(this.label21);
            this.panel2.Controls.Add(this.tourDurationLabel);
            this.panel2.Controls.Add(this.maxHoursLabel);
            this.panel2.Controls.Add(this.label31);
            this.panel2.Controls.Add(this.label23);
            this.panel2.Controls.Add(this.label25);
            this.panel2.Controls.Add(this.distanceTravelledLabel);
            this.panel2.Controls.Add(this.maxKmLimitLabel);
            this.panel2.Controls.Add(this.label29);
            this.panel2.Controls.Add(this.label24);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Location = new System.Drawing.Point(383, 30);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(405, 100);
            this.panel2.TabIndex = 17;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(197, 67);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(70, 13);
            this.label28.TabIndex = 15;
            this.label28.Text = "Tour duration";
            // 
            // tourDurationLabel
            // 
            this.tourDurationLabel.AutoSize = true;
            this.tourDurationLabel.Location = new System.Drawing.Point(307, 67);
            this.tourDurationLabel.Name = "tourDurationLabel";
            this.tourDurationLabel.Size = new System.Drawing.Size(29, 13);
            this.tourDurationLabel.TabIndex = 16;
            this.tourDurationLabel.Text = "label";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.Location = new System.Drawing.Point(116, 67);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(14, 16);
            this.label31.TabIndex = 2;
            this.label31.Text = "=";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(281, 66);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(14, 16);
            this.label25.TabIndex = 2;
            this.label25.Text = "=";
            // 
            // distanceTravelledLabel
            // 
            this.distanceTravelledLabel.AutoSize = true;
            this.distanceTravelledLabel.Location = new System.Drawing.Point(136, 68);
            this.distanceTravelledLabel.Name = "distanceTravelledLabel";
            this.distanceTravelledLabel.Size = new System.Drawing.Size(29, 13);
            this.distanceTravelledLabel.TabIndex = 16;
            this.distanceTravelledLabel.Text = "label";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(18, 68);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(92, 13);
            this.label29.TabIndex = 15;
            this.label29.Text = "Distance travelled";
            // 
            // DayTourHireCalculationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.endKmReadingTxt);
            this.Controls.Add(this.startKmReadingTxt);
            this.Controls.Add(this.endTimeDtp);
            this.Controls.Add(this.startTimeDtp);
            this.Controls.Add(this.vehicleNoTxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.packageTypeCombo);
            this.Controls.Add(this.calculateBtn);
            this.Name = "DayTourHireCalculationForm";
            this.Text = "DayTourHireCalculationForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button calculateBtn;
        private System.Windows.Forms.ComboBox packageTypeCombo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox vehicleNoTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker startTimeDtp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox startKmReadingTxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox endKmReadingTxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker endTimeDtp;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label totalHireLabel;
        private System.Windows.Forms.Label waitingChargeLabel;
        private System.Windows.Forms.Label waitingChargeRateLabel;
        private System.Windows.Forms.Label extraKmChargeLabel;
        private System.Windows.Forms.Label extraKmChargeRateLabel;
        private System.Windows.Forms.Label extraHoursLabel;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label baseHireChargeLabel;
        private System.Windows.Forms.Label extraKmsLabel;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label maxKmLimitLabel;
        private System.Windows.Forms.Label maxHoursLabel;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label tourDurationLabel;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label distanceTravelledLabel;
        private System.Windows.Forms.Label label29;
    }
}