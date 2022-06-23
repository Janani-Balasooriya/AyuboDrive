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
    public partial class VehicleForm : MaterialForm
    {
        static string connectionStr = "Data Source=DESKTOP-GA6UOAH\\SQLEXPRESS;" +
            "Initial Catalog=AyuboDrive; Integrated Security=true;";
        SqlConnection cnn = new SqlConnection(connectionStr);
        public VehicleForm()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800,
                Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
            LoadVehicleTypeCombo();
            LoadVehicleIDValuesToComboBox();
        }

        private void LoadVehicleTypeCombo()
        {
            try
            {
                cnn.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT * from VehicleType", cnn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                
                vehicleTypeCombo.DisplayMember = "name";
                vehicleTypeCombo.ValueMember = "idType";
                vehicleTypeCombo.DataSource = dt;
                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                cnn.Close();
            }
        }

        private void ClearForm()
        {
            //vehicleNoComboTxt.Text = "";
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
                cmd.Parameters.AddWithValue("vid", vehicleNoComboTxt.Text);
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
                LoadVehicleIDValuesToComboBox();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                cnn.Close();
            }
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                cnn.Open();
                SqlCommand cmd = new SqlCommand("UPDATE vehicle SET name=@name, " +
                    "monthlyRate=@monthlyrate, weeklyRate=@weeklyrate, " +
                    "dailyRate=@dailyrate, driverRatePerDay=@driverrateperday, " +
                    "idVehicleType=@vehicletype WHERE idvehicle = @vid;", cnn);
                cmd.Parameters.AddWithValue("vid", vehicleNoComboTxt.Text);
                cmd.Parameters.AddWithValue("name", vehicleNameTxt.Text);
                cmd.Parameters.AddWithValue("monthlyrate", monthlyRateTxt.Text);
                cmd.Parameters.AddWithValue("weeklyrate", weeklyRateTxt.Text);
                cmd.Parameters.AddWithValue("dailyrate", dailyRateTxt.Text);
                cmd.Parameters.AddWithValue("driverrateperday", driverRateTxt.Text);
                cmd.Parameters.AddWithValue("vehicletype", vehicleTypeCombo.SelectedValue);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record updated!", "Database Update",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearForm();
                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LoadVehicle()
        {
            try
            {
                if (cnn.State == ConnectionState.Open)
                {
                    cnn.Close();
                }
                cnn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Vehicle WHERE idvehicle=@vid", cnn);
                cmd.Parameters.AddWithValue("vid", vehicleNoComboTxt.Text);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    vehicleNameTxt.Text = dr[1].ToString();
                    monthlyRateTxt.Text = dr[2].ToString();
                    weeklyRateTxt.Text = dr[3].ToString();
                    dailyRateTxt.Text = dr[4].ToString();
                    driverRateTxt.Text = dr[5].ToString();
                    vehicleTypeCombo.SelectedValue = dr[6].ToString();
                    saveBtn.Enabled = false;
                    updateBtn.Enabled = true;
                    deleteBtn.Enabled= true;
                }
                else
                {
                    MessageBox.Show("Vehicle NOT Found");
                    saveBtn.Enabled = true;
                    updateBtn.Enabled = false;
                    deleteBtn.Enabled = false;
                    ClearForm();
                }
                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                cnn.Close();
            }
        }

        private void LoadVehicleIDValuesToComboBox()
        {
            try
            {
                cnn.Open();
                SqlDataAdapter da = new SqlDataAdapter
                    ("select idvehicle FROM Vehicle;", cnn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                vehicleNoComboTxt.DataSource = dt;
                vehicleNoComboTxt.DisplayMember = "idvehicle";
                vehicleNoComboTxt.ValueMember = "idvehicle";
                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                cnn.Close();
            }
        }


        private void VehicleNoComboTxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                LoadVehicle();
            }
        }

        private void vehicleNoComboTxt_Leave(object sender, EventArgs e)
        {
            LoadVehicle();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            new SearchVehicleForm().ShowDialog();
            this.Close();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                cnn.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM Vehicle WHERE idvehicle = @vid;", cnn);
                cmd.Parameters.AddWithValue("vid", vehicleNoComboTxt.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record deleted!", "Database Update",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearForm();
                cnn.Close();
                LoadVehicleIDValuesToComboBox();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                cnn.Close();
            }
        }

        private void VehicleNoComboTxt_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadVehicle();
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            ClearForm();
            vehicleNoComboTxt.Text = "";
        }
    }
}
