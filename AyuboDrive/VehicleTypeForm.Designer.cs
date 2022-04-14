namespace AyuboDrive
{
    partial class VehicleTypeForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.vehicleNameTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.vehicleIDTxt = new System.Windows.Forms.TextBox();
            this.saveBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Type Name";
            // 
            // vehicleNameTxt
            // 
            this.vehicleNameTxt.Location = new System.Drawing.Point(144, 67);
            this.vehicleNameTxt.Name = "vehicleNameTxt";
            this.vehicleNameTxt.Size = new System.Drawing.Size(100, 20);
            this.vehicleNameTxt.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Vehicle Type ID";
            // 
            // vehicleIDTxt
            // 
            this.vehicleIDTxt.Location = new System.Drawing.Point(144, 41);
            this.vehicleIDTxt.Name = "vehicleIDTxt";
            this.vehicleIDTxt.Size = new System.Drawing.Size(100, 20);
            this.vehicleIDTxt.TabIndex = 4;
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(144, 288);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(75, 23);
            this.saveBtn.TabIndex = 8;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // VehicleTypeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.vehicleNameTxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.vehicleIDTxt);
            this.Name = "VehicleTypeForm";
            this.Text = "VehicleType";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox vehicleNameTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox vehicleIDTxt;
        private System.Windows.Forms.Button saveBtn;
    }
}