using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AyuboDrive
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateBtn_Click(object sender, EventArgs e)
        {
            int vehicle_no = Int32.Parse(vehicleNoTxt.Text);
            string rented_date = dateTimePicker1.Value.ToShortDateString();
            string return_date = dateTimePicker2.Value.ToShortDateString();

            Console.WriteLine("Total days : "+(dateTimePicker2.Value - dateTimePicker1.Value).TotalDays);
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
        private double calculateRent(int vehicle_no, string rented_date, string return_date, bool with_driver)
        {
            
            Console.WriteLine(vehicle_no);
            Console.WriteLine(rented_date);
            Console.WriteLine(return_date);
            Console.WriteLine(with_driver);
            Console.WriteLine("--------------");

            double total_rent_value = 0;
            return total_rent_value;
        }

        
    }
}
