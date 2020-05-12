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
    public partial class ViewSection : UserControl
    {
        public ViewSection()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable table = new DataTable();

            table = setup.showStudentSection(cmbRoom.SelectedItem.ToString());
            dataGridView1.DataSource = table;
            designDataGridView();
        }
        Setup setup = new Setup();
        private void ViewSection_Load(object sender, EventArgs e)
        {
            setup.showSection(cmbRoom);
        }
        public void designDataGridView()
        {
            this.dataGridView1.Columns[0].HeaderText = "Name";
            this.dataGridView1.Columns[1].HeaderText = "Section";
            this.dataGridView1.Columns[2].HeaderText = "Vote Date";

            this.dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(242, 165, 22);
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.FromArgb(128, 36, 4);
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

        private void txtPrint_Click(object sender, EventArgs e)
        {
            DGVPrinter printer = new DGVPrinter();
            printer.Title = "Section " + cmbRoom.SelectedItem.ToString();
            printer.SubTitle = DateTime.Now.ToLongTimeString();
            printer.PageNumberColor = Color.Black;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "Naga City School of Arts And Trade";
            printer.FooterSpacing = 15;
            printer.printDocument.DefaultPageSettings.Landscape = false;
            printer.PrintPreviewDataGridView(dataGridView1);
        }
    }
}
