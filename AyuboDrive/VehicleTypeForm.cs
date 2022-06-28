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
using MaterialSkin;
using MaterialSkin.Controls;

namespace AyuboDrive
{
    public partial class VehicleTypeForm : MaterialForm
    {
        static string connectionStr = "Data Source=DESKTOP-GA6UOAH\\SQLEXPRESS;" +
            "Initial Catalog=AyuboDrive; Integrated Security=true;";
        SqlConnection cnn = new SqlConnection(connectionStr);
        public VehicleTypeForm()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800,
                Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
            LoadAllVehicleTypeTable();
            LoadNextPackageID();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            saveVehicleType();
            LoadAllVehicleTypeTable();
        }

        private void saveVehicleType()
        {
            try
            {
                cnn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO VehicleType VALUES (@vid, @Name)", cnn);
                cmd.Parameters.AddWithValue("vid", vehicleIDTxt.Text);
                cmd.Parameters.AddWithValue("Name", vehicleNameTxt.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("New Vehicle Type Added", "Database Update",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                clearForm();
                cnn.Close();
                LoadAllVehicleTypeTable();
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void updateVehicleType()
        {
            try
            {
                cnn.Open();
                SqlCommand cmd = new SqlCommand("UPDATE VehicleType SET name=@Name WHERE idType=@vid", cnn);
                cmd.Parameters.AddWithValue("vid", vehicleIDTxt.Text);
                cmd.Parameters.AddWithValue("Name", vehicleNameTxt.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Vehicle Type Updated", "Database Update",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                clearForm();
                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DeleteVehicleType()
        {
            try
            {
                cnn.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM VehicleType WHERE idType=@vid", cnn);
                cmd.Parameters.AddWithValue("vid", vehicleIDTxt.Text);
                cmd.Parameters.AddWithValue("Name", vehicleNameTxt.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Vehicle Type Deleted", "Database Update",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                clearForm();
                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void clearForm()
        {
            vehicleNameTxt.Text = "";
            LoadNextPackageID();
            LoadNextPackageID();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {

            DeleteVehicleType();
            LoadAllVehicleTypeTable();
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            updateVehicleType();
            clearForm();
            LoadAllVehicleTypeTable();
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            clearForm();
            saveBtn.Enabled = true;
            updateBtn.Enabled = false;
            deleteBtn.Enabled = false;
        }

        private void LoadAllVehicleTypeTable()
        {
            try
            {
                cnn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM VehicleType", cnn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.Rows.Clear();
                int count = 1;
                foreach (DataRow dr in dt.Rows)
                {
                    dataGridView1.Rows.Add(dr[0].ToString(), dr[1].ToString());
                    count++;
                }
                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            vehicleIDTxt.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            vehicleNameTxt.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            saveBtn.Enabled = false;
            updateBtn.Enabled = true;
            deleteBtn.Enabled = true;
        }

        private void LoadNextPackageID()
        {
            try
            {
                cnn.Open();
                SqlCommand cmd = new SqlCommand
                    ("select MAX(idType+1) AS VID from VehicleType;", cnn);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    vehicleIDTxt.Text = dr["VID"].ToString();
                }
                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                cnn.Close();
            }
        }

        private void HomeBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            new MenuForm().ShowDialog();
            this.Close();
        }
    }
}
