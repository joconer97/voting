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
using Excel = Microsoft.Office.Interop.Excel;

namespace WindowsFormsApplication5
{
    class Setup
    {

        public void fillSearchBox(TextBox text)
        {
          
            // Step 1. Creates an instance of DbConnHelper
            DbConnHelpe helper = new DbConnHelpe();

            // Step 2. Open a connection
            SqlConnection conn = helper.OpenConnection();

            // Step 3. Check the state of the connection.
            if (conn.State != ConnectionState.Open)
            {
                return;
            }

            // NOTE: From this point onwards we are sure that we are connected to the DB.
            // Step 4. Prepare parameters.
            var spParams = new SqlParameter[] { 
                
          
            };

            // Step 5. Create a command.

            SqlDataAdapter sample = new SqlDataAdapter(helper.CreateCommand(conn, "spShowStudentId", spParams));

            // Step 6. Execute the command.
            DataTable table = new DataTable();
            sample.Fill(table);

            AutoCompleteStringCollection col = new AutoCompleteStringCollection();

            for (int i = 0; i < table.Rows.Count; i++)
            {

                col.Add(table.Rows[i]["stud_id"].ToString());
            }
            text.AutoCompleteCustomSource = col;


            helper.CloseConnection(conn);
        }
        public void fillSearchBoxCandidate(TextBox text)
        {

            // Step 1. Creates an instance of DbConnHelper
            DbConnHelpe helper = new DbConnHelpe();

            // Step 2. Open a connection
            SqlConnection conn = helper.OpenConnection();

            // Step 3. Check the state of the connection.
            if (conn.State != ConnectionState.Open)
            {
                return;
            }

            // NOTE: From this point onwards we are sure that we are connected to the DB.
            // Step 4. Prepare parameters.
            var spParams = new SqlParameter[] { 
                
          
            };

            // Step 5. Create a command.

            SqlDataAdapter sample = new SqlDataAdapter(helper.CreateCommand(conn, "spShowCandidateID", spParams));

            // Step 6. Execute the command.
            DataTable table = new DataTable();
            sample.Fill(table);

            AutoCompleteStringCollection col = new AutoCompleteStringCollection();

            for (int i = 0; i < table.Rows.Count; i++)
            {


                col.Add(table.Rows[i]["stud_id"].ToString());
            }
            text.AutoCompleteCustomSource = col;


            helper.CloseConnection(conn);
        }
        public void fillSearchBoxCandidate2(TextBox text)
        {

            // Step 1. Creates an instance of DbConnHelper
            DbConnHelpe helper = new DbConnHelpe();

            // Step 2. Open a connection
            SqlConnection conn = helper.OpenConnection();

            // Step 3. Check the state of the connection.
            if (conn.State != ConnectionState.Open)
            {
                return;
            }

            // NOTE: From this point onwards we are sure that we are connected to the DB.
            // Step 4. Prepare parameters.
            var spParams = new SqlParameter[] { 
                
          
            };

            // Step 5. Create a command.

            SqlDataAdapter sample = new SqlDataAdapter(helper.CreateCommand(conn, "spShowCandidateID2", spParams));

            // Step 6. Execute the command.
            DataTable table = new DataTable();
            sample.Fill(table);

            AutoCompleteStringCollection col = new AutoCompleteStringCollection();

            for (int i = 0; i < table.Rows.Count; i++)
            {


                col.Add(table.Rows[i]["stud_id"].ToString());
            }
            text.AutoCompleteCustomSource = col;


            helper.CloseConnection(conn);
        }
        public void updatePosition(string id,int pos_id)
        {
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
            var spParam = new SqlParameter[]{
              new SqlParameter("@stud_id",id),
              new SqlParameter("@pos_id",pos_id)
            };

            // Step 5. Create a command.
            SqlCommand cmd = helper.CreateCommand(conn, "spUpdatePosition", spParam);

            // Step 6. Execute the command.
            cmd.ExecuteNonQuery();


            helper.CloseConnection(conn);

        }
        public DataTable showStudentSection(string section_name)
        {
            DataTable table = new DataTable();
            // Step 1. Creates an instance of DbConnHelper
            DbConnHelpe helper = new DbConnHelpe();

            // Step 2. Open a connection
            SqlConnection conn = helper.OpenConnection();

            // Step 3. Check the state of the connection.
            if (conn.State != ConnectionState.Open)
            {
                MessageBox.Show("Connection failed!");
                return table;
            }

            // NOTE: From this point onwards we are sure that we are connected to the DB.
            // Step 4. Prepare parameters.
            var spParam = new SqlParameter[]{
              new SqlParameter("@section_name",section_name)
            };

            // Step 5. Create a command.
            SqlCommand cmd = helper.CreateCommand(conn, "spSelectSection", spParam);

            // Step 6. Execute the command.
            table.Load(cmd.ExecuteReader());


            helper.CloseConnection(conn);

            return table;
        }
        public int getNewRecord()
        {
            // Step 1. Creates an instance of DbConnHelper
            DbConnHelpe helper = new DbConnHelpe();

            // Step 2. Open a connection
            SqlConnection conn = helper.OpenConnection();

            // Step 3. Check the state of the connection.
            if (conn.State != ConnectionState.Open)
            {
                MessageBox.Show("Connection failed!");
                return 0;
            }

            // NOTE: From this point onwards we are sure that we are connected to the DB.
            // Step 4. Prepare parameters.
            var spParam = new SqlParameter[]{

            };

            // Step 5. Create a command.
            SqlCommand cmd = helper.CreateCommand(conn, "spGetNewRecord", spParam);

            // Step 6. Execute the command.
            int violation_num = Int32.Parse(cmd.ExecuteScalar().ToString());


            helper.CloseConnection(conn);

            return violation_num;
        }
        public void addNewRecord(string description)
        {
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
            var spParam = new SqlParameter[]{
              new SqlParameter("@description",description)
            };

            // Step 5. Create a command.
            SqlCommand cmd = helper.CreateCommand(conn, "spaddRecord", spParam);

            // Step 6. Execute the command.
            cmd.ExecuteNonQuery();


            helper.CloseConnection(conn);

            return;
        }

        public void studentAddRecord(string stud_id, string violation_num)
        {
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
            var spParam = new SqlParameter[]{
              new SqlParameter("@stud_id",stud_id),
              new SqlParameter("@violation_num",violation_num)
            };

            // Step 5. Create a command.
            SqlCommand cmd = helper.CreateCommand(conn, "spStudentAddRecord", spParam);

            // Step 6. Execute the command.
            cmd.ExecuteNonQuery();


            helper.CloseConnection(conn);

            return;
        }

        public DataTable viewRecord(string id)
        {
            DataTable table = new DataTable();
            // Step 1. Creates an instance of DbConnHelper
            DbConnHelpe helper = new DbConnHelpe();

            // Step 2. Open a connection
            SqlConnection conn = helper.OpenConnection();

            // Step 3. Check the state of the connection.
            if (conn.State != ConnectionState.Open)
            {
                MessageBox.Show("Connection failed!");
                return table;
            }

            // NOTE: From this point onwards we are sure that we are connected to the DB.
            // Step 4. Prepare parameters.
            var spParam = new SqlParameter[]{
              new SqlParameter("@stud_id",id)
            };

            // Step 5. Create a command.
            SqlCommand cmd = helper.CreateCommand(conn, "spViewRecord", spParam);

            // Step 6. Execute the command.
            table.Load(cmd.ExecuteReader());


            helper.CloseConnection(conn);

            return table;
        }

        public int getCandidateID(string pos_name)
        {
            // Step 1. Creates an instance of DbConnHelper
            DbConnHelpe helper = new DbConnHelpe();

            // Step 2. Open a connection
            SqlConnection conn = helper.OpenConnection();

            // Step 3. Check the state of the connection.
            if (conn.State != ConnectionState.Open)
            {
                MessageBox.Show("Connection failed!");
                return 0;
            }

            // NOTE: From this point onwards we are sure that we are connected to the DB.
            // Step 4. Prepare parameters.
            var spParam = new SqlParameter[]{
              new SqlParameter("@pos_name",pos_name)
            };

            // Step 5. Create a command.
            SqlCommand cmd = helper.CreateCommand(conn, "spGetCandidateID", spParam);

            // Step 6. Execute the command.
            int pos_id = (int)cmd.ExecuteScalar();


            helper.CloseConnection(conn);

            return pos_id;
        }

        public string viewDescription(int id)
        {
            DataTable table = new DataTable();
            // Step 1. Creates an instance of DbConnHelper
            DbConnHelpe helper = new DbConnHelpe();

            // Step 2. Open a connection
            SqlConnection conn = helper.OpenConnection();

            // Step 3. Check the state of the connection.
            if (conn.State != ConnectionState.Open)
            {
                MessageBox.Show("Connection failed!");
                return "";
            }

            // NOTE: From this point onwards we are sure that we are connected to the DB.
            // Step 4. Prepare parameters.
            var spParam = new SqlParameter[]{
              new SqlParameter("@violation_num",id)
            };

            // Step 5. Create a command.
            SqlCommand cmd = helper.CreateCommand(conn, "spShowDescription", spParam);

            // Step 6. Execute the command.
            string desc = (string)cmd.ExecuteScalar();


            helper.CloseConnection(conn);

            return desc;
        }

        public int totalCandidate()
        {
            // Step 1. Creates an instance of DbConnHelper
            DbConnHelpe helper = new DbConnHelpe();

            // Step 2. Open a connection
            SqlConnection conn = helper.OpenConnection();

            // Step 3. Check the state of the connection.
            if (conn.State != ConnectionState.Open)
            {
                MessageBox.Show("Connection failed!");
                return 0;
            }

            // NOTE: From this point onwards we are sure that we are connected to the DB.
            // Step 4. Prepare parameters.
            var spParam = new SqlParameter[]{
              
            };

            // Step 5. Create a command.
            SqlCommand cmd = helper.CreateCommand(conn, "spTotalCandidate", spParam);

            // Step 6. Execute the command.
            int total = (int)cmd.ExecuteScalar();


            helper.CloseConnection(conn);

            return total;
        }

        public int addCandidate(string id, int pos_id, string path)
        {
            // Step 1. Creates an instance of DbConnHelper
            DbConnHelpe helper = new DbConnHelpe();

            // Step 2. Open a connection
            SqlConnection conn = helper.OpenConnection();

            // Step 3. Check the state of the connection.
            if (conn.State != ConnectionState.Open)
            {
                MessageBox.Show("Connection failed!");
                return 1;
            }

            // NOTE: From this point onwards we are sure that we are connected to the DB.
            // Step 4. Prepare parameters.
            var spParam = new SqlParameter[]{
               new SqlParameter("@stud_id",id),
                new SqlParameter("@pos_id", pos_id),
                new SqlParameter("@imagepath", path)
            };

            // Step 5. Create a command.
            SqlCommand cmd = helper.CreateCommand(conn, "spAddCandidate", spParam);

            // Step 6. Execute the command.
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                MessageBox.Show("This student is already on the list of candidate" + id);
                return 1;
            }


            helper.CloseConnection(conn);

            return 0;
        }

        
        public DataTable selectCandidate(string id)
        {
            DataTable table = new DataTable();

            // Step 1. Creates an instance of DbConnHelper
            DbConnHelpe helper = new DbConnHelpe();

            // Step 2. Open a connection
            SqlConnection conn = helper.OpenConnection();

            // Step 3. Check the state of the connection.
            if (conn.State != ConnectionState.Open)
            {
                MessageBox.Show("Connection failed!");
                return table;
            }

            // NOTE: From this point onwards we are sure that we are connected to the DB.
            // Step 4. Prepare parameters.
            var spParams = new SqlParameter[] { 
                new SqlParameter("@stud_id",id)
          
            };

            // Step 5. Create a command.

            SqlDataAdapter sample = new SqlDataAdapter(helper.CreateCommand(conn, "spSelectCandidate", spParams));

            // Step 6. Execute the command
            try
            {
                sample.Fill(table);
            }
            catch (Exception)
            {
             
            }
            helper.CloseConnection(conn);
            return table;
           

        }
        public void deleteCandidate(string id)
        {
            DataTable table = new DataTable();

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
                new SqlParameter("@stud_id",id)
          
            };

            // Step 5. Create a command.

            SqlCommand cmd = helper.CreateCommand(conn, "spDeleteCandidate", spParams);

            // Step 6. Execute the command
            cmd.ExecuteNonQuery();
            helper.CloseConnection(conn);
            return;
        }

        public void addRoom(string section_name)
        {
            DataTable table = new DataTable();

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
                new SqlParameter("@section_name",section_name)
          
            };

            // Step 5. Create a command.

            SqlCommand cmd = helper.CreateCommand(conn, "spAddSection", spParams);

            // Step 6. Execute the command
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                MessageBox.Show("This section name already existing");
            }
            helper.CloseConnection(conn);
            return;
        }

        
        public DataTable selectStudent(string id)
        {
            DataTable table = new DataTable();

            // Step 1. Creates an instance of DbConnHelper
            DbConnHelpe helper = new DbConnHelpe();

            // Step 2. Open a connection
            SqlConnection conn = helper.OpenConnection();

            // Step 3. Check the state of the connection.
            if (conn.State != ConnectionState.Open)
            {
                MessageBox.Show("Connection failed!");
                return table;
            }

            // NOTE: From this point onwards we are sure that we are connected to the DB.
            // Step 4. Prepare parameters.
            var spParams = new SqlParameter[] { 
                new SqlParameter("@stud_id",id)
          
            };

            // Step 5. Create a command.

            SqlDataAdapter sample = new SqlDataAdapter(helper.CreateCommand(conn, "spSearchStudent", spParams));

            // Step 6. Execute the command
            sample.Fill(table);
           
            return table;
        }

        public DataTable showVote(string position)
        {
            DataTable table = new DataTable();

            // Step 1. Creates an instance of DbConnHelper
            DbConnHelpe helper = new DbConnHelpe();

            // Step 2. Open a connection
            SqlConnection conn = helper.OpenConnection();

            // Step 3. Check the state of the connection.
            if (conn.State != ConnectionState.Open)
            {
                MessageBox.Show("Connection failed!");
                return table;
            }

            // NOTE: From this point onwards we are sure that we are connected to the DB.
            // Step 4. Prepare parameters.
            var spParams = new SqlParameter[] { 
                new SqlParameter("@pos_name",position)
          
            };

            // Step 5. Create a command.

            SqlDataAdapter sample = new SqlDataAdapter(helper.CreateCommand(conn, "spCountVote", spParams));

            // Step 6. Execute the command
            sample.Fill(table);
            helper.CloseConnection(conn);
            return table;
        }

        public DataTable printWinner(string position)
        {
            DataTable table = new DataTable();

            // Step 1. Creates an instance of DbConnHelper
            DbConnHelpe helper = new DbConnHelpe();

            // Step 2. Open a connection
            SqlConnection conn = helper.OpenConnection();

            // Step 3. Check the state of the connection.
            if (conn.State != ConnectionState.Open)
            {
                MessageBox.Show("Connection failed!");
                return table;
            }

            // NOTE: From this point onwards we are sure that we are connected to the DB.
            // Step 4. Prepare parameters.
            var spParams = new SqlParameter[] { 
                new SqlParameter("@pos_name",position)
          
            };

            // Step 5. Create a command.

            SqlDataAdapter sample = new SqlDataAdapter(helper.CreateCommand(conn, "spPrintWinner", spParams));

            // Step 6. Execute the command
            sample.Fill(table);
            helper.CloseConnection(conn);
            return table;
        }

        public DataTable showVoteAll()
        {
            DataTable table = new DataTable();

            // Step 1. Creates an instance of DbConnHelper
            DbConnHelpe helper = new DbConnHelpe();

            // Step 2. Open a connection
            SqlConnection conn = helper.OpenConnection();

            // Step 3. Check the state of the connection.
            if (conn.State != ConnectionState.Open)
            {
                MessageBox.Show("Connection failed!");
                return table;
            }

            // NOTE: From this point onwards we are sure that we are connected to the DB.
            // Step 4. Prepare parameters.
            var spParams = new SqlParameter[] { 
                
          
            };

            // Step 5. Create a command.

            SqlDataAdapter sample = new SqlDataAdapter(helper.CreateCommand(conn, "spCountVoteAll", spParams));

            // Step 6. Execute the command
            sample.Fill(table);
            helper.CloseConnection(conn);
            return table;
        }

       
        public void showSection(ComboBox cmbSection)
        {
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
                
          
            };

            // Step 5. Create a command.

            SqlDataAdapter sample = new SqlDataAdapter(helper.CreateCommand(conn, "spShowSection", spParams));

            // Step 6. Execute the command.
            DataTable table = new DataTable();
            sample.Fill(table);

            for (int i = 0; i < table.Rows.Count; i++)
            {
                cmbSection.Items.Add(table.Rows[i]["section_name"]);
            }



            helper.CloseConnection(conn);
        }
        public bool insertStudentToRoom(string id, int section_id)
        {
            // Step 1. Creates an instance of DbConnHelper
            DbConnHelpe helper = new DbConnHelpe();

            // Step 2. Open a connection
            SqlConnection conn = helper.OpenConnection();

            // Step 3. Check the state of the connection.
            if (conn.State != ConnectionState.Open)
            {
                MessageBox.Show("Connection failed!");
                return false;
            }

            // NOTE: From this point onwards we are sure that we are connected to the DB.
            // Step 4. Prepare parameters.
            var spParams = new SqlParameter[] { 
                new SqlParameter("@stud_id",id),
                new SqlParameter("@section_id",section_id)
          
            };

            // Step 5. Create a command.

            SqlCommand cmd = helper.CreateCommand(conn, "spInsertStudentRoom", spParams);

            // Step 6. Execute the command.
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                MessageBox.Show("This student is already assign in room");
                return true;
            }

            
            helper.CloseConnection(conn);
            return false;
        }

        public void updateStudentRoom(string id, int index)
        {
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
                new SqlParameter("@stud_id",id),
                new SqlParameter("@section_id",index)
          
            };

            // Step 5. Create a command.

            SqlCommand cmd = helper.CreateCommand(conn, "spUpdateRoomAssign", spParams);

            // Step 6. Execute the command.
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                MessageBox.Show("Error occured when trying to update");
                return;
            }


            helper.CloseConnection(conn);
            return;
        }

        public int countRecord(string id)
        {
            int recordCount;
            // Step 1. Creates an instance of DbConnHelper
            DbConnHelpe helper = new DbConnHelpe();

            // Step 2. Open a connection
            SqlConnection conn = helper.OpenConnection();

            // Step 3. Check the state of the connection.
            if (conn.State != ConnectionState.Open)
            {
                MessageBox.Show("Connection failed!");
                return 0;
            }

            // NOTE: From this point onwards we are sure that we are connected to the DB.
            // Step 4. Prepare parameters.
            var spParams = new SqlParameter[] { 
                new SqlParameter("@stud_id",id),
          
            };

            // Step 5. Create a command.

            SqlCommand cmd = helper.CreateCommand(conn, "spCountRecord", spParams);

            // Step 6. Execute the command.
            try
            {
                recordCount = (int)cmd.ExecuteScalar();
            }
            catch (Exception)
            {
                MessageBox.Show("Error occured when trying to update");
                return 0;
            }


            helper.CloseConnection(conn);
            return recordCount;
        }
        public int getSectionID(string section_name)
        {
            // Step 1. Creates an instance of DbConnHelper
            DbConnHelpe helper = new DbConnHelpe();

            // Step 2. Open a connection
            SqlConnection conn = helper.OpenConnection();

            // Step 3. Check the state of the connection.
            if (conn.State != ConnectionState.Open)
            {
                MessageBox.Show("Connection failed!");
                return 0;
            }

            // NOTE: From this point onwards we are sure that we are connected to the DB.
            // Step 4. Prepare parameters.
            var spParams = new SqlParameter[] { 
                new SqlParameter("@section_name",section_name)
         
            };

            // Step 5. Create a command.

            SqlCommand cmd = helper.CreateCommand(conn, "spGetSectionID", spParams);

            // Step 6. Execute the command.




            int index = Int32.Parse(cmd.ExecuteScalar().ToString());

            helper.CloseConnection(conn);

            return index;
         
        }

        public int getSectionPopulation(int id)
        {
            // Step 1. Creates an instance of DbConnHelper
            DbConnHelpe helper = new DbConnHelpe();

            // Step 2. Open a connection
            SqlConnection conn = helper.OpenConnection();

            // Step 3. Check the state of the connection.
            if (conn.State != ConnectionState.Open)
            {
                MessageBox.Show("Connection failed!");
                return 0;
            }

            // NOTE: From this point onwards we are sure that we are connected to the DB.
            // Step 4. Prepare parameters.
            var spParams = new SqlParameter[] { 
                new SqlParameter("@section_id",id)
         
            };

            // Step 5. Create a command.

            SqlCommand cmd = helper.CreateCommand(conn, "spShowTotalStudent", spParams);

            // Step 6. Execute the command.




            int index = Int32.Parse(cmd.ExecuteScalar().ToString());

            helper.CloseConnection(conn);

            return index;

        }

        public int getVotedPopulation()
        {
            // Step 1. Creates an instance of DbConnHelper
            DbConnHelpe helper = new DbConnHelpe();

            // Step 2. Open a connection
            SqlConnection conn = helper.OpenConnection();

            // Step 3. Check the state of the connection.
            if (conn.State != ConnectionState.Open)
            {
                MessageBox.Show("Connection failed!");
                return 0;
            }

            // NOTE: From this point onwards we are sure that we are connected to the DB.
            // Step 4. Prepare parameters.
            var spParams = new SqlParameter[] { 
           
         
            };

            // Step 5. Create a command.

            SqlCommand cmd = helper.CreateCommand(conn, "spCountVoted", spParams);

            // Step 6. Execute the command.


            int index = 0;
            try
            {
                index = Int32.Parse(cmd.ExecuteScalar().ToString());
            }
            catch (Exception)
            {
                
            }

            helper.CloseConnection(conn);

            return index;

        }
        public void showPosition(ComboBox cmbPosition)
        {
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
                
          
            };

            // Step 5. Create a command.

            SqlDataAdapter sample = new SqlDataAdapter(helper.CreateCommand(conn, "spShowPosition", spParams));

            // Step 6. Execute the command.
            DataTable table = new DataTable();
            sample.Fill(table);

            for (int i = 0; i < table.Rows.Count; i++)
            {
                cmbPosition.Items.Add(table.Rows[i]["pos_name"]);
            }



            helper.CloseConnection(conn);
        }
        public bool validSubmit(string id, string fname, string mname, string lname, string postal, string stname, string building, string city, string contact, string year)
        {
            if (id == "" || fname == "" || mname == "" || lname == "" || postal == "" || city == "" || building == "" || stname == "" || contact == "")
                return false;

            return true;
        }

        public int addStudent(string id,string fname,string mname,string lname,string postal,string stname,string building,string city,string contact,string year,string date,char gender)
        {
            // Step 1. Creates an instance of DbConnHelper
            DbConnHelpe helper = new DbConnHelpe();

            // Step 2. Open a connection
            SqlConnection conn = helper.OpenConnection();

            // Step 3. Check the state of the connection.
            if (conn.State != ConnectionState.Open)
            {
                MessageBox.Show("Connection failed!");
                return 0;
            }
            if (validSubmit(id,fname,mname,lname,postal,stname,building,city,contact,year) != true)
            {
                MessageBox.Show("Please fill the black");
                return 0;
            }
            // NOTE: From this point onwards we are sure that we are connected to the DB.
            // Step 4. Prepare parameters.
            var spParams = new SqlParameter[] { 
                new SqlParameter("@stud_id",id),
                new SqlParameter("@fname", fname),
                new SqlParameter("@mname", mname),
                new SqlParameter("@lname", lname),
                new SqlParameter("@postalcode", Int32.Parse(postal)),
                new SqlParameter("@stName", stname),
                new SqlParameter("@building_num", building),
                new SqlParameter("@city", city),
                new SqlParameter("@year_level", Int32.Parse(year)),
                new SqlParameter("@contact_num", contact),
                new SqlParameter("@gender",gender),
                new SqlParameter("@bdate",date)
                

            };

            // Step 5. Create a command.
            SqlCommand cmd = helper.CreateCommand(conn, "spAddStudent", spParams);

            // Step 6. Execute the command.
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                MessageBox.Show("This " + id + " Student ID is already existing");
                return 0;
                
            }
            
            helper.CloseConnection(conn);
            return 1;
        }
       
        public DataTable readFileExcel(string filename)
        {

            DataGridView dataGridView1 = new DataGridView();

           
            Excel.Application xlApp;
            Excel.Workbook xlWorkBook;
            Excel.Worksheet xlWorkSheet;
            Excel.Range range;

            string str = "";
            int rCnt;
            int cCnt;
            int rw = 0;
            int cl = 0;
           
           xlApp = new Excel.Application();
           xlWorkBook = xlApp.Workbooks.Open(filename, 0, true, 5, "", "", true, Microsoft.Office.Interop.Excel.XlPlatform.xlWindows, "\t", false, false, 0, true, 1, 0);
           xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
            
           
            range = xlWorkSheet.UsedRange;
            rw = range.Rows.Count;
            cl = range.Columns.Count;
            int count = 0;
            string[] sample = new string[12];
            DataTable table = new DataTable();
            table.Columns.Add("Student ID", typeof(string));
            table.Columns.Add("First Name ", typeof(string));
            table.Columns.Add("Middle Name", typeof(string));
            table.Columns.Add("Last Name", typeof(string));
            table.Columns.Add("Year Level", typeof(string));
            table.Columns.Add("Contact No.", typeof(string));
            table.Columns.Add("Building No#", typeof(string));
            table.Columns.Add("Street Name", typeof(string));
            table.Columns.Add("City", typeof(string));
            table.Columns.Add("Postal Code", typeof(string));
            table.Columns.Add("Gender", typeof(string));
            table.Columns.Add("Birthdate", typeof(string));
            //Get the value in excel file
            for (rCnt = 1; rCnt <= rw; rCnt++)
            {
                count = 0;
                for (cCnt = 1; cCnt <= cl; cCnt++)
                {
                    try
                    {
                        str = getCellValue(xlWorkSheet, rCnt, cCnt);
                    }
                    catch (Exception)
                    {

                    }
                    sample[count] = str;
                    count++;

                }
                //Pass the value of excel row by row
                table.Rows.Add(sample[0], sample[1],sample[2],sample[3],sample[4],sample[5],sample[6],sample[7],sample[8],sample[9],sample[10],sample[11]);
  

            }
            //Get the value of table
            
     
            return table;
        }
        private string getCellValue(Excel.Worksheet Sheet, int Row, int Column)
        {
            string cellValue = Sheet.Cells[Row, Column].Text.ToString();
            return cellValue;
        }
    }
}
