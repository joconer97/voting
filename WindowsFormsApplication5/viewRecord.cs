using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication5
{
    public partial class viewRecord : UserControl
    {
        public viewRecord()
        {
            InitializeComponent();
            txtID.Text = "Enter a name or student id";
            txtID.ForeColor = Color.Gray;
        }

        Setup setup = new Setup();

       

       

     
        private void viewRecord_Load(object sender, EventArgs e)
        {
            setup.fillSearchBox(txtID);
        }

      

        private void txtID_Click(object sender, EventArgs e)
        {
            txtID.Text = "";
            txtID.ForeColor = Color.Black;
        }

        public void designDataGridView()
        {
            this.dataGridView1.Columns[0].HeaderText = "Student ID";
            this.dataGridView1.Columns[1].HeaderText = "Name";
            this.dataGridView1.Columns[2].HeaderText = "Violation#";
            this.dataGridView1.Columns[3].HeaderText = "Date";
          
            this.dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(242, 165, 22);
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.Maroon;
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.FromArgb(224, 220, 19);
            dataGridView1.BackgroundColor = Color.White;

            
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.Maroon;
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;


            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                dataGridView1.Rows[i].DefaultCellStyle.Font = new Font("Century Gothic", 10);
                dataGridView1.Rows[i].DefaultCellStyle.ForeColor = Color.White;
            }
        }
        private void txtID_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable table = new DataTable();
                table = setup.viewRecord(txtID.Text);
                dataGridView1.DataSource = table;
                designDataGridView();
                
                
            }
            catch (Exception)
            {
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;

                DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];

                string a = Convert.ToString(selectedRow.Cells["ViolationID"].Value);

                txtViolation.Text = setup.viewDescription(Int32.Parse(a));

            }
        }

             
    

       
        
    }
}
