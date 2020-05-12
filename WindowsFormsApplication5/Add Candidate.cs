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
    public partial class Add_Candidate : UserControl
    {
        public Add_Candidate()
        {
            InitializeComponent();
        }

        string fileName = string.Empty;

        Setup setup = new Setup();

       
        private void btnbrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            
            open.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            open.ShowDialog();
            fileName = open.FileName;
           

            try
            {
                pictureBox1.Image = Image.FromFile(open.FileName.ToString());
            }
            catch (Exception)
            {
                return;
            }
        }

        private void Add_Candidate_Load(object sender, EventArgs e)
        {
            setup.showPosition(cmbPosition);
            setup.fillSearchBoxCandidate2(txtSearch);
          
            char drive = 'C';
            bool check = false;
            while (drive <= 'Z')
            {
                check = true;

                try
                {

                    pictureBox1.Image = Image.FromFile(drive + @":\VotingSystem\Image\preview_logo.png");

                }
                catch (Exception)
                {
                    check = false;

                }
                if (check == true)
                    break;
                drive++;
            }
            
        }
        
       

        private void textBox11_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text == "")
            {
                txtID.Text = "";
                txtfname.Text = "";
                txtmname.Text = "";
                txtlname.Text = "";
                txtpostal.Text = "";
                txtstname.Text = "";
                txtBuilding.Text = "";
                txtcity.Text = "";
                txtyearlevel.Text = "";
         
            }

            DataTable table = new DataTable();

            table = setup.selectCandidate(txtID.Text);

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
                txtyearlevel.Text = table.Rows[0][8].ToString();
               
            }
            catch (Exception)
            {
                
                return;
            }

         
        }
       

        public int ValidSubmit()
        {
            if (fileName == "")
            {
                MessageBox.Show("Please input the image of candidate");
                return 1;
            }
            else if (cmbPosition.Text == "")
            {
                MessageBox.Show("Please select position of the candidate");
                return 1;
            }
            else if (txtID.Text == "")
            {
                MessageBox.Show("Please fill the student id of candidate");
                return 1;
            }

            return 0;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (ValidSubmit() != 0)
                return;
            if (setup.countRecord(txtID.Text) != 0)
            {
                MessageBox.Show("Student violates Rules and Regulations");
                
                return;
            }
                
            string filePath = @"F:\VotingSystem\Candidate\" + txtID.Text + ".jpg";
            int position_id = setup.getCandidateID(cmbPosition.Text);
            if (cmbPosition.Text.Equals("1st Representative") || cmbPosition.Text.Equals("2nd Representative") || cmbPosition.Text.Equals("3rd Representative") || cmbPosition.Text.Equals("4th Representative"))
            {

                if (validationPosition(cmbPosition.Text, Int32.Parse(txtyearlevel.Text)) != true)
                {
                    MessageBox.Show("This student cannot run as " + cmbPosition.Text);
                    return;
                }
            }
            if (setup.addCandidate(txtSearch.Text, position_id, filePath) != 0)
                return;
            try
            {
                File.Copy(fileName, filePath);
            }
            catch (Exception)
            {
                File.Delete(filePath);
                File.Copy(fileName, filePath);
            }

            MessageBox.Show("Successfully added to the list of candidate");
            this.Refresh();
            
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && !(e.KeyChar == '-'))
            {
                e.Handled = true;
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text == "")
            {
                txtID.Text = "";
                txtfname.Text = "";
                txtmname.Text = "";
                txtlname.Text = "";
                txtpostal.Text = "";
                txtstname.Text = "";
                txtBuilding.Text = "";
                txtcity.Text = "";
       


            }

            DataTable table = new DataTable();
            table = setup.selectCandidate(txtSearch.Text);


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
                txtyearlevel.Text = table.Rows[0][8].ToString();


            }
            catch (Exception)
            {

                return;
            }
        }

        public bool validationPosition(string position,int year)
        {
            switch (position)
            {
                case "1st Representative":
                    if (year == 7)
                        return true;
                    break;

                case "2nd Representative":
                    if (year == 8)
                        return true;
                    break;

                case "3rd Representative": 
                    if (year == 9)
                        return true;
                    break;

                case "4th Representative":
                    if (year == 10)
                        return true;
                    break;


            }

            return false;
        }
    }
}
