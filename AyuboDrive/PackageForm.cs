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

        private void PackageSaveBtn_Click(object sender, EventArgs e)
        {
            PackageSave();
        }

        private void PackageSave()
        {
            try
            {
                cnn.Open();
                SqlCommand cmd = new SqlCommand("insert into PackageDetail values "+
                    "(@pid, @name, @standardrate, @maxkm, @maxhours, @extrakmrate, @waitingcharge, @driverovernightrate, @vehiclenightparkrate, @vehicletype)", cnn);
                cmd.Parameters.AddWithValue("pid", dayPackageIDTxt.Text);
                cmd.Parameters.AddWithValue("name", dayPackageNameTxt.Text);
                cmd.Parameters.AddWithValue("standardrate", dayStandardRateTxt.Text);
                cmd.Parameters.AddWithValue("maxkm", dayMaxKmTxt.Text);
                cmd.Parameters.AddWithValue("maxhours", dayMaxHoursTxt.Text);
                cmd.Parameters.AddWithValue("extrakmrate", dayExtraKmRateTxt.Text);
                cmd.Parameters.AddWithValue("waitingcharge", dayWaitingChargeTxt.Text);
                cmd.Parameters.AddWithValue("driverovernightrate", driverOvernightRateTxt.Text);
                cmd.Parameters.AddWithValue("vehiclenightparkrate", vehicleNightParkRateTxt.Text);
                cmd.Parameters.AddWithValue("vehicletype", dayVehicleTypeCombo.SelectedValue);
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

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


       
    }
}
