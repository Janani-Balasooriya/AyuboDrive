using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace AyuboDrive
{
    public partial class LoginForm : MaterialForm
    {
        static string connectionStr = "Data Source=DESKTOP-GA6UOAH\\SQLEXPRESS;" +
            "Initial Catalog=AyuboDrive; Integrated Security=true;";
        SqlConnection cnn = new SqlConnection(connectionStr);
        public LoginForm()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, 
                Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string username = emailTextBox.Text;
            string password = passwordTextBox.Text;
            string userNameActual = "";
            string passwordLoginActual = "";

            try
            {
                cnn.Open();
                SqlCommand cmd = new SqlCommand
                    ("select email, password from Login;", cnn);
                SqlDataReader dr = cmd.ExecuteReader();
                
                if (dr.Read())
                {
                    userNameActual = dr[0].ToString();
                    passwordLoginActual = dr[1].ToString();
                }
                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                cnn.Close();
            }

            if((userNameActual == username)&&(passwordLoginActual == password))
            {
                this.Hide();
                new MenuForm().ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid Login!!");
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
