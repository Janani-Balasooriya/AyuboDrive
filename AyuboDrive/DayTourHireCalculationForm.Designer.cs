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
            this.startTimeDtp = new System.Windows.Forms.DateTimePicker();
            this.startKmReadingTxt = new System.Windows.Forms.TextBox();
            this.endKmReadingTxt = new System.Windows.Forms.TextBox();
            this.endTimeDtp = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.materialCard2 = new MaterialSkin.Controls.MaterialCard();
            this.totalHireLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.materialDivider2 = new MaterialSkin.Controls.MaterialDivider();
            this.waitingChargeLabel = new System.Windows.Forms.Label();
            this.waitingChargeRateLabel = new System.Windows.Forms.Label();
            this.extraKmChargeLabel = new System.Windows.Forms.Label();
            this.extraKmChargeRateLabel = new System.Windows.Forms.Label();
            this.extraHoursLabel = new System.Windows.Forms.Label();
            this.baseHireChargeLabel = new System.Windows.Forms.Label();
            this.extraKmsLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.maxKmLimitLabel = new System.Windows.Forms.Label();
            this.maxHoursLabel = new System.Windows.Forms.Label();
            this.distanceTravelledLabel = new System.Windows.Forms.Label();
            this.tourDurationLabel = new System.Windows.Forms.Label();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.vehicleNoComboTxt = new System.Windows.Forms.ComboBox();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.calculateBtn = new MaterialSkin.Controls.MaterialButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.panel2 = new System.Windows.Forms.Panel();
            this.HomeBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.materialCard2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.materialCard1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // startTimeDtp
            // 
            this.startTimeDtp.CustomFormat = "HH:mm:ss";
            this.startTimeDtp.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.startTimeDtp.Location = new System.Drawing.Point(40, 175);
            this.startTimeDtp.Name = "startTimeDtp";
            this.startTimeDtp.ShowUpDown = true;
            this.startTimeDtp.Size = new System.Drawing.Size(121, 20);
            this.startTimeDtp.TabIndex = 4;
            this.startTimeDtp.TabStop = false;
            // 
            // startKmReadingTxt
            // 
            this.startKmReadingTxt.Location = new System.Drawing.Point(41, 238);
            this.startKmReadingTxt.Name = "startKmReadingTxt";
            this.startKmReadingTxt.Size = new System.Drawing.Size(124, 20);
            this.startKmReadingTxt.TabIndex = 5;
            this.startKmReadingTxt.TabStop = false;
            // 
            // endKmReadingTxt
            // 
            this.endKmReadingTxt.Location = new System.Drawing.Point(190, 238);
            this.endKmReadingTxt.Name = "endKmReadingTxt";
            this.endKmReadingTxt.Size = new System.Drawing.Size(115, 20);
            this.endKmReadingTxt.TabIndex = 5;
            this.endKmReadingTxt.TabStop = false;
            // 
            // endTimeDtp
            // 
            this.endTimeDtp.CustomFormat = "HH:mm:ss";
            this.endTimeDtp.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.endTimeDtp.Location = new System.Drawing.Point(190, 175);
            this.endTimeDtp.Name = "endTimeDtp";
            this.endTimeDtp.ShowUpDown = true;
            this.endTimeDtp.Size = new System.Drawing.Size(121, 20);
            this.endTimeDtp.TabIndex = 4;
            this.endTimeDtp.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.materialCard2);
            this.panel1.Controls.Add(this.materialDivider2);
            this.panel1.Controls.Add(this.waitingChargeLabel);
            this.panel1.Controls.Add(this.waitingChargeRateLabel);
            this.panel1.Controls.Add(this.extraKmChargeLabel);
            this.panel1.Controls.Add(this.extraKmChargeRateLabel);
            this.panel1.Controls.Add(this.extraHoursLabel);
            this.panel1.Controls.Add(this.baseHireChargeLabel);
            this.panel1.Controls.Add(this.extraKmsLabel);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label27);
            this.panel1.Controls.Add(this.label18);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label19);
            this.panel1.Location = new System.Drawing.Point(39, 328);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(569, 166);
            this.panel1.TabIndex = 14;
            this.panel1.Visible = false;
            // 
            // materialCard2
            // 
            this.materialCard2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard2.Controls.Add(this.totalHireLabel);
            this.materialCard2.Controls.Add(this.label1);
            this.materialCard2.Controls.Add(this.label2);
            this.materialCard2.Depth = 0;
            this.materialCard2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard2.Location = new System.Drawing.Point(11, 104);
            this.materialCard2.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard2.Name = "materialCard2";
            this.materialCard2.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard2.Size = new System.Drawing.Size(544, 40);
            this.materialCard2.TabIndex = 21;
            // 
            // totalHireLabel
            // 
            this.totalHireLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalHireLabel.Location = new System.Drawing.Point(457, 10);
            this.totalHireLabel.Name = "totalHireLabel";
            this.totalHireLabel.Size = new System.Drawing.Size(70, 16);
            this.totalHireLabel.TabIndex = 5;
            this.totalHireLabel.Text = "label6";
            this.totalHireLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Total hire";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(117, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "=";
            // 
            // materialDivider2
            // 
            this.materialDivider2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider2.Depth = 0;
            this.materialDivider2.Location = new System.Drawing.Point(438, 9);
            this.materialDivider2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider2.Name = "materialDivider2";
            this.materialDivider2.Size = new System.Drawing.Size(10, 128);
            this.materialDivider2.TabIndex = 19;
            this.materialDivider2.Text = "materialDivider1";
            // 
            // waitingChargeLabel
            // 
            this.waitingChargeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.waitingChargeLabel.Location = new System.Drawing.Point(468, 44);
            this.waitingChargeLabel.Name = "waitingChargeLabel";
            this.waitingChargeLabel.Size = new System.Drawing.Size(70, 16);
            this.waitingChargeLabel.TabIndex = 5;
            this.waitingChargeLabel.Text = "label6";
            this.waitingChargeLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // waitingChargeRateLabel
            // 
            this.waitingChargeRateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.waitingChargeRateLabel.Location = new System.Drawing.Point(321, 44);
            this.waitingChargeRateLabel.Name = "waitingChargeRateLabel";
            this.waitingChargeRateLabel.Size = new System.Drawing.Size(70, 16);
            this.waitingChargeRateLabel.TabIndex = 4;
            this.waitingChargeRateLabel.Text = "label6";
            this.waitingChargeRateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // extraKmChargeLabel
            // 
            this.extraKmChargeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.extraKmChargeLabel.Location = new System.Drawing.Point(468, 74);
            this.extraKmChargeLabel.Name = "extraKmChargeLabel";
            this.extraKmChargeLabel.Size = new System.Drawing.Size(70, 16);
            this.extraKmChargeLabel.TabIndex = 5;
            this.extraKmChargeLabel.Text = "label6";
            this.extraKmChargeLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // extraKmChargeRateLabel
            // 
            this.extraKmChargeRateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.extraKmChargeRateLabel.Location = new System.Drawing.Point(321, 74);
            this.extraKmChargeRateLabel.Name = "extraKmChargeRateLabel";
            this.extraKmChargeRateLabel.Size = new System.Drawing.Size(70, 16);
            this.extraKmChargeRateLabel.TabIndex = 4;
            this.extraKmChargeRateLabel.Text = "label6";
            this.extraKmChargeRateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // extraHoursLabel
            // 
            this.extraHoursLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.extraHoursLabel.Location = new System.Drawing.Point(195, 44);
            this.extraHoursLabel.Name = "extraHoursLabel";
            this.extraHoursLabel.Size = new System.Drawing.Size(70, 16);
            this.extraHoursLabel.TabIndex = 3;
            this.extraHoursLabel.Text = "label6";
            this.extraHoursLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // baseHireChargeLabel
            // 
            this.baseHireChargeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.baseHireChargeLabel.Location = new System.Drawing.Point(468, 14);
            this.baseHireChargeLabel.Name = "baseHireChargeLabel";
            this.baseHireChargeLabel.Size = new System.Drawing.Size(70, 16);
            this.baseHireChargeLabel.TabIndex = 5;
            this.baseHireChargeLabel.Text = "label6";
            this.baseHireChargeLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // extraKmsLabel
            // 
            this.extraKmsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.extraKmsLabel.Location = new System.Drawing.Point(195, 74);
            this.extraKmsLabel.Name = "extraKmsLabel";
            this.extraKmsLabel.Size = new System.Drawing.Size(70, 16);
            this.extraKmsLabel.TabIndex = 3;
            this.extraKmsLabel.Text = "label6";
            this.extraKmsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(128, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "=";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(128, 44);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(14, 16);
            this.label27.TabIndex = 2;
            this.label27.Text = "=";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(128, 74);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(14, 16);
            this.label18.TabIndex = 2;
            this.label18.Text = "=";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(296, 44);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(15, 16);
            this.label16.TabIndex = 2;
            this.label16.Text = "X";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(296, 74);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(15, 16);
            this.label10.TabIndex = 2;
            this.label10.Text = "X";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(16, 44);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(97, 16);
            this.label15.TabIndex = 0;
            this.label15.Text = "Waiting charge";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(16, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "Extra Km charge";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(16, 14);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(109, 16);
            this.label19.TabIndex = 0;
            this.label19.Text = "Base hire charge";
            // 
            // maxKmLimitLabel
            // 
            this.maxKmLimitLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxKmLimitLabel.Location = new System.Drawing.Point(20, 23);
            this.maxKmLimitLabel.Name = "maxKmLimitLabel";
            this.maxKmLimitLabel.Size = new System.Drawing.Size(79, 20);
            this.maxKmLimitLabel.TabIndex = 16;
            this.maxKmLimitLabel.Text = "label";
            this.maxKmLimitLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // maxHoursLabel
            // 
            this.maxHoursLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxHoursLabel.Location = new System.Drawing.Point(20, 24);
            this.maxHoursLabel.Name = "maxHoursLabel";
            this.maxHoursLabel.Size = new System.Drawing.Size(79, 20);
            this.maxHoursLabel.TabIndex = 16;
            this.maxHoursLabel.Text = "label";
            this.maxHoursLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // distanceTravelledLabel
            // 
            this.distanceTravelledLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.distanceTravelledLabel.Location = new System.Drawing.Point(18, 23);
            this.distanceTravelledLabel.Name = "distanceTravelledLabel";
            this.distanceTravelledLabel.Size = new System.Drawing.Size(79, 20);
            this.distanceTravelledLabel.TabIndex = 16;
            this.distanceTravelledLabel.Text = "label";
            this.distanceTravelledLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tourDurationLabel
            // 
            this.tourDurationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tourDurationLabel.Location = new System.Drawing.Point(17, 22);
            this.tourDurationLabel.Name = "tourDurationLabel";
            this.tourDurationLabel.Size = new System.Drawing.Size(94, 20);
            this.tourDurationLabel.TabIndex = 16;
            this.tourDurationLabel.Text = "label";
            this.tourDurationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(38, 77);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(112, 19);
            this.materialLabel1.TabIndex = 19;
            this.materialLabel1.Text = "Vehicle Number";
            // 
            // vehicleNoComboTxt
            // 
            this.vehicleNoComboTxt.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.vehicleNoComboTxt.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.vehicleNoComboTxt.FormattingEnabled = true;
            this.vehicleNoComboTxt.Items.AddRange(new object[] {
            ""});
            this.vehicleNoComboTxt.Location = new System.Drawing.Point(39, 108);
            this.vehicleNoComboTxt.Name = "vehicleNoComboTxt";
            this.vehicleNoComboTxt.Size = new System.Drawing.Size(237, 21);
            this.vehicleNoComboTxt.TabIndex = 18;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(40, 153);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(75, 19);
            this.materialLabel2.TabIndex = 19;
            this.materialLabel2.Text = "Start Time";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(189, 153);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(68, 19);
            this.materialLabel3.TabIndex = 19;
            this.materialLabel3.Text = "End Time";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.Location = new System.Drawing.Point(40, 216);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(125, 19);
            this.materialLabel4.TabIndex = 19;
            this.materialLabel4.Text = "Start Km Reading";
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel5.Location = new System.Drawing.Point(189, 216);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(118, 19);
            this.materialLabel5.TabIndex = 19;
            this.materialLabel5.Text = "End Km Reading";
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
            this.calculateBtn.Location = new System.Drawing.Point(38, 279);
            this.calculateBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.calculateBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.calculateBtn.Name = "calculateBtn";
            this.calculateBtn.Size = new System.Drawing.Size(570, 44);
            this.calculateBtn.TabIndex = 21;
            this.calculateBtn.TabStop = false;
            this.calculateBtn.Text = "Calculate Hire";
            this.calculateBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.calculateBtn.UseAccentColor = false;
            this.calculateBtn.UseVisualStyleBackColor = true;
            this.calculateBtn.Click += new System.EventHandler(this.calculateBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.maxHoursLabel);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(9, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(112, 54);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Max hours";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tourDurationLabel);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(9, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(131, 54);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tour Duration";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.maxKmLimitLabel);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(9, 84);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(112, 54);
            this.groupBox3.TabIndex = 22;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Max Km Limit";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.distanceTravelledLabel);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(9, 79);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(131, 54);
            this.groupBox4.TabIndex = 22;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Tour Distance";
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.groupBox2);
            this.materialCard1.Controls.Add(this.groupBox4);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(125, 5);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(149, 143);
            this.materialCard1.TabIndex = 23;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.materialCard1);
            this.panel2.Controls.Add(this.groupBox3);
            this.panel2.Location = new System.Drawing.Point(338, 103);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(282, 155);
            this.panel2.TabIndex = 24;
            this.panel2.Visible = false;
            // 
            // HomeBtn
            // 
            this.HomeBtn.BackColor = System.Drawing.SystemColors.Control;
            this.HomeBtn.BackgroundImage = global::AyuboDrive.Properties.Resources.home_icon_silhouette;
            this.HomeBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.HomeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HomeBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.HomeBtn.Location = new System.Drawing.Point(510, 27);
            this.HomeBtn.Name = "HomeBtn";
            this.HomeBtn.Size = new System.Drawing.Size(36, 34);
            this.HomeBtn.TabIndex = 44;
            this.HomeBtn.TabStop = false;
            this.HomeBtn.UseVisualStyleBackColor = false;
            this.HomeBtn.Click += new System.EventHandler(this.HomeBtn_Click);
            // 
            // DayTourHireCalculationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 506);
            this.Controls.Add(this.HomeBtn);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.calculateBtn);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel5);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.vehicleNoComboTxt);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.endKmReadingTxt);
            this.Controls.Add(this.startKmReadingTxt);
            this.Controls.Add(this.endTimeDtp);
            this.Controls.Add(this.startTimeDtp);
            this.Name = "DayTourHireCalculationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Day Tour Hire Calculation";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.materialCard2.ResumeLayout(false);
            this.materialCard2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.materialCard1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker startTimeDtp;
        private System.Windows.Forms.TextBox startKmReadingTxt;
        private System.Windows.Forms.TextBox endKmReadingTxt;
        private System.Windows.Forms.DateTimePicker endTimeDtp;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label totalHireLabel;
        private System.Windows.Forms.Label waitingChargeLabel;
        private System.Windows.Forms.Label waitingChargeRateLabel;
        private System.Windows.Forms.Label extraKmChargeLabel;
        private System.Windows.Forms.Label extraKmChargeRateLabel;
        private System.Windows.Forms.Label extraHoursLabel;
        private System.Windows.Forms.Label baseHireChargeLabel;
        private System.Windows.Forms.Label extraKmsLabel;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label maxKmLimitLabel;
        private System.Windows.Forms.Label maxHoursLabel;
        private System.Windows.Forms.Label tourDurationLabel;
        private System.Windows.Forms.Label distanceTravelledLabel;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.ComboBox vehicleNoComboTxt;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialDivider materialDivider2;
        private MaterialSkin.Controls.MaterialCard materialCard2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private MaterialSkin.Controls.MaterialButton calculateBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button HomeBtn;
    }
}