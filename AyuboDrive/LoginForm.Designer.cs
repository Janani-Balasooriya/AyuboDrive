namespace AyuboDrive
{
    partial class LoginForm
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
            this.loginButton = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.emailTextBox = new MaterialSkin.Controls.MaterialTextBox();
            this.passwordTextBox = new MaterialSkin.Controls.MaterialTextBox();
            this.SuspendLayout();
            // 
            // loginButton
            // 
            this.loginButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.loginButton.Depth = 0;
            this.loginButton.DrawShadows = true;
            this.loginButton.HighEmphasis = true;
            this.loginButton.Icon = null;
            this.loginButton.Location = new System.Drawing.Point(296, 273);
            this.loginButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.loginButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(64, 36);
            this.loginButton.TabIndex = 0;
            this.loginButton.Text = "Login";
            this.loginButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.loginButton.UseAccentColor = false;
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(68, 151);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(41, 19);
            this.materialLabel1.TabIndex = 1;
            this.materialLabel1.Text = "Email";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(68, 233);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(71, 19);
            this.materialLabel2.TabIndex = 1;
            this.materialLabel2.Text = "Password";
            // 
            // emailTextBox
            // 
            this.emailTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.emailTextBox.Depth = 0;
            this.emailTextBox.Font = new System.Drawing.Font("Roboto", 12F);
            this.emailTextBox.Hint = "Your Email here";
            this.emailTextBox.Location = new System.Drawing.Point(157, 139);
            this.emailTextBox.MaxLength = 50;
            this.emailTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.emailTextBox.Multiline = false;
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(203, 50);
            this.emailTextBox.TabIndex = 2;
            this.emailTextBox.Text = "";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passwordTextBox.Depth = 0;
            this.passwordTextBox.Font = new System.Drawing.Font("Roboto", 12F);
            this.passwordTextBox.Hint = "Enter Password here";
            this.passwordTextBox.Location = new System.Drawing.Point(157, 202);
            this.passwordTextBox.MaxLength = 50;
            this.passwordTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.passwordTextBox.Multiline = false;
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(203, 50);
            this.passwordTextBox.TabIndex = 2;
            this.passwordTextBox.Text = "";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 387);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.loginButton);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome to AYUBO DRIVE";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton loginButton;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialTextBox emailTextBox;
        private MaterialSkin.Controls.MaterialTextBox passwordTextBox;
    }
}