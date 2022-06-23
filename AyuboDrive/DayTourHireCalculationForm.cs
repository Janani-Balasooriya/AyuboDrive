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
using MaterialSkin;
using MaterialSkin.Controls;

namespace AyuboDrive
{
    public partial class DayTourHireCalculationForm : MaterialForm
    {
        static string connectionStr = "Data Source=DESKTOP-GA6UOAH\\SQLEXPRESS;" +
            "Initial Catalog=AyuboDrive; Integrated Security=true;";
        SqlConnection cnn = new SqlConnection(connectionStr);

        public DayTourHireCalculationForm()
        {
            InitializeComponent();
            searchComboBoxValues();
            var t = DateTime.Now;
            var now = new DateTime(t.Year, t.Month, t.Day, t.Hour, t.Minute, t.Second);
            startTimeDtp.Value = now;
            endTimeDtp.Value = now;
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800,
                Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }


        private void calculateBtn_Click(object sender, EventArgs e)
        {
            string vehicle_no = vehicleNoComboTxt.SelectedValue.ToString();
            DateTime start_time = startTimeDtp.Value;
            DateTime end_time = endTimeDtp.Value;
            double start_km_reading = double.Parse(startKmReadingTxt.Text);
            double end_km_reading = double.Parse(endKmReadingTxt.Text);

            CalculateDayTourHire(vehicle_no,start_time,end_time,start_km_reading,end_km_reading);
            panel1.Visible = true;
            panel2.Visible = true;
        }

        private void CalculateDayTourHire(string vehicle_no, DateTime start_time, 
            DateTime end_time, double start_km_reading, double end_km_reading)
        {
            double base_hire_charge;
            double waiting_charge = 0.00;
            double extra_km_charge = 0.00;

            // Getting package details from Database
            base_hire_charge = 0.00; //standard rate
            double max_Km_limit = 0.0;
            int max_hours = 0;
            double extra_Km_rate = 0;
            double waiting_charge_per_hour = 0;
            //double driver_overnight_rate;
            //double night_park_rate;

            try
            {
                cnn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM dbo.PackageDetail INNER JOIN dbo.VehicleType "+
                    "ON dbo.PackageDetail.idVehicleType = dbo.VehicleType.idType INNER JOIN dbo.Vehicle "+
                    "ON dbo.Vehicle.idVehicleType = dbo.VehicleType.idType "+
                    "WHERE dbo.Vehicle.idvehicle= @vno", cnn);
                cmd.Parameters.AddWithValue("@vno", vehicle_no);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    base_hire_charge = double.Parse(dr[2].ToString(), System.Globalization.NumberStyles.AllowDecimalPoint);
                    max_Km_limit = double.Parse(dr[3].ToString());
                    max_hours = Int32.Parse(dr[4].ToString());
                    extra_Km_rate = double.Parse(dr[5].ToString()); 
                    waiting_charge_per_hour = double.Parse(dr[6].ToString());
                    // driver_overnight_rate = double.Parse(dr[7].ToString());
                    //night_park_rate = double.Parse(dr[8].ToString());
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

            // Time difference Calculation
            TimeSpan tour_time_duration = (end_time - start_time);

            // Waiting charge calculation
            double extra_hours_travelled =0 ;
            if ( tour_time_duration.TotalHours > max_hours)
            {
               extra_hours_travelled = tour_time_duration.TotalHours - max_hours;
               // TimeSpan interval = TimeSpan.FromHours(extra_hours_travelled);
               // waiting_charge = interval.TotalHours * waiting_charge_per_hour;
                waiting_charge = extra_hours_travelled * waiting_charge_per_hour;
                
            }

            // Distance calculation in Km
            double tour_distance = end_km_reading - start_km_reading;

            // Extra km charge calculation
            double extra_km_travelled = 0;
            if (tour_distance > max_Km_limit)
            {
                extra_km_travelled = tour_distance - max_Km_limit;
                extra_km_charge = extra_km_travelled * extra_Km_rate;
            }

            // Calculating total rent
            double total_rent = base_hire_charge + extra_km_charge + waiting_charge;

            // Displaying values in interface
            maxKmLimitLabel.Text = max_Km_limit.ToString()+" Km";
            maxHoursLabel.Text = max_hours.ToString()+" Hrs"; 

            distanceTravelledLabel.Text= tour_distance.ToString() + " Km";
            tourDurationLabel.Text = tour_time_duration.Hours + " Hrs : "+ tour_time_duration.Minutes+" min";

            baseHireChargeLabel.Text =base_hire_charge+ "/=";//
            MessageBox.Show("" + base_hire_charge);

            extraKmsLabel.Text = String.Format("{0:0.##}", extra_km_travelled)+" Km"; 
            extraKmChargeRateLabel.Text = String.Format("{0:0.##}", extra_Km_rate) + " /="; 
            extraKmChargeLabel.Text = extra_km_charge.ToString() + " /="; 

            extraHoursLabel.Text = Math.Round(extra_hours_travelled,2) + " Hrs"; 
            waitingChargeRateLabel.Text =String.Format("{0:0.##}", waiting_charge_per_hour) + " /="; 
            waitingChargeLabel.Text = String.Format("{0:0.##}", waiting_charge) + " /=";
            
            totalHireLabel.Text = String.Format("{0:0.##}", total_rent)+" /=";
        }

        private void searchComboBoxValues()
        {
            try
            {
                cnn.Open();
                SqlDataAdapter da = new SqlDataAdapter
                    ("select idvehicle, name, concat(idvehicle,' - ',name) AS forCombo FROM Vehicle;"
                    , cnn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                vehicleNoComboTxt.DataSource = dt;
                vehicleNoComboTxt.DisplayMember = "forCombo";
                vehicleNoComboTxt.ValueMember = "idvehicle";
                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
