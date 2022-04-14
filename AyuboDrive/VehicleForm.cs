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
    public partial class VehicleForm : Form
    {
        static string connectionStr = "Data Source=DESKTOP-GA6UOAH\\SQLEXPRESS;" +
            "Initial Catalog=AyuboDrive; Integrated Security=true;";
        SqlConnection cnn = new SqlConnection(connectionStr);
        public VehicleForm()
        {
            InitializeComponent();
            loadVehicleTypeCombo();
        }

        private void loadVehicleTypeCombo()
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * from VehicleType", cnn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                
                vehicleTypeCombo.DisplayMember = "name";
                vehicleTypeCombo.ValueMember = "idType";
                vehicleTypeCombo.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ClearForm()
        {
            vehicleIDTxt.Text = "";
            vehicleNameTxt.Text = "";
            monthlyRateTxt.Text = "";
            weeklyRateTxt.Text = "";
            dailyRateTxt.Text = "";
            driverRateTxt.Text = "";
            vehicleTypeCombo.ResetText();


        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                cnn.Open();
                SqlCommand cmd = new SqlCommand("insert into vehicle values (@vid, @name," +
                    " @monthlyrate, @weeklyrate,@dailyrate,@driverrateperday, @vehicletype)", cnn);
                cmd.Parameters.AddWithValue("vid", vehicleIDTxt.Text);
                cmd.Parameters.AddWithValue("name", vehicleNameTxt.Text);
                cmd.Parameters.AddWithValue("monthlyrate", monthlyRateTxt.Text);
                cmd.Parameters.AddWithValue("weeklyrate", weeklyRateTxt.Text);
                cmd.Parameters.AddWithValue("dailyrate", dailyRateTxt.Text);
                cmd.Parameters.AddWithValue("driverrateperday", driverRateTxt.Text);
                cmd.Parameters.AddWithValue("vehicletype", vehicleTypeCombo.SelectedValue);
                cmd.ExecuteNonQuery();
                MessageBox.Show("new record added", "database update",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearForm();
                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var vehicleTypeForm= new VehicleTypeForm();
            vehicleTypeForm.Show();
        }

    }
}
