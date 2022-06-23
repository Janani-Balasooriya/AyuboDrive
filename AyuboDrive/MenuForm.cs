using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace AyuboDrive
{
    public partial class MenuForm : MaterialForm
    {
        public MenuForm()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800,
                Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }

        private void vehicleBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            VehicleForm vehicleForm = new VehicleForm();
            vehicleForm.ShowDialog();
            this.Close();
        }

        private void vehicleTypeBtn_Click(object sender, EventArgs e)
        {
            VehicleTypeForm vehicleTypeForm = new VehicleTypeForm();
            vehicleTypeForm.ShowDialog();
        }

        private void rentCalculationBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            RentCalculationForm rentCalculationForm = new RentCalculationForm();
            rentCalculationForm.ShowDialog();
            this.Close();
        }

        private void dayTourHireBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            DayTourHireCalculationForm dayTourHireCalculationForm = new DayTourHireCalculationForm();
            dayTourHireCalculationForm.ShowDialog();
            this.Close();
        }

        private void longTourHireBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            LongTourHireCalculationForm longTourHireCalculationForm = new LongTourHireCalculationForm();
            longTourHireCalculationForm.ShowDialog();
            this.Close();
        }

        private void packageDetailsBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            PackageForm packageForm = new PackageForm();
            packageForm.ShowDialog();
            this.Close();
        }

        private void MenuForm_Load(object sender, EventArgs e)
        {

        }
    }
}
