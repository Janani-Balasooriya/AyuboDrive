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
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void vehicleBtn_Click(object sender, EventArgs e)
        {
            VehicleForm vehicleForm = new VehicleForm();
            vehicleForm.ShowDialog();
        }

        private void vehicleTypeBtn_Click(object sender, EventArgs e)
        {
            VehicleTypeForm vehicleTypeForm = new VehicleTypeForm();
            vehicleTypeForm.ShowDialog();
        }

        private void rentCalculationBtn_Click(object sender, EventArgs e)
        {
            RentCalculationForm rentCalculationForm = new RentCalculationForm();
            rentCalculationForm.ShowDialog();
        }

        private void dayTourHireBtn_Click(object sender, EventArgs e)
        {
            DayTourHireCalculationForm dayTourHireCalculationForm = new DayTourHireCalculationForm();
            dayTourHireCalculationForm.ShowDialog();
        }
    }
}
