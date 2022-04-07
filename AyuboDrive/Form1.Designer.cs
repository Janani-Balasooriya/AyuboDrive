namespace AyuboDrive
{
    partial class Form1
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.withoutDriverRadioBtn = new System.Windows.Forms.RadioButton();
            this.withDriverRadioBtn = new System.Windows.Forms.RadioButton();
            this.vehicleNoTxt = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // calculateBtn
            // 
            this.calculateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculateBtn.Location = new System.Drawing.Point(51, 327);
            this.calculateBtn.Name = "calculateBtn";
            this.calculateBtn.Size = new System.Drawing.Size(94, 34);
            this.calculateBtn.TabIndex = 0;
            this.calculateBtn.Text = "Calculate";
            this.calculateBtn.UseVisualStyleBackColor = true;
            this.calculateBtn.Click += new System.EventHandler(this.calculateBtn_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(133, 110);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 1;
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
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(133, 150);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 7;
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
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.vehicleNoTxt);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.calculateBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button calculateBtn;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton withoutDriverRadioBtn;
        private System.Windows.Forms.RadioButton withDriverRadioBtn;
        private System.Windows.Forms.TextBox vehicleNoTxt;
    }
}

