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
    public partial class VoteResults : UserControl
    {
        public VoteResults()
        {
            InitializeComponent();
        }
        Setup setup = new Setup();
        List<string> position = new List<string>();

        private void VoteResults_Load(object sender, EventArgs e)
        {
            txtPrint.BackgroundImage = Image.FromFile(@"F:\VotingSystem\Image\print_icon.png");
            cmbPosition.Items.Add("All");
            setup.showPosition(cmbPosition);
            cmbPosition.SelectedIndex = 0;
            dataGridView1.DataSource = setup.showVoteAll();
            designDataGridView();
            getPosition();
        }

        private void cmbPosition_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (cmbPosition.SelectedItem.ToString().Equals("All"))
            {
                dataGridView1.DataSource = setup.showVoteAll();
                designDataGridView();
                return;
            }
            dataGridView1.DataSource = setup.showVote(cmbPosition.SelectedItem.ToString());
            designDataGridView();
        }

        public void designDataGridView()
        {
            this.dataGridView1.Columns[0].HeaderText = "Position";
            this.dataGridView1.Columns[1].HeaderText = "Name";
            this.dataGridView1.Columns[2].HeaderText = "Vote";

            this.dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(211,84,0);
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.FromArgb(170,42,29);
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.FromArgb(224, 220, 19);
            dataGridView1.BackgroundColor = Color.White;


            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(140, 16, 4);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;


            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                dataGridView1.Rows[i].DefaultCellStyle.Font = new Font("Century Gothic", 10);
                dataGridView1.Rows[i].DefaultCellStyle.ForeColor = Color.White;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void getPosition()
        {
            for (int i = 1; i < cmbPosition.Items.Count; i++)
            {
                position.Add(cmbPosition.GetItemText(cmbPosition.Items[i]));
                
            }
        }
        private void txtPrint_Click(object sender, EventArgs e)
        {
            DGVPrinter printer = new DGVPrinter();
            printer.Title = "Final Result";
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

        private void btnPrintFInal_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            ((Form)printPreviewDialog1).WindowState = FormWindowState.Maximized;
            printPreviewDialog1.ShowDialog();
           
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

            Image image = Image.FromFile(@"F:\VotingSystem\Image\SABANGLOGO.jpg");
            e.Graphics.DrawImage(image, 25, 25, 200,200);
            e.Graphics.DrawString("Naga City School", new Font("Century Gothic", 16),Brushes.Black, new Point(350,50));
            e.Graphics.DrawString("Of", new Font("Century Gothic", 16), Brushes.Black, new Point(430, 80));
            e.Graphics.DrawString("Arts And Trades", new Font("Century Gothic", 16), Brushes.Black, new Point(350, 110));

            int height = 300;

            for (int i = 0; i < position.Count; i++)
            {
                DataTable table = new DataTable();
                
                table = setup.printWinner(position[i]);
                try
                {
                    e.Graphics.DrawString(table.Rows[0][0].ToString() , new Font("Century Gothic", 12), Brushes.Black, new Point(100, height));
                    e.Graphics.DrawString(table.Rows[0][1].ToString(), new Font("Century Gothic", 12), Brushes.Black, new Point(350, height));
                }
                catch (Exception)
                {
                    e.Graphics.DrawString(position[i],new Font("Century Gothic", 12), Brushes.Black, new Point(100, height));
                    e.Graphics.DrawString("None", new Font("Century Gothic", 12), Brushes.Black, new Point(350, height));
                }
                height += 50;
               
            }
        }

       
    }
}
