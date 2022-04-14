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

namespace AyuboDrive
{
    public partial class VehicleTypeForm : Form
    {
        static string connectionStr = "Data Source=DESKTOP-GA6UOAH\\SQLEXPRESS;" +
            "Initial Catalog=AyuboDrive; Integrated Security=true;";
        SqlConnection cnn = new SqlConnection(connectionStr);
        public VehicleTypeForm()
        {
            InitializeComponent();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            saveVehicleType();
        }

        private void saveVehicleType()
        {
            try
            {
                cnn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO VehicleType VALUES (@vid, @Name)", cnn);
                cmd.Parameters.AddWithValue("vid", vehicleIDTxt.Text);
                cmd.Parameters.AddWithValue("Name", vehicleNameTxt.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("New Vehicle Type Added", "Database Update",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                clearForm();
                cnn.Close();
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void clearForm()
        {
            vehicleIDTxt.Text = "";
            vehicleNameTxt.Text = "";
        }
    }
}
