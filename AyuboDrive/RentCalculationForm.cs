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
    public partial class RentCalculationForm : Form
    {
        static string connectionStr = "Data Source=DESKTOP-GA6UOAH\\SQLEXPRESS;" +
            "Initial Catalog=AyuboDrive; Integrated Security=true;";
        SqlConnection cnn = new SqlConnection(connectionStr);
        public RentCalculationForm()
        {
            InitializeComponent();
        }

        private void calculateBtn_Click(object sender, EventArgs e)
        {
            int vehicle_no = Int32.Parse(vehicleNoTxt.Text.ToString());
            DateTime rented_date = rentedDateDtp.Value.Date;
            DateTime return_date = returnDateDtp.Value.Date;
            
            bool with_driver = false;
            if (withDriverRadioBtn.Checked)
            {
                with_driver = true;
            }
            else if (withoutDriverRadioBtn.Checked)
            {
                with_driver = false;
            }

            calculateRent(vehicle_no,rented_date,return_date, with_driver);
        }
        private double calculateRent(int vehicle_no, DateTime rented_date, DateTime return_date, bool with_driver)
        {
            int daily_rate = 0;
            int weekly_rate = 0;
            int monthly_rate = 0;
            int daily_driver_rate = 0;

            try
            {
                cnn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Vehicle WHERE idvehicle=@id", cnn);
                cmd.Parameters.AddWithValue("@id", vehicleNoTxt.Text);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    vehicleNameTxt.Text = dr[1].ToString();
                    monthly_rate = Int32.Parse(dr[2].ToString());
                    weekly_rate = Int32.Parse(dr[3].ToString());
                    daily_rate = Int32.Parse(dr[4].ToString());
                    daily_driver_rate = Int32.Parse(dr[5].ToString());
                    
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

            
            dailyRentLabel.Text = daily_rate.ToString();
            weeklyRentLabel.Text = weekly_rate.ToString();
            monthlyRateLabel.Text = monthly_rate.ToString();
            driverRateLabel.Text = daily_driver_rate.ToString();

            int month_count = 0;
            int week_count = 0;
            int day_count =0;
            int driver_cost = 0;

            int days_rented = (return_date - rented_date).Days;
            Console.WriteLine("Total days : " + days_rented);

            double total_rent_value =0;

            if (days_rented >=30) // days rented greater than or equal to 30
            {
                month_count += days_rented / 30;
                total_rent_value = month_count* monthly_rate;
                Console.WriteLine("Month count : "+month_count);

                int remaining_days = days_rented % 30;
                if(remaining_days > 7)
                {
                    week_count += remaining_days / 7;
                    total_rent_value += week_count* weekly_rate;
                    
                    day_count += remaining_days % 7;
                    if (day_count > 0)
                    {
                        total_rent_value += day_count* daily_rate;
                    }
                }else if(remaining_days > 0)
                {  
                    day_count+= remaining_days; 
                    total_rent_value += remaining_days* daily_rate;
                }
            }else if(days_rented >= 7) // if days rented greater than or equal to 7
            {
                week_count += days_rented / 7;
                total_rent_value = week_count* weekly_rate;

                int remaining_days = days_rented%7;
                day_count += remaining_days;
                if (remaining_days > 0)
                {
                    total_rent_value += remaining_days * daily_rate;
                }
            }else if(days_rented > 0) // if days rented are less than 7
            {
                day_count += days_rented;
                total_rent_value = days_rented * daily_rate;
            }

            if (withDriverRadioBtn.Checked) {
                driver_cost += daily_driver_rate * days_rented;
                total_rent_value += driver_cost;
            }

            monthsLabel.Text = month_count.ToString();
            weeksLabel.Text = week_count.ToString();
            daysLabel.Text = day_count.ToString();
            driverLabel.Text = days_rented.ToString();
          
            Console.WriteLine("total rent value : "+total_rent_value);
            Console.WriteLine("--------------");

            int monthly_rent = month_count * monthly_rate;
            int weekly_rent = week_count * weekly_rate;
            int daily_rent = day_count * daily_rate;
            total_rent_value = monthly_rent + weekly_rent + daily_rent+ driver_cost;
            Console.WriteLine("total rent value : " + total_rent_value);

            totalMonthlyRentLabel.Text = monthly_rent.ToString();
            totalWeeklyRentLabel.Text = weekly_rent.ToString();
            totalDailyRentLabel.Text = daily_rent.ToString();
            totalDriverCostLabel.Text = driver_cost.ToString();
            totalRentLabel.Text = total_rent_value.ToString();

            return total_rent_value;

        }

      

        private void vehicleNoTxt_Leave(object sender, EventArgs e)
        {
            try
            {
                cnn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Vehicle WHERE idvehicle=@id", cnn);
                cmd.Parameters.AddWithValue("@id", vehicleNoTxt.Text);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    vehicleNameTxt.Text = dr[1].ToString();

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
        }
    }
}
