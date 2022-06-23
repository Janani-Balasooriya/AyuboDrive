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
using System.Data.SqlClient;

namespace AyuboDrive
{
    public partial class SearchVehicleForm : MaterialForm
    {
        static string connectionStr = "Data Source=DESKTOP-GA6UOAH\\SQLEXPRESS;" +
           "Initial Catalog=AyuboDrive; Integrated Security=true;";
        SqlConnection cnn = new SqlConnection(connectionStr);
        public SearchVehicleForm()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800,
                Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
            LoadAllVehicleDetailTable();
            LoadVehicleTypeCombo();
        }

        private void LoadAllVehicleDetailTable()
        {
            try
            {
                cnn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Vehicle", cnn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.Rows.Clear();
                int count = 1;
                foreach (DataRow dr in dt.Rows)
                {
                    dataGridView1.Rows.Add(dr[0].ToString(), dr[1].ToString(), dr[2].ToString(),
                        dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), dr[6].ToString());
                    count++;
                }
                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LoadVehicleDetailFromType()
        {
            try
            {
                cnn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Vehicle WHERE idVehicleType=@vehicletype", cnn);
                cmd.Parameters.AddWithValue("vehicletype", vehicleTypeCombo.SelectedValue);
                SqlDataAdapter da = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.Rows.Clear();
                int count = 1;
                foreach (DataRow dr in dt.Rows)
                {
                    dataGridView1.Rows.Add(dr[0].ToString(), dr[1].ToString(), dr[2].ToString(),
                        dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), dr[6].ToString());
                    count++;
                }
                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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

        private void VehicleTypeCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadVehicleDetailFromType();
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            LoadAllVehicleDetailTable();
        }

        private void materialLabel6_Click(object sender, EventArgs e)
        {

        }
    }
}
