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
    public partial class LongTourHireCalculationForm : Form
    {
        static string connectionStr = "Data Source=DESKTOP-GA6UOAH\\SQLEXPRESS;" +
            "Initial Catalog=AyuboDrive; Integrated Security=true;";
        SqlConnection cnn = new SqlConnection(connectionStr);

        public LongTourHireCalculationForm()
        {
            InitializeComponent();
            var t = DateTime.Now;
            var now = new DateTime(t.Year, t.Month, t.Day, t.Hour, t.Minute, t.Second);
            startDayDtp.Value = now;
            endDayDtp.Value = now;

            loadPackageTypeCombo();
        }

        private void loadPackageTypeCombo()
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT DISTINCT name from PackageDetail WHERE "+
                    "idPackageType=2", cnn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                packageTypeCombo.DisplayMember = "name";
                packageTypeCombo.ValueMember = "name";
                packageTypeCombo.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void calculateBtn_Click(object sender, EventArgs e)
        {
            int vehicle_no = Int32.Parse(vehicleNoTxt.Text);
            string package_type = packageTypeCombo.SelectedValue.ToString();
            DateTime start_date = startDayDtp.Value;
            DateTime end_date = endDayDtp.Value;
            double start_km_reading = double.Parse(startKmReadingTxt.Text);
            double end_km_reading = double.Parse(endKmReadingTxt.Text);

            CalculateLongTourHire(vehicle_no, package_type, start_date, end_date, start_km_reading, end_km_reading);
        }

        private void CalculateLongTourHire(int vehicle_no, string package_type, DateTime start_date,
            DateTime end_date, double start_km_reading, double end_km_reading)
        {
            double base_hire_charge;
            double overnight_stay_charge = 0.00;
            double driver_overnight_stay_charge = 0.00;
            double vehicle_night_park_charge = 0.0;
            double extra_km_charge = 0.00;

            // Getting package details from Database
            base_hire_charge = 0.00; //standard rate
            double max_Km_limit = 0.0;
            double extra_Km_rate = 0;
            double driver_overnight_rate =0.0;
            double night_park_rate =0.0;

            try
            {
                cnn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM dbo.PackageDetail INNER JOIN dbo.VehicleType " +
                    "ON dbo.PackageDetail.idVehicleType = dbo.VehicleType.idType INNER JOIN dbo.Vehicle " +
                    "ON dbo.Vehicle.idVehicleType = dbo.VehicleType.idType " +
                    "WHERE dbo.Vehicle.idvehicle= @vno AND dbo.PackageDetail.name = @packageName AND "+
                    "dbo.PackageDetail.idPackageType = @ptype", cnn);
                cmd.Parameters.AddWithValue("@vno", vehicle_no);
                cmd.Parameters.AddWithValue("@packageName", package_type);
                cmd.Parameters.AddWithValue("@ptype", 2);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    base_hire_charge = double.Parse(dr[2].ToString(), System.Globalization.NumberStyles.AllowDecimalPoint);
                    max_Km_limit = double.Parse(dr[3].ToString());
                    extra_Km_rate = double.Parse(dr[5].ToString());
                    driver_overnight_rate = double.Parse(dr[7].ToString());
                    night_park_rate = double.Parse(dr[8].ToString());
                }
                else
                {
                    MessageBox.Show("Package NOT Found");
                }
                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            //Calculate total days
            int total_days = (end_date - start_date).Days;

            // Distance calculation in Km
            double tour_distance = end_km_reading - start_km_reading;

            // Extra km charge calculation
            double extra_km_travelled = 0;
            if (tour_distance > max_Km_limit)
            {
                extra_km_travelled = tour_distance - max_Km_limit;
                extra_km_charge = extra_km_travelled * extra_Km_rate;
            }

            //Calculate Driver overnight rate
            if (total_days >= 2)
            {
                driver_overnight_stay_charge = driver_overnight_rate * (total_days-1);
            }

            //Calculate vehicle night park rate
            if (total_days >= 2)
            {
                vehicle_night_park_charge = night_park_rate * (total_days - 1);
            }

            //Calculate overnight stay charge
            overnight_stay_charge = driver_overnight_stay_charge + vehicle_night_park_charge;

            // Calculating total rent
            double total_rent = base_hire_charge + overnight_stay_charge +extra_km_charge;

            // Displaying values in interface
            maxKmLimitLabel.Text = max_Km_limit.ToString() + " Km";

            distanceTravelledLabel.Text = tour_distance.ToString() + " Km";
            tourDurationLabel.Text = total_days+" days";

            baseHireChargeLabel.Text = "Rs. " + base_hire_charge;

            extraKmsLabel.Text = String.Format("{0:0.##}", extra_km_travelled) + " Km";
            extraKmChargeRateLabel.Text = "Rs. " + String.Format("{0:0.##}", extra_Km_rate);
            extraKmChargeLabel.Text = "Rs. " + extra_km_charge.ToString();

            daysOvernightLabel.Text = (total_days-1) + " days";
            driverOvernightRateLabel.Text = "Rs. " + String.Format("{0:0.00}", driver_overnight_rate);
            driverOvernightChargeLabel.Text = "Rs. " + String.Format("{0:0.00}", driver_overnight_stay_charge);
            
            daysNightParkLabel.Text = (total_days-1) + " days";
            nightParkRateLabel.Text = "Rs. " + String.Format("{0:0.00}", night_park_rate);
            nightParkRateChargeLabel.Text = "Rs. " + String.Format("{0:0.00}", vehicle_night_park_charge);

            totalHireLabel.Text = "Rs. " + String.Format("{0:0.##}", total_rent);
        }
    }
}
