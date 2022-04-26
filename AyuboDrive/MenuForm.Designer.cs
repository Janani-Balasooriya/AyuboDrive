namespace AyuboDrive
{
    partial class MenuForm
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
            this.vehicleBtn = new System.Windows.Forms.Button();
            this.vehicleTypeBtn = new System.Windows.Forms.Button();
            this.rentCalculationBtn = new System.Windows.Forms.Button();
            this.dayTourHireBtn = new System.Windows.Forms.Button();
            this.longTourHireBtn = new System.Windows.Forms.Button();
            this.packageDetailsBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // vehicleBtn
            // 
            this.vehicleBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vehicleBtn.Location = new System.Drawing.Point(94, 80);
            this.vehicleBtn.Name = "vehicleBtn";
            this.vehicleBtn.Size = new System.Drawing.Size(164, 56);
            this.vehicleBtn.TabIndex = 0;
            this.vehicleBtn.Text = "Vehicle Details";
            this.vehicleBtn.UseVisualStyleBackColor = true;
            this.vehicleBtn.Click += new System.EventHandler(this.vehicleBtn_Click);
            // 
            // vehicleTypeBtn
            // 
            this.vehicleTypeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vehicleTypeBtn.Location = new System.Drawing.Point(301, 80);
            this.vehicleTypeBtn.Name = "vehicleTypeBtn";
            this.vehicleTypeBtn.Size = new System.Drawing.Size(164, 56);
            this.vehicleTypeBtn.TabIndex = 0;
            this.vehicleTypeBtn.Text = "Vehicle Type Details";
            this.vehicleTypeBtn.UseVisualStyleBackColor = true;
            this.vehicleTypeBtn.Click += new System.EventHandler(this.vehicleTypeBtn_Click);
            // 
            // rentCalculationBtn
            // 
            this.rentCalculationBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rentCalculationBtn.Location = new System.Drawing.Point(94, 259);
            this.rentCalculationBtn.Name = "rentCalculationBtn";
            this.rentCalculationBtn.Size = new System.Drawing.Size(164, 56);
            this.rentCalculationBtn.TabIndex = 0;
            this.rentCalculationBtn.Text = "Rent Calculation";
            this.rentCalculationBtn.UseVisualStyleBackColor = true;
            this.rentCalculationBtn.Click += new System.EventHandler(this.rentCalculationBtn_Click);
            // 
            // dayTourHireBtn
            // 
            this.dayTourHireBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dayTourHireBtn.Location = new System.Drawing.Point(301, 259);
            this.dayTourHireBtn.Name = "dayTourHireBtn";
            this.dayTourHireBtn.Size = new System.Drawing.Size(164, 56);
            this.dayTourHireBtn.TabIndex = 0;
            this.dayTourHireBtn.Text = "Day Tour Hire Calculation";
            this.dayTourHireBtn.UseVisualStyleBackColor = true;
            this.dayTourHireBtn.Click += new System.EventHandler(this.dayTourHireBtn_Click);
            // 
            // longTourHireBtn
            // 
            this.longTourHireBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.longTourHireBtn.Location = new System.Drawing.Point(504, 259);
            this.longTourHireBtn.Name = "longTourHireBtn";
            this.longTourHireBtn.Size = new System.Drawing.Size(164, 56);
            this.longTourHireBtn.TabIndex = 0;
            this.longTourHireBtn.Text = "Long Tour Hire Calculation";
            this.longTourHireBtn.UseVisualStyleBackColor = true;
            this.longTourHireBtn.Click += new System.EventHandler(this.longTourHireBtn_Click);
            // 
            // packageDetailsBtn
            // 
            this.packageDetailsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.packageDetailsBtn.Location = new System.Drawing.Point(504, 80);
            this.packageDetailsBtn.Name = "packageDetailsBtn";
            this.packageDetailsBtn.Size = new System.Drawing.Size(164, 56);
            this.packageDetailsBtn.TabIndex = 0;
            this.packageDetailsBtn.Text = "Package Details";
            this.packageDetailsBtn.UseVisualStyleBackColor = true;
            this.packageDetailsBtn.Click += new System.EventHandler(this.packageDetailsBtn_Click);
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.longTourHireBtn);
            this.Controls.Add(this.dayTourHireBtn);
            this.Controls.Add(this.rentCalculationBtn);
            this.Controls.Add(this.packageDetailsBtn);
            this.Controls.Add(this.vehicleTypeBtn);
            this.Controls.Add(this.vehicleBtn);
            this.Name = "MenuForm";
            this.Text = "MenuForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button vehicleBtn;
        private System.Windows.Forms.Button vehicleTypeBtn;
        private System.Windows.Forms.Button rentCalculationBtn;
        private System.Windows.Forms.Button dayTourHireBtn;
        private System.Windows.Forms.Button longTourHireBtn;
        private System.Windows.Forms.Button packageDetailsBtn;
    }
}