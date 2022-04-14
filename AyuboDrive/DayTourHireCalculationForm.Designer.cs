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
            this.vehicleTypeCombo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.vehicleNoTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.startTimeDtp = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.endTimeDtp = new System.Windows.Forms.DateTimePicker();
            this.startKmReadingTxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.endKmReadingTxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // calculateBtn
            // 
            this.calculateBtn.Location = new System.Drawing.Point(515, 311);
            this.calculateBtn.Name = "calculateBtn";
            this.calculateBtn.Size = new System.Drawing.Size(75, 23);
            this.calculateBtn.TabIndex = 0;
            this.calculateBtn.Text = "Calculate";
            this.calculateBtn.UseVisualStyleBackColor = true;
            this.calculateBtn.Click += new System.EventHandler(this.calculateBtn_Click);
            // 
            // vehicleTypeCombo
            // 
            this.vehicleTypeCombo.FormattingEnabled = true;
            this.vehicleTypeCombo.Location = new System.Drawing.Point(129, 72);
            this.vehicleTypeCombo.Name = "vehicleTypeCombo";
            this.vehicleTypeCombo.Size = new System.Drawing.Size(121, 21);
            this.vehicleTypeCombo.TabIndex = 1;
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
            this.startTimeDtp.Location = new System.Drawing.Point(129, 117);
            this.startTimeDtp.Name = "startTimeDtp";
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
            // endTimeDtp
            // 
            this.endTimeDtp.Location = new System.Drawing.Point(129, 157);
            this.endTimeDtp.Name = "endTimeDtp";
            this.endTimeDtp.Size = new System.Drawing.Size(200, 20);
            this.endTimeDtp.TabIndex = 4;
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
            // DayTourHireCalculationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
            this.Controls.Add(this.vehicleTypeCombo);
            this.Controls.Add(this.calculateBtn);
            this.Name = "DayTourHireCalculationForm";
            this.Text = "DayTourHireCalculationForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button calculateBtn;
        private System.Windows.Forms.ComboBox vehicleTypeCombo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox vehicleNoTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker startTimeDtp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker endTimeDtp;
        private System.Windows.Forms.TextBox startKmReadingTxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox endKmReadingTxt;
        private System.Windows.Forms.Label label6;
    }
}