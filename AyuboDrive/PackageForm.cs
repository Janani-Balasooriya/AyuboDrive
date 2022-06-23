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
    public partial class PackageForm : MaterialForm
    {
        static string connectionStr = "Data Source=DESKTOP-GA6UOAH\\SQLEXPRESS;" +
            "Initial Catalog=AyuboDrive; Integrated Security=true;";
        SqlConnection cnn = new SqlConnection(connectionStr);
        public PackageForm()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800,
                Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
            LoadVehicleTypeCombo();
            LoadPackageIDValuesToComboBox();
            
        }

        private void PackageSaveBtn_Click(object sender, EventArgs e)
        {
            SavePackage();
        }

        
        private void SavePackage()
        {
            try
            {
                cnn.Open();
                SqlCommand cmd = new SqlCommand("insert into PackageDetail values " +
                    "(@pid, @name, @standardrate, @maxkm, @maxhours, @extrakmrate, @waitingcharge," +
                    " @driverovernightrate, @vehiclenightparkrate, @vehicletype)", cnn);
                cmd.Parameters.AddWithValue("pid", packageIDComboTxt.Text);
                cmd.Parameters.AddWithValue("name", packageNameTxt.Text);
                cmd.Parameters.AddWithValue("standardrate", standardRateTxt.Text);
                cmd.Parameters.AddWithValue("maxkm", maxKmTxt.Text);
                cmd.Parameters.AddWithValue("maxhours", maxHoursTxt.Text);
                cmd.Parameters.AddWithValue("extrakmrate", extraKmRateTxt.Text);
                cmd.Parameters.AddWithValue("waitingcharge", waitingChargeTxt.Text);
                cmd.Parameters.AddWithValue("driverovernightrate", overnightRateTxt.Text);
                cmd.Parameters.AddWithValue("vehiclenightparkrate", nightParkRateTxt.Text);
                cmd.Parameters.AddWithValue("vehicletype", vehicleTypeCombo.SelectedValue);
                cmd.ExecuteNonQuery();
                MessageBox.Show("New package added", "database update",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearForm();
                cnn.Close();
                LoadPackageIDValuesToComboBox();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Console.WriteLine(ex.StackTrace);
                cnn.Close();
            }
        }

        private void UpdatePackage()
        {
            try
            {
                cnn.Open();
                SqlCommand cmd = new SqlCommand("UPDATE PackageDetail SET " +
                    "name=@name, standardRate=@standardrate, maxKmLimit=@maxkm, maxHours=@maxhours, " +
                    "extraKmRate=@extrakmrate, waitingCharge=@waitingcharge, " +
                    "driverOvernightRate=@driverovernightrate, vehicleNightParkRate=@vehiclenightparkrate," +
                    " idVehicleType=@vehicletype WHERE idPackage=@pid", cnn);
                cmd.Parameters.AddWithValue("pid", packageIDComboTxt.Text);
                cmd.Parameters.AddWithValue("name", packageNameTxt.Text);
                cmd.Parameters.AddWithValue("standardrate", standardRateTxt.Text);
                cmd.Parameters.AddWithValue("maxkm", maxKmTxt.Text);
                cmd.Parameters.AddWithValue("maxhours", maxHoursTxt.Text);
                cmd.Parameters.AddWithValue("extrakmrate", extraKmRateTxt.Text);
                cmd.Parameters.AddWithValue("waitingcharge", waitingChargeTxt.Text);
                cmd.Parameters.AddWithValue("driverovernightrate", overnightRateTxt.Text);
                cmd.Parameters.AddWithValue("vehiclenightparkrate", nightParkRateTxt.Text);
                cmd.Parameters.AddWithValue("vehicletype", vehicleTypeCombo.SelectedValue);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Package updated!", "Database update",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                //ClearForm();
                cnn.Close();
                LoadPackageIDValuesToComboBox();
                LoadNextPackageID();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Console.WriteLine(ex.StackTrace);
                cnn.Close();
            }
        }

        private void LoadVehicleTypeCombo()
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

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            UpdatePackage();
        }

        private void LoadPackageIDValuesToComboBox()
        {
            try
            {
                cnn.Open();
                SqlDataAdapter da = new SqlDataAdapter
                    ("select idPackage FROM PackageDetail;", cnn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                packageIDComboTxt.DataSource = dt;
                packageIDComboTxt.DisplayMember = "idPackage";
                packageIDComboTxt.ValueMember = "idPackage";
                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                cnn.Close();
            }
        }


        private void PackageForm_Load(object sender, EventArgs e)
        {
            LoadNextPackageID();
        }

        private void LoadNextPackageID()
        {
            try
            {
                cnn.Open();
                SqlCommand cmd = new SqlCommand
                    ("select MAX(idPackage+1) AS PID from PackageDetail;", cnn);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    packageIDComboTxt.Text = dr["PID"].ToString();
                }
                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                cnn.Close();
            }
        }

        private void packageIDComboTxt_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadPackageDetails();
        }

        private void LoadPackageDetails()
        {
            try
            {
                if (cnn.State == ConnectionState.Open)
                {
                    cnn.Close();
                }
                cnn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM PackageDetail WHERE idPackage=@pid", cnn);
                cmd.Parameters.AddWithValue("pid", packageIDComboTxt.Text);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    packageNameTxt.Text = dr[1].ToString();
                    standardRateTxt.Text = dr[2].ToString();
                    maxKmTxt.Text = dr[3].ToString();
                    maxHoursTxt.Text = dr[4].ToString();
                    extraKmRateTxt.Text = dr[5].ToString();
                    waitingChargeTxt.Text = dr[6].ToString();
                    overnightRateTxt.Text = dr[7].ToString();
                    nightParkRateTxt.Text = dr[8].ToString();
                    vehicleTypeCombo.SelectedValue = dr[9].ToString();
                    saveBtn.Enabled = false;
                    updateBtn.Enabled = true;
                    deleteBtn.Enabled = true;

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

        private void ClearForm()
        {
            packageNameTxt.Text = "";
            standardRateTxt.Text = "";
            maxKmTxt.Text = "";
            maxHoursTxt.Text = "";
            extraKmRateTxt.Text = "";
            waitingChargeTxt.Text = "";
            overnightRateTxt.Text = "";
            nightParkRateTxt.Text = "";
            LoadNextPackageID();
            saveBtn.Enabled = true;
            updateBtn.Enabled = true;
            deleteBtn.Enabled = true;
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                cnn.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM PackageDetail WHERE idPackage=@pid", cnn);
                cmd.Parameters.AddWithValue("pid", packageIDComboTxt.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Package deleted!", "Database update",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearForm();
                cnn.Close();
                LoadPackageIDValuesToComboBox();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Console.WriteLine(ex.StackTrace);
                cnn.Close();
            }
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            new SearchPackageForm().ShowDialog();
            this.Close();
        }
    }
}
