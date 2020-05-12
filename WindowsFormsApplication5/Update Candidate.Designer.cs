namespace WindowsFormsApplication5
{
    partial class Update_Candidate
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.gbStudentInfo = new System.Windows.Forms.GroupBox();
            this.txtyear = new System.Windows.Forms.TextBox();
            this.txtmname = new System.Windows.Forms.TextBox();
            this.txtlname = new System.Windows.Forms.TextBox();
            this.txtfname = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblYearLevel = new System.Windows.Forms.Label();
            this.lblMiddlename = new System.Windows.Forms.Label();
            this.lblLastname = new System.Windows.Forms.Label();
            this.lbl2Firstname = new System.Windows.Forms.Label();
            this.lblStudenID = new System.Windows.Forms.Label();
            this.gbAddress = new System.Windows.Forms.GroupBox();
            this.txtpostal = new System.Windows.Forms.TextBox();
            this.txtcity = new System.Windows.Forms.TextBox();
            this.txtstname = new System.Windows.Forms.TextBox();
            this.txtBuilding = new System.Windows.Forms.TextBox();
            this.lblZipPostal = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblStreetName = new System.Windows.Forms.Label();
            this.lblBuilding = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnbrowse = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.pcbImage = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.cmbPosition = new System.Windows.Forms.ComboBox();
            this.lblPosition = new System.Windows.Forms.Label();
            this.gbStudentInfo.SuspendLayout();
            this.gbAddress.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(65, 18);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(468, 58);
            this.label2.TabIndex = 17;
            this.label2.Text = "Update Candidate";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(60, 155);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 23);
            this.label3.TabIndex = 18;
            this.label3.Text = "Search ";
            // 
            // txtSearch
            // 
            this.txtSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.Location = new System.Drawing.Point(152, 159);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(291, 22);
            this.txtSearch.TabIndex = 19;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            this.txtSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearch_KeyPress);
            // 
            // gbStudentInfo
            // 
            this.gbStudentInfo.BackColor = System.Drawing.Color.Transparent;
            this.gbStudentInfo.Controls.Add(this.txtyear);
            this.gbStudentInfo.Controls.Add(this.txtmname);
            this.gbStudentInfo.Controls.Add(this.txtlname);
            this.gbStudentInfo.Controls.Add(this.txtfname);
            this.gbStudentInfo.Controls.Add(this.txtID);
            this.gbStudentInfo.Controls.Add(this.lblYearLevel);
            this.gbStudentInfo.Controls.Add(this.lblMiddlename);
            this.gbStudentInfo.Controls.Add(this.lblLastname);
            this.gbStudentInfo.Controls.Add(this.lbl2Firstname);
            this.gbStudentInfo.Controls.Add(this.lblStudenID);
            this.gbStudentInfo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbStudentInfo.ForeColor = System.Drawing.Color.Maroon;
            this.gbStudentInfo.Location = new System.Drawing.Point(64, 215);
            this.gbStudentInfo.Margin = new System.Windows.Forms.Padding(4);
            this.gbStudentInfo.Name = "gbStudentInfo";
            this.gbStudentInfo.Padding = new System.Windows.Forms.Padding(4);
            this.gbStudentInfo.Size = new System.Drawing.Size(556, 302);
            this.gbStudentInfo.TabIndex = 21;
            this.gbStudentInfo.TabStop = false;
            this.gbStudentInfo.Text = "Student Information ";
            // 
            // txtyear
            // 
            this.txtyear.Location = new System.Drawing.Point(204, 212);
            this.txtyear.Margin = new System.Windows.Forms.Padding(4);
            this.txtyear.Name = "txtyear";
            this.txtyear.ReadOnly = true;
            this.txtyear.Size = new System.Drawing.Size(291, 32);
            this.txtyear.TabIndex = 7;
            // 
            // txtmname
            // 
            this.txtmname.Location = new System.Drawing.Point(204, 172);
            this.txtmname.Margin = new System.Windows.Forms.Padding(4);
            this.txtmname.Name = "txtmname";
            this.txtmname.ReadOnly = true;
            this.txtmname.Size = new System.Drawing.Size(291, 32);
            this.txtmname.TabIndex = 7;
            // 
            // txtlname
            // 
            this.txtlname.Location = new System.Drawing.Point(204, 134);
            this.txtlname.Margin = new System.Windows.Forms.Padding(4);
            this.txtlname.Name = "txtlname";
            this.txtlname.ReadOnly = true;
            this.txtlname.Size = new System.Drawing.Size(291, 32);
            this.txtlname.TabIndex = 8;
            // 
            // txtfname
            // 
            this.txtfname.Location = new System.Drawing.Point(204, 95);
            this.txtfname.Margin = new System.Windows.Forms.Padding(4);
            this.txtfname.Name = "txtfname";
            this.txtfname.ReadOnly = true;
            this.txtfname.Size = new System.Drawing.Size(291, 32);
            this.txtfname.TabIndex = 7;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(204, 54);
            this.txtID.Margin = new System.Windows.Forms.Padding(4);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(291, 32);
            this.txtID.TabIndex = 6;
            // 
            // lblYearLevel
            // 
            this.lblYearLevel.AutoSize = true;
            this.lblYearLevel.BackColor = System.Drawing.Color.Transparent;
            this.lblYearLevel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYearLevel.ForeColor = System.Drawing.Color.Maroon;
            this.lblYearLevel.Location = new System.Drawing.Point(48, 212);
            this.lblYearLevel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblYearLevel.Name = "lblYearLevel";
            this.lblYearLevel.Size = new System.Drawing.Size(115, 23);
            this.lblYearLevel.TabIndex = 4;
            this.lblYearLevel.Text = "Year Level";
            // 
            // lblMiddlename
            // 
            this.lblMiddlename.AutoSize = true;
            this.lblMiddlename.BackColor = System.Drawing.Color.Transparent;
            this.lblMiddlename.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMiddlename.ForeColor = System.Drawing.Color.Maroon;
            this.lblMiddlename.Location = new System.Drawing.Point(47, 172);
            this.lblMiddlename.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMiddlename.Name = "lblMiddlename";
            this.lblMiddlename.Size = new System.Drawing.Size(134, 23);
            this.lblMiddlename.TabIndex = 3;
            this.lblMiddlename.Text = "Middlename";
            // 
            // lblLastname
            // 
            this.lblLastname.AutoSize = true;
            this.lblLastname.BackColor = System.Drawing.Color.Transparent;
            this.lblLastname.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastname.ForeColor = System.Drawing.Color.Maroon;
            this.lblLastname.Location = new System.Drawing.Point(48, 134);
            this.lblLastname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLastname.Name = "lblLastname";
            this.lblLastname.Size = new System.Drawing.Size(106, 23);
            this.lblLastname.TabIndex = 2;
            this.lblLastname.Text = "Lastname";
            // 
            // lbl2Firstname
            // 
            this.lbl2Firstname.AutoSize = true;
            this.lbl2Firstname.BackColor = System.Drawing.Color.Transparent;
            this.lbl2Firstname.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2Firstname.ForeColor = System.Drawing.Color.Maroon;
            this.lbl2Firstname.Location = new System.Drawing.Point(47, 100);
            this.lbl2Firstname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl2Firstname.Name = "lbl2Firstname";
            this.lbl2Firstname.Size = new System.Drawing.Size(102, 23);
            this.lbl2Firstname.TabIndex = 1;
            this.lbl2Firstname.Text = "Firstname";
            // 
            // lblStudenID
            // 
            this.lblStudenID.AutoSize = true;
            this.lblStudenID.BackColor = System.Drawing.Color.Transparent;
            this.lblStudenID.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudenID.ForeColor = System.Drawing.Color.Maroon;
            this.lblStudenID.Location = new System.Drawing.Point(47, 59);
            this.lblStudenID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStudenID.Name = "lblStudenID";
            this.lblStudenID.Size = new System.Drawing.Size(116, 23);
            this.lblStudenID.TabIndex = 0;
            this.lblStudenID.Text = "Student I.D";
            // 
            // gbAddress
            // 
            this.gbAddress.BackColor = System.Drawing.Color.Transparent;
            this.gbAddress.Controls.Add(this.txtpostal);
            this.gbAddress.Controls.Add(this.txtcity);
            this.gbAddress.Controls.Add(this.txtstname);
            this.gbAddress.Controls.Add(this.txtBuilding);
            this.gbAddress.Controls.Add(this.lblZipPostal);
            this.gbAddress.Controls.Add(this.lblCity);
            this.gbAddress.Controls.Add(this.lblStreetName);
            this.gbAddress.Controls.Add(this.lblBuilding);
            this.gbAddress.Controls.Add(this.label1);
            this.gbAddress.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbAddress.ForeColor = System.Drawing.Color.Maroon;
            this.gbAddress.Location = new System.Drawing.Point(64, 524);
            this.gbAddress.Margin = new System.Windows.Forms.Padding(4);
            this.gbAddress.Name = "gbAddress";
            this.gbAddress.Padding = new System.Windows.Forms.Padding(4);
            this.gbAddress.Size = new System.Drawing.Size(556, 207);
            this.gbAddress.TabIndex = 22;
            this.gbAddress.TabStop = false;
            this.gbAddress.Text = "Address";
            // 
            // txtpostal
            // 
            this.txtpostal.Location = new System.Drawing.Point(249, 149);
            this.txtpostal.Margin = new System.Windows.Forms.Padding(4);
            this.txtpostal.Name = "txtpostal";
            this.txtpostal.ReadOnly = true;
            this.txtpostal.Size = new System.Drawing.Size(291, 32);
            this.txtpostal.TabIndex = 11;
            // 
            // txtcity
            // 
            this.txtcity.Location = new System.Drawing.Point(249, 111);
            this.txtcity.Margin = new System.Windows.Forms.Padding(4);
            this.txtcity.Name = "txtcity";
            this.txtcity.ReadOnly = true;
            this.txtcity.Size = new System.Drawing.Size(291, 32);
            this.txtcity.TabIndex = 12;
            // 
            // txtstname
            // 
            this.txtstname.Location = new System.Drawing.Point(249, 71);
            this.txtstname.Margin = new System.Windows.Forms.Padding(4);
            this.txtstname.Name = "txtstname";
            this.txtstname.ReadOnly = true;
            this.txtstname.Size = new System.Drawing.Size(291, 32);
            this.txtstname.TabIndex = 10;
            // 
            // txtBuilding
            // 
            this.txtBuilding.Location = new System.Drawing.Point(249, 31);
            this.txtBuilding.Margin = new System.Windows.Forms.Padding(4);
            this.txtBuilding.Name = "txtBuilding";
            this.txtBuilding.ReadOnly = true;
            this.txtBuilding.Size = new System.Drawing.Size(291, 32);
            this.txtBuilding.TabIndex = 9;
            // 
            // lblZipPostal
            // 
            this.lblZipPostal.AutoSize = true;
            this.lblZipPostal.BackColor = System.Drawing.Color.Transparent;
            this.lblZipPostal.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblZipPostal.ForeColor = System.Drawing.Color.Maroon;
            this.lblZipPostal.Location = new System.Drawing.Point(47, 156);
            this.lblZipPostal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblZipPostal.Name = "lblZipPostal";
            this.lblZipPostal.Size = new System.Drawing.Size(159, 19);
            this.lblZipPostal.TabIndex = 7;
            this.lblZipPostal.Text = "Postal code/Zip Code";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.BackColor = System.Drawing.Color.Transparent;
            this.lblCity.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCity.ForeColor = System.Drawing.Color.Maroon;
            this.lblCity.Location = new System.Drawing.Point(48, 118);
            this.lblCity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(47, 23);
            this.lblCity.TabIndex = 6;
            this.lblCity.Text = "City";
            // 
            // lblStreetName
            // 
            this.lblStreetName.AutoSize = true;
            this.lblStreetName.BackColor = System.Drawing.Color.Transparent;
            this.lblStreetName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStreetName.ForeColor = System.Drawing.Color.Maroon;
            this.lblStreetName.Location = new System.Drawing.Point(47, 84);
            this.lblStreetName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStreetName.Name = "lblStreetName";
            this.lblStreetName.Size = new System.Drawing.Size(133, 23);
            this.lblStreetName.TabIndex = 5;
            this.lblStreetName.Text = "Street Name";
            // 
            // lblBuilding
            // 
            this.lblBuilding.AutoSize = true;
            this.lblBuilding.BackColor = System.Drawing.Color.Transparent;
            this.lblBuilding.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuilding.ForeColor = System.Drawing.Color.Maroon;
            this.lblBuilding.Location = new System.Drawing.Point(47, 43);
            this.lblBuilding.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBuilding.Name = "lblBuilding";
            this.lblBuilding.Size = new System.Drawing.Size(97, 23);
            this.lblBuilding.TabIndex = 4;
            this.lblBuilding.Text = "Building#";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 54);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 23);
            this.label1.TabIndex = 0;
            // 
            // btnbrowse
            // 
            this.btnbrowse.BackColor = System.Drawing.Color.Maroon;
            this.btnbrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnbrowse.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbrowse.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnbrowse.Location = new System.Drawing.Point(779, 420);
            this.btnbrowse.Margin = new System.Windows.Forms.Padding(4);
            this.btnbrowse.Name = "btnbrowse";
            this.btnbrowse.Size = new System.Drawing.Size(100, 39);
            this.btnbrowse.TabIndex = 23;
            this.btnbrowse.Text = "Browse";
            this.btnbrowse.UseVisualStyleBackColor = false;
            this.btnbrowse.Visible = false;
            this.btnbrowse.Click += new System.EventHandler(this.btnbrowse_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Maroon;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCancel.Location = new System.Drawing.Point(955, 639);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(137, 50);
            this.btnCancel.TabIndex = 26;
            this.btnCancel.Text = "Delete";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Maroon;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAdd.Location = new System.Drawing.Point(779, 639);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(168, 50);
            this.btnAdd.TabIndex = 25;
            this.btnAdd.Text = "Update";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // pcbImage
            // 
            this.pcbImage.BackColor = System.Drawing.Color.Transparent;
            this.pcbImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pcbImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pcbImage.Location = new System.Drawing.Point(779, 215);
            this.pcbImage.Margin = new System.Windows.Forms.Padding(4);
            this.pcbImage.Name = "pcbImage";
            this.pcbImage.Size = new System.Drawing.Size(271, 198);
            this.pcbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbImage.TabIndex = 24;
            this.pcbImage.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Image = global::WindowsFormsApplication5.Properties.Resources.Search_30px;
            this.pictureBox2.Location = new System.Drawing.Point(420, 159);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(24, 22);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 20;
            this.pictureBox2.TabStop = false;
            // 
            // cmbPosition
            // 
            this.cmbPosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPosition.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPosition.FormattingEnabled = true;
            this.cmbPosition.Location = new System.Drawing.Point(779, 471);
            this.cmbPosition.Margin = new System.Windows.Forms.Padding(4);
            this.cmbPosition.Name = "cmbPosition";
            this.cmbPosition.Size = new System.Drawing.Size(271, 29);
            this.cmbPosition.TabIndex = 28;
            // 
            // lblPosition
            // 
            this.lblPosition.AutoSize = true;
            this.lblPosition.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPosition.ForeColor = System.Drawing.Color.Maroon;
            this.lblPosition.Location = new System.Drawing.Point(693, 475);
            this.lblPosition.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(81, 23);
            this.lblPosition.TabIndex = 27;
            this.lblPosition.Text = "Position";
            // 
            // Update_Candidate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cmbPosition);
            this.Controls.Add(this.lblPosition);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.pcbImage);
            this.Controls.Add(this.btnbrowse);
            this.Controls.Add(this.gbAddress);
            this.Controls.Add(this.gbStudentInfo);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Update_Candidate";
            this.Size = new System.Drawing.Size(1417, 756);
            this.Load += new System.EventHandler(this.Update_Candidate_Load);
            this.gbStudentInfo.ResumeLayout(false);
            this.gbStudentInfo.PerformLayout();
            this.gbAddress.ResumeLayout(false);
            this.gbAddress.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.GroupBox gbStudentInfo;
        private System.Windows.Forms.TextBox txtyear;
        private System.Windows.Forms.TextBox txtmname;
        private System.Windows.Forms.TextBox txtlname;
        private System.Windows.Forms.TextBox txtfname;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblYearLevel;
        private System.Windows.Forms.Label lblMiddlename;
        private System.Windows.Forms.Label lblLastname;
        private System.Windows.Forms.Label lbl2Firstname;
        private System.Windows.Forms.Label lblStudenID;
        private System.Windows.Forms.GroupBox gbAddress;
        private System.Windows.Forms.TextBox txtpostal;
        private System.Windows.Forms.TextBox txtcity;
        private System.Windows.Forms.TextBox txtstname;
        private System.Windows.Forms.TextBox txtBuilding;
        private System.Windows.Forms.Label lblZipPostal;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblStreetName;
        private System.Windows.Forms.Label lblBuilding;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pcbImage;
        private System.Windows.Forms.Button btnbrowse;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox cmbPosition;
        private System.Windows.Forms.Label lblPosition;
    }
}
