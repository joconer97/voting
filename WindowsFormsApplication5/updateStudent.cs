using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
namespace WindowsFormsApplication5
{
    public partial class updateStudent : UserControl
    {
        public updateStudent()
        {
            InitializeComponent();
        }
        string fileName = string.Empty;
        private void label3_Click(object sender, EventArgs e)
        {
            this.pictureBox2.Image = Image.FromFile(@"D:\WindowsFormsApplication5\Image\Search_30px.png");
        }
        Setup setup = new Setup();
        private void updateStudent_Load(object sender, EventArgs e)
        {
            setup.fillSearchBox(txtSearch);
        }

     

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }

        public int ValidSubmit()
        {
            if (txtBuilding.Text == "" && txtcity.Text == "" && txtpostal.Text == "" && txtstname.Text == "" && cmbGender.Text == "")
            {
                
                return 1;
            }
            return 0;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {

            if (ValidSubmit() != 0)
            {
                MessageBox.Show("Please fill the empty textbox");
                return;
            }
            
            // Step 1. Creates an instance of DbConnHelper
            DbConnHelpe helper = new DbConnHelpe();

            // Step 2. Open a connection
            SqlConnection conn = helper.OpenConnection();

            // Step 3. Check the state of the connection.
            if (conn.State != ConnectionState.Open)
            {
                MessageBox.Show("Connection failed!");
                return;
            }

            // NOTE: From this point onwards we are sure that we are connected to the DB.
            // Step 4. Prepare parameters.


            var spParams = new SqlParameter[] { 
                new SqlParameter("@stud_id",txtID.Text),
                new SqlParameter("@postalcode", txtpostal.Text),
                new SqlParameter("@stName", txtstname.Text),
                new SqlParameter("@building_num", txtBuilding.Text),
                new SqlParameter("@city", txtcity.Text),
                new SqlParameter("@year_level", Int32.Parse(cmbYearLevel.Text)),
                new SqlParameter("@contact_num", txtContact.Text)

            };

            // Step 5. Create a command.
            SqlCommand cmd = helper.CreateCommand(conn, "spUpdateStudent", spParams);

            // Step 6. Execute the command.
            cmd.ExecuteNonQuery();
            helper.CloseConnection(conn);
            MessageBox.Show("Student Information has been updated successfully");
        }


        public void emptyTextBox()
        {
            txtID.Text = "";
            txtfname.Text = "";
            txtmname.Text = "";
            txtlname.Text = "";
            txtpostal.Text = "";
            txtstname.Text = "";
            txtBuilding.Text = "";
            txtcity.Text = "";
            cmbYearLevel.Text = "";
            txtContact.Text = "";
        }
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

            if (txtSearch.Text == "")
            {
                emptyTextBox();
            }
            
            DataTable table = new DataTable();
            table = setup.selectStudent(txtSearch.Text);

           
            try
            {
                txtID.Text = table.Rows[0][0].ToString();
                txtfname.Text = table.Rows[0][1].ToString();
                txtmname.Text = table.Rows[0][2].ToString();
                txtlname.Text = table.Rows[0][3].ToString();
                txtpostal.Text = table.Rows[0][4].ToString();
                txtstname.Text = table.Rows[0][5].ToString();
                txtBuilding.Text = table.Rows[0][6].ToString();
                txtcity.Text = table.Rows[0][7].ToString();
                cmbYearLevel.Text = table.Rows[0][8].ToString();
                cmbGender.Text = (table.Rows[0][10].ToString());
                txtContact.Text = table.Rows[0][9].ToString();
               
            }
            catch (Exception)
            {
                
                return;
            }

          
           
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && !(e.KeyChar == '-'))
            {
                e.Handled = true;
            }
        }

        private void txtContact_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtpostal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
