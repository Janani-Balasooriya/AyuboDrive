using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace AyuboDrive
{
    public partial class DayTourHireCalculationForm : Form
    {
        static string connectionStr = "Data Source=DESKTOP-GA6UOAH\\SQLEXPRESS;" +
            "Initial Catalog=AyuboDrive; Integrated Security=true;";
        SqlConnection cnn = new SqlConnection(connectionStr);

        public DayTourHireCalculationForm()
        {
            InitializeComponent();
            loadPackageTypeCombo();
        }

        private void loadPackageTypeCombo()
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT DISTINCT name from PackageDetail", cnn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                vehicleTypeCombo.DisplayMember = "name";
                //vehicleTypeCombo.ValueMember = "idPackage";
                vehicleTypeCombo.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void calculateBtn_Click(object sender, EventArgs e)
        {
            int vehicle_no = Int32.Parse(vehicleNoTxt.Text);
            int package_type = Int32.Parse(vehicleTypeCombo.Text);
            DateTime start_time = startTimeDtp.Value;
            DateTime end_time = endTimeDtp.Value;
            double start_km_reading = double.Parse(startKmReadingTxt.Text);
            double end_km_reading = double.Parse(endKmReadingTxt.Text);

            CalculateDayTourHire(vehicle_no,package_type,start_time,end_time,start_km_reading,end_km_reading);
        }

        private void CalculateDayTourHire(int vehicle_no, int package_type, DateTime start_time, 
            DateTime end_time, double start_km_reading, double end_km_reading)
        {
            double standard_rate;
            double max_Km_limit;
            int max_hours;
            double extra_Km_rate;
            double waiting_charge_per_hour;
            double driver_overnight_rate;
            double night_park_rate;

            try
            {
                cnn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM dbo.PackageDetail INNER JOIN dbo.VehicleType "+
                    "ON dbo.PackageDetail.idVehicleType = dbo.VehicleType.idType INNER JOIN dbo.Vehicle "+
                    "ON dbo.Vehicle.idVehicleType = dbo.VehicleType.idType "+
                    "WHERE dbo.Vehicle.idvehicle= @vno AND dbo.PackageDetail.name = @packageName;", cnn);
                cmd.Parameters.AddWithValue("@vno", vehicle_no);
                cmd.Parameters.AddWithValue("@packageName", package_type);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    standard_rate = double.Parse(dr[2].ToString());
                    max_Km_limit = double.Parse(dr[3].ToString());
                    max_hours = Int32.Parse(dr[4].ToString());
                    extra_Km_rate = int.Parse(dr[5].ToString());
                    waiting_charge_per_hour = Int32.Parse(dr[6].ToString());
                    driver_overnight_rate = double.Parse(dr[7].ToString());
                    night_park_rate = double.Parse(dr[8].ToString());

                }
                else
                {
                    MessageBox.Show("Vehicle NOT Found");
                }
                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            double base_hire_charge = 0;
            double waiting_charge = 0;
            double extra_km_charge = 0;
        }

        
    }
}
