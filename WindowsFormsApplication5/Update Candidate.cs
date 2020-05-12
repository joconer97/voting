using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Threading;
namespace WindowsFormsApplication5
{
    public partial class Update_Candidate : UserControl
    {
        public Update_Candidate()
        {
            InitializeComponent();
        }

        Setup setup = new Setup();
        string fileName = "";
        string oldFileName = "";
        private void Update_Candidate_Load(object sender, EventArgs e)
        {
            char drive = 'C';
            bool check = false;
            while (drive <= 'Z')
            {
                check = true;

                try
                {
                    pcbImage.Image = Image.FromFile(@drive + @":\VotingSystem\Image\preview_logo.png");
                    pcbImage.BackColor = System.Drawing.SystemColors.ActiveCaption;
                }
                catch (Exception)
                {
                    check = false;

                }
                if (check == true)
                    break;
                drive++;

            }
            string search = txtSearch.Text;
            setup.fillSearchBoxCandidate(txtSearch);
            setup.showPosition(cmbPosition);
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && !(e.KeyChar == '-'))
            {
                e.Handled = true;
            }
        }

        private const int NumberOfAttempts = 3;
        private const int DelayBetweenEachAttempt = 1000; 

        private void btnAdd_Click(object sender, EventArgs e)
        {


            DialogResult result = MessageBox.Show("Do you really want to change the data of this candidate", "Message", MessageBoxButtons.OKCancel);

            if (result != DialogResult.OK)
                return;

            if (cmbPosition.Text.Equals("1st Representative") || cmbPosition.Text.Equals("2nd Representative") || cmbPosition.Text.Equals("3rd Representative") || cmbPosition.Text.Equals("4th Representative"))
            {
               
                if (validationPosition(cmbPosition.Text, Int32.Parse(txtyear.Text)) != true)
                {
                    MessageBox.Show("This student cannot run as " + cmbPosition.Text);
                    return;
                }
            }
            int index = setup.getCandidateID(cmbPosition.Text);
            setup.updatePosition(txtID.Text, index);
            if (fileName != "")
            {
                if (!File.Exists(@"F:\VotingSystem\Candidate\" + txtID.Text + ".jpg"))
                {
                    File.Copy(fileName,@"F:\VotingSystem\Candidate\" + txtID.Text + ".jpg");
                    return;
                }

                for (int i = 1; ; ++i)
                {
                    try
                    {

                        File.Delete(@"F:\VotingSystem\Candidate\" + txtID.Text + ".jpg");
         
                        return;
                    }
                    catch (IOException)
                    {
                        File.Move(@"F:\VotingSystem\Bin\txt.jpg", oldFileName);
                        if (!File.Exists(oldFileName))
                        {
                            return;
                        }

                        if (i == NumberOfAttempts)
                            throw;

                        Thread.Sleep(DelayBetweenEachAttempt);
                    }
                }
               
                
            }

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text == "")
            {
                emptyText();
                
       
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
                txtyear.Text = table.Rows[0][8].ToString();
              
                pcbImage.Image = Image.FromFile(table.Rows[0][12].ToString());
                int x = Int32.Parse(table.Rows[0][13].ToString());
                cmbPosition.SelectedIndex = x - 1;
                oldFileName = table.Rows[0][12].ToString();

                
       
            }
            catch (Exception)
            {

                return;
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            pcbImage.Image = Image.FromFile(@"F:\VotingSystem\Image\preview_logo.png");
            DialogResult result = MessageBox.Show("Do you really want to delete this candidate?", "Voting System Message", MessageBoxButtons.OKCancel);
            
            if (result == DialogResult.OK)
            {
                setup.deleteCandidate(txtID.Text);  
            }

            emptyText();
            txtSearch.Text = "";
            setup.fillSearchBoxCandidate(txtSearch);

        }

        public void emptyText()
        {
            
                txtID.Text = "";
                txtfname.Text = "";
                txtmname.Text = "";
                txtlname.Text = "";
                txtpostal.Text = "";
                txtstname.Text = "";
                txtBuilding.Text = "";
                txtcity.Text = "";
                txtyear.Text = "";
              


            
        }


        private void btnbrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();

            open.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            open.ShowDialog();

          
            
            try
            {
            
                fileName = open.FileName;
                pcbImage.Image = Image.FromFile(open.FileName.ToString());
               
                
            }
            catch (Exception)
            {
                    return;
            }
              
           
            
        }

        public bool validationPosition(string position, int year)
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
