namespace AyuboDrive
{
    partial class VehicleForm
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
            this.vehicleIDTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.vehicleNameTxt = new System.Windows.Forms.TextBox();
            this.monthlyRateTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.weeklyRateTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dailyRateTxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.driverRateTxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.saveBtn = new System.Windows.Forms.Button();
            this.vehicleTypeCombo = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // vehicleIDTxt
            // 
            this.vehicleIDTxt.Location = new System.Drawing.Point(125, 53);
            this.vehicleIDTxt.Name = "vehicleIDTxt";
            this.vehicleIDTxt.Size = new System.Drawing.Size(100, 20);
            this.vehicleIDTxt.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Vehicle ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Vehicle Name";
            // 
            // vehicleNameTxt
            // 
            this.vehicleNameTxt.Location = new System.Drawing.Point(125, 79);
            this.vehicleNameTxt.Name = "vehicleNameTxt";
            this.vehicleNameTxt.Size = new System.Drawing.Size(100, 20);
            this.vehicleNameTxt.TabIndex = 2;
            // 
            // monthlyRateTxt
            // 
            this.monthlyRateTxt.Location = new System.Drawing.Point(125, 105);
            this.monthlyRateTxt.Name = "monthlyRateTxt";
            this.monthlyRateTxt.Size = new System.Drawing.Size(100, 20);
            this.monthlyRateTxt.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Monthly Rate";
            // 
            // weeklyRateTxt
            // 
            this.weeklyRateTxt.Location = new System.Drawing.Point(125, 131);
            this.weeklyRateTxt.Name = "weeklyRateTxt";
            this.weeklyRateTxt.Size = new System.Drawing.Size(100, 20);
            this.weeklyRateTxt.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Weekly Rate";
            // 
            // dailyRateTxt
            // 
            this.dailyRateTxt.Location = new System.Drawing.Point(125, 157);
            this.dailyRateTxt.Name = "dailyRateTxt";
            this.dailyRateTxt.Size = new System.Drawing.Size(100, 20);
            this.dailyRateTxt.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Daily Rate";
            // 
            // driverRateTxt
            // 
            this.driverRateTxt.Location = new System.Drawing.Point(125, 183);
            this.driverRateTxt.Name = "driverRateTxt";
            this.driverRateTxt.Size = new System.Drawing.Size(100, 20);
            this.driverRateTxt.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(45, 186);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Driver Rate";
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(573, 266);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(75, 23);
            this.saveBtn.TabIndex = 4;
            this.saveBtn.Text = "save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // vehicleTypeCombo
            // 
            this.vehicleTypeCombo.FormattingEnabled = true;
            this.vehicleTypeCombo.Location = new System.Drawing.Point(406, 51);
            this.vehicleTypeCombo.Name = "vehicleTypeCombo";
            this.vehicleTypeCombo.Size = new System.Drawing.Size(242, 21);
            this.vehicleTypeCombo.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(314, 56);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Vehicle Type";
            // 
            // VehicleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.vehicleIDTxt);
            this.Controls.Add(this.vehicleNameTxt);
            this.Controls.Add(this.monthlyRateTxt);
            this.Controls.Add(this.weeklyRateTxt);
            this.Controls.Add(this.dailyRateTxt);
            this.Controls.Add(this.driverRateTxt);
            this.Controls.Add(this.vehicleTypeCombo);
            this.Controls.Add(this.saveBtn);
            this.Name = "VehicleForm";
            this.Text = "VehicleRegistrationForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox vehicleIDTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox vehicleNameTxt;
        private System.Windows.Forms.TextBox monthlyRateTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox weeklyRateTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox dailyRateTxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox driverRateTxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.ComboBox vehicleTypeCombo;
        private System.Windows.Forms.Label label7;
    }
}