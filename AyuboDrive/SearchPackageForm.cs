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
    public partial class SearchPackageForm : MaterialForm
    {
        static string connectionStr = "Data Source=DESKTOP-GA6UOAH\\SQLEXPRESS;" +
            "Initial Catalog=AyuboDrive; Integrated Security=true;";
        SqlConnection cnn = new SqlConnection(connectionStr);
        public SearchPackageForm()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800,
                Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
            LoadAllPackageDetailTable();
            LoadPackageTypeCombo();
        }

        private void LoadAllPackageDetailTable()
        {
            try
            {
                cnn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM PackageDetail", cnn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.Rows.Clear();
                int count = 1;
                foreach (DataRow dr in dt.Rows)
                {
                    dataGridView1.Rows.Add(dr[0].ToString(), dr[1].ToString(), dr[2].ToString(),
                        dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), dr[6].ToString(),
                        dr[7].ToString(), dr[8].ToString(), dr[9].ToString());
                    count++;
                }
                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LoadPackageDetailFromType()
        {
            try
            {
                cnn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM PackageDetail WHERE name=@name", cnn);
                cmd.Parameters.AddWithValue("name", packageTypeCombo.SelectedValue);
                SqlDataAdapter da = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.Rows.Clear();
                int count = 1;
                foreach (DataRow dr in dt.Rows)
                {
                    dataGridView1.Rows.Add(dr[0].ToString(), dr[1].ToString(), dr[2].ToString(),
                        dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), dr[6].ToString(),
                        dr[7].ToString(), dr[8].ToString(), dr[9].ToString());
                    count++;
                }
                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void vehicleTypeCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadPackageDetailFromType();
        }

        private void LoadPackageTypeCombo()
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("select distinct name from PackageDetail;", cnn);
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

        private void SearchPackageForm_Load(object sender, EventArgs e)
        {
            LoadAllPackageDetailTable();
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            LoadAllPackageDetailTable();
        }
    }
}
