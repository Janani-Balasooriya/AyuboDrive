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
    public partial class PackageForm : Form
    {
        static string connectionStr = "Data Source=DESKTOP-GA6UOAH\\SQLEXPRESS;" +
            "Initial Catalog=AyuboDrive; Integrated Security=true;";
        SqlConnection cnn = new SqlConnection(connectionStr);
        public PackageForm()
        {
            InitializeComponent();
            LoadVehicleTypeCombo();
        }

        private void dayTourSaveBtn_Click(object sender, EventArgs e)
        {
            DayTourPackageSave();
        }

        private void longTourSaveBtn_Click(object sender, EventArgs e)
        {
            LongTourPackageSave();
        }

        private void DayTourPackageSave()
        {
            try
            {
                cnn.Open();
                SqlCommand cmd = new SqlCommand("insert into PackageDetail (idPackage,name,maxKmLimit, maxHours,"+
                    "standardRate,extraKmRate,waitingCharge,idVehicleType,idPackageType) values "+
                    "(@pid, @name, @maxkm, @maxhours, @standardrate,@extrakmrate, @waitingcharge, @vehicletype, @idpackagetype)", cnn);
                cmd.Parameters.AddWithValue("pid", dayPackageIDTxt.Text);
                cmd.Parameters.AddWithValue("name", dayPackageNameTxt.Text);
                cmd.Parameters.AddWithValue("maxkm", dayMaxKmTxt.Text);
                cmd.Parameters.AddWithValue("maxhours", dayMaxHoursTxt.Text);
                cmd.Parameters.AddWithValue("standardrate", dayStandardRateTxt.Text);
                cmd.Parameters.AddWithValue("extrakmrate", dayExtraKmRateTxt.Text);
                cmd.Parameters.AddWithValue("waitingcharge", dayWaitingChargeTxt.Text);
                cmd.Parameters.AddWithValue("vehicletype", dayVehicleTypeCombo.SelectedValue);
                cmd.Parameters.AddWithValue("idpackagetype", 1);
                cmd.ExecuteNonQuery();
                MessageBox.Show("New package added", "database update",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                //ClearForm();
                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                cnn.Close();
            }
        }

        private void LongTourPackageSave()
        {
            try
            {
                cnn.Open();
                SqlCommand cmd = new SqlCommand("insert into PackageDetail (idPackage,name,maxKmLimit, maxHours," +
                    "standardRate,extraKmRate,driverOvernightRate,vehicleNightParkRate,idVehicleType,idPackageType) values " +
                    "(@pid, @name, @maxkm, @maxhours, @standardrate,@extrakmrate, @driverovernightrate, @vehiclenightparkrate,"+
                    " @vehicletype, @idpackagetype)", cnn);
                cmd.Parameters.AddWithValue("pid", longPackageIDTxt.Text);
                cmd.Parameters.AddWithValue("name", longPackageNameTxt.Text);
                cmd.Parameters.AddWithValue("maxkm", longMaxKmTxt.Text);
                cmd.Parameters.AddWithValue("maxhours", longMaxHoursTxt.Text);
                cmd.Parameters.AddWithValue("standardrate", longStandardRateTxt.Text);
                cmd.Parameters.AddWithValue("extrakmrate", longExtraKmRateTxt.Text);
                cmd.Parameters.AddWithValue("driverovernightrate", driverOvernightRateTxt.Text);
                cmd.Parameters.AddWithValue("vehiclenightparkrate", vehicleNightParkRateTxt.Text);
                cmd.Parameters.AddWithValue("vehicletype", longVehicleTypeCombo.SelectedValue);
                cmd.Parameters.AddWithValue("idpackagetype", 2);
                cmd.ExecuteNonQuery();
                MessageBox.Show("New package added", "database update",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                //ClearForm();
                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
                dayVehicleTypeCombo.DisplayMember = "name";
                dayVehicleTypeCombo.ValueMember = "idType";
                dayVehicleTypeCombo.DataSource = dt;

                DataTable dt1 = new DataTable();
                da.Fill(dt1);
                longVehicleTypeCombo.DisplayMember = "name";
                longVehicleTypeCombo.ValueMember = "idType";
                longVehicleTypeCombo.DataSource = dt1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
