namespace OOPAssignment
{
    partial class College
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(College));
            this.btnAddStud = new System.Windows.Forms.Button();
            this.btnAddLect = new System.Windows.Forms.Button();
            this.btnShowStud = new System.Windows.Forms.Button();
            this.btnShowLect = new System.Windows.Forms.Button();
            this.dgvStudent = new System.Windows.Forms.DataGridView();
            this.studentIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surnameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cityDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countryDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pPSNumberDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNumberDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eMailDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.degreeTitleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dgvLecturer = new System.Windows.Forms.DataGridView();
            this.lecturerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblTitleDgvs = new System.Windows.Forms.Label();
            this.pnlScreen = new System.Windows.Forms.Panel();
            this.btnStart = new System.Windows.Forms.Button();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnIconSearch = new System.Windows.Forms.Button();
            this.pnlSearch = new System.Windows.Forms.Panel();
            this.cmstripStudent = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showStudentDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmstripLecturer = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showLecturerDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmstripCollege = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ntIconCollege = new System.Windows.Forms.NotifyIcon(this.components);
            this.staffIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pPSNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eMailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salaryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subjectTaughtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLecturer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lecturerBindingSource)).BeginInit();
            this.pnlScreen.SuspendLayout();
            this.cmstripStudent.SuspendLayout();
            this.cmstripLecturer.SuspendLayout();
            this.cmstripCollege.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAddStud
            // 
            this.btnAddStud.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAddStud.AutoSize = true;
            this.btnAddStud.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddStud.Location = new System.Drawing.Point(12, 318);
            this.btnAddStud.Name = "btnAddStud";
            this.btnAddStud.Size = new System.Drawing.Size(101, 30);
            this.btnAddStud.TabIndex = 0;
            this.btnAddStud.Text = "Add Student";
            this.btnAddStud.UseVisualStyleBackColor = true;
            this.btnAddStud.Visible = false;
            this.btnAddStud.Click += new System.EventHandler(this.btnAddStud_Click);
            // 
            // btnAddLect
            // 
            this.btnAddLect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddLect.AutoSize = true;
            this.btnAddLect.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddLect.Location = new System.Drawing.Point(398, 318);
            this.btnAddLect.Name = "btnAddLect";
            this.btnAddLect.Size = new System.Drawing.Size(101, 30);
            this.btnAddLect.TabIndex = 1;
            this.btnAddLect.Text = "Add Lecturer";
            this.btnAddLect.UseVisualStyleBackColor = true;
            this.btnAddLect.Visible = false;
            this.btnAddLect.Click += new System.EventHandler(this.btnAddLect_Click);
            // 
            // btnShowStud
            // 
            this.btnShowStud.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnShowStud.AutoSize = true;
            this.btnShowStud.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowStud.Location = new System.Drawing.Point(205, 318);
            this.btnShowStud.Name = "btnShowStud";
            this.btnShowStud.Size = new System.Drawing.Size(101, 30);
            this.btnShowStud.TabIndex = 2;
            this.btnShowStud.Text = "Show Students";
            this.btnShowStud.UseVisualStyleBackColor = true;
            this.btnShowStud.Visible = false;
            this.btnShowStud.Click += new System.EventHandler(this.btnShowStud_Click);
            // 
            // btnShowLect
            // 
            this.btnShowLect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnShowLect.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowLect.Location = new System.Drawing.Point(591, 318);
            this.btnShowLect.Name = "btnShowLect";
            this.btnShowLect.Size = new System.Drawing.Size(101, 30);
            this.btnShowLect.TabIndex = 3;
            this.btnShowLect.Text = "Show Lecturers";
            this.btnShowLect.UseVisualStyleBackColor = true;
            this.btnShowLect.Visible = false;
            this.btnShowLect.Click += new System.EventHandler(this.btnShowLect_Click);
            // 
            // dgvStudent
            // 
            this.dgvStudent.AllowUserToAddRows = false;
            this.dgvStudent.AllowUserToDeleteRows = false;
            this.dgvStudent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvStudent.AutoGenerateColumns = false;
            this.dgvStudent.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStudent.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvStudent.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvStudent.ColumnHeadersHeight = 34;
            this.dgvStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvStudent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.studentIdDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn1,
            this.surnameDataGridViewTextBoxColumn1,
            this.addressDataGridViewTextBoxColumn1,
            this.cityDataGridViewTextBoxColumn1,
            this.countryDataGridViewTextBoxColumn1,
            this.pPSNumberDataGridViewTextBoxColumn1,
            this.phoneNumberDataGridViewTextBoxColumn1,
            this.eMailDataGridViewTextBoxColumn1,
            this.studentStatusDataGridViewTextBoxColumn,
            this.degreeTitleDataGridViewTextBoxColumn});
            this.dgvStudent.DataSource = this.studentBindingSource;
            this.dgvStudent.Location = new System.Drawing.Point(12, 30);
            this.dgvStudent.Name = "dgvStudent";
            this.dgvStudent.ReadOnly = true;
            this.dgvStudent.Size = new System.Drawing.Size(681, 282);
            this.dgvStudent.TabIndex = 5;
            this.dgvStudent.Visible = false;
            this.dgvStudent.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvStudent_ColumnHeaderMouseClick);
            this.dgvStudent.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvStudent_RowHeaderMouseClick);
            // 
            // studentIdDataGridViewTextBoxColumn
            // 
            this.studentIdDataGridViewTextBoxColumn.DataPropertyName = "StudentId";
            this.studentIdDataGridViewTextBoxColumn.HeaderText = "Student ID";
            this.studentIdDataGridViewTextBoxColumn.Name = "studentIdDataGridViewTextBoxColumn";
            this.studentIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // firstNameDataGridViewTextBoxColumn1
            // 
            this.firstNameDataGridViewTextBoxColumn1.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn1.HeaderText = "First Name";
            this.firstNameDataGridViewTextBoxColumn1.Name = "firstNameDataGridViewTextBoxColumn1";
            this.firstNameDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // surnameDataGridViewTextBoxColumn1
            // 
            this.surnameDataGridViewTextBoxColumn1.DataPropertyName = "Surname";
            this.surnameDataGridViewTextBoxColumn1.HeaderText = "Surname";
            this.surnameDataGridViewTextBoxColumn1.Name = "surnameDataGridViewTextBoxColumn1";
            this.surnameDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // addressDataGridViewTextBoxColumn1
            // 
            this.addressDataGridViewTextBoxColumn1.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn1.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn1.Name = "addressDataGridViewTextBoxColumn1";
            this.addressDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // cityDataGridViewTextBoxColumn1
            // 
            this.cityDataGridViewTextBoxColumn1.DataPropertyName = "City";
            this.cityDataGridViewTextBoxColumn1.HeaderText = "City";
            this.cityDataGridViewTextBoxColumn1.Name = "cityDataGridViewTextBoxColumn1";
            this.cityDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // countryDataGridViewTextBoxColumn1
            // 
            this.countryDataGridViewTextBoxColumn1.DataPropertyName = "Country";
            this.countryDataGridViewTextBoxColumn1.HeaderText = "Country";
            this.countryDataGridViewTextBoxColumn1.Name = "countryDataGridViewTextBoxColumn1";
            this.countryDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // pPSNumberDataGridViewTextBoxColumn1
            // 
            this.pPSNumberDataGridViewTextBoxColumn1.DataPropertyName = "PPSNumber";
            this.pPSNumberDataGridViewTextBoxColumn1.HeaderText = "PPS Number";
            this.pPSNumberDataGridViewTextBoxColumn1.Name = "pPSNumberDataGridViewTextBoxColumn1";
            this.pPSNumberDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // phoneNumberDataGridViewTextBoxColumn1
            // 
            this.phoneNumberDataGridViewTextBoxColumn1.DataPropertyName = "PhoneNumber";
            this.phoneNumberDataGridViewTextBoxColumn1.HeaderText = "Phone Number";
            this.phoneNumberDataGridViewTextBoxColumn1.Name = "phoneNumberDataGridViewTextBoxColumn1";
            this.phoneNumberDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // eMailDataGridViewTextBoxColumn1
            // 
            this.eMailDataGridViewTextBoxColumn1.DataPropertyName = "EMail";
            this.eMailDataGridViewTextBoxColumn1.HeaderText = "E-Mail";
            this.eMailDataGridViewTextBoxColumn1.Name = "eMailDataGridViewTextBoxColumn1";
            this.eMailDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // studentStatusDataGridViewTextBoxColumn
            // 
            this.studentStatusDataGridViewTextBoxColumn.DataPropertyName = "StudentStatus";
            this.studentStatusDataGridViewTextBoxColumn.HeaderText = "Student Status";
            this.studentStatusDataGridViewTextBoxColumn.Name = "studentStatusDataGridViewTextBoxColumn";
            this.studentStatusDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // degreeTitleDataGridViewTextBoxColumn
            // 
            this.degreeTitleDataGridViewTextBoxColumn.DataPropertyName = "DegreeTitle";
            this.degreeTitleDataGridViewTextBoxColumn.HeaderText = "Degree Title";
            this.degreeTitleDataGridViewTextBoxColumn.Name = "degreeTitleDataGridViewTextBoxColumn";
            this.degreeTitleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataSource = typeof(OOPAssignment.Student);
            // 
            // dgvLecturer
            // 
            this.dgvLecturer.AllowUserToAddRows = false;
            this.dgvLecturer.AllowUserToDeleteRows = false;
            this.dgvLecturer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvLecturer.AutoGenerateColumns = false;
            this.dgvLecturer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLecturer.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvLecturer.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvLecturer.ColumnHeadersHeight = 34;
            this.dgvLecturer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvLecturer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.staffIdDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.surnameDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.cityDataGridViewTextBoxColumn,
            this.countryDataGridViewTextBoxColumn,
            this.pPSNumberDataGridViewTextBoxColumn,
            this.phoneNumberDataGridViewTextBoxColumn,
            this.eMailDataGridViewTextBoxColumn,
            this.salaryDataGridViewTextBoxColumn,
            this.subjectTaughtDataGridViewTextBoxColumn});
            this.dgvLecturer.DataSource = this.lecturerBindingSource;
            this.dgvLecturer.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.dgvLecturer.Location = new System.Drawing.Point(12, 30);
            this.dgvLecturer.Name = "dgvLecturer";
            this.dgvLecturer.ReadOnly = true;
            this.dgvLecturer.Size = new System.Drawing.Size(681, 282);
            this.dgvLecturer.TabIndex = 6;
            this.dgvLecturer.Visible = false;
            this.dgvLecturer.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvLecturer_ColumnHeaderMouseClick);
            this.dgvLecturer.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvLecturer_RowHeaderMouseClick);
            // 
            // lecturerBindingSource
            // 
            this.lecturerBindingSource.DataSource = typeof(OOPAssignment.Lecturer);
            // 
            // lblTitleDgvs
            // 
            this.lblTitleDgvs.AutoSize = true;
            this.lblTitleDgvs.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleDgvs.Location = new System.Drawing.Point(13, 13);
            this.lblTitleDgvs.Name = "lblTitleDgvs";
            this.lblTitleDgvs.Size = new System.Drawing.Size(38, 13);
            this.lblTitleDgvs.TabIndex = 7;
            this.lblTitleDgvs.Text = "label1";
            this.lblTitleDgvs.Visible = false;
            // 
            // pnlScreen
            // 
            this.pnlScreen.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlScreen.BackColor = System.Drawing.Color.RoyalBlue;
            this.pnlScreen.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlScreen.BackgroundImage")));
            this.pnlScreen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pnlScreen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlScreen.Controls.Add(this.btnStart);
            this.pnlScreen.Controls.Add(this.lblWelcome);
            this.pnlScreen.Location = new System.Drawing.Point(12, 29);
            this.pnlScreen.Name = "pnlScreen";
            this.pnlScreen.Size = new System.Drawing.Size(681, 283);
            this.pnlScreen.TabIndex = 8;
            // 
            // btnStart
            // 
            this.btnStart.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnStart.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnStart.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(255, 239);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(174, 23);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblWelcome
            // 
            this.lblWelcome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.BackColor = System.Drawing.Color.Transparent;
            this.lblWelcome.Font = new System.Drawing.Font("Monotype Corsiva", 34F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(159, 64);
            this.lblWelcome.MaximumSize = new System.Drawing.Size(500, 200);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(366, 110);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Welcome to College \r\nOOP Assessment\r\n";
            this.lblWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.Location = new System.Drawing.Point(457, 4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(196, 22);
            this.txtSearch.TabIndex = 9;
            this.txtSearch.Visible = false;
            this.txtSearch.Enter += new System.EventHandler(this.txtSearch_Enter);
            this.txtSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearch_KeyPress);
            this.txtSearch.Leave += new System.EventHandler(this.txtSearch_Leave);
            // 
            // btnIconSearch
            // 
            this.btnIconSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnIconSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnIconSearch.Image")));
            this.btnIconSearch.Location = new System.Drawing.Point(659, 3);
            this.btnIconSearch.Name = "btnIconSearch";
            this.btnIconSearch.Size = new System.Drawing.Size(27, 23);
            this.btnIconSearch.TabIndex = 10;
            this.btnIconSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnIconSearch.UseVisualStyleBackColor = true;
            this.btnIconSearch.Visible = false;
            this.btnIconSearch.Click += new System.EventHandler(this.btnIconSearch_Click);
            // 
            // pnlSearch
            // 
            this.pnlSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlSearch.BackColor = System.Drawing.SystemColors.MenuBar;
            this.pnlSearch.Location = new System.Drawing.Point(454, 2);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Size = new System.Drawing.Size(242, 24);
            this.pnlSearch.TabIndex = 11;
            // 
            // cmstripStudent
            // 
            this.cmstripStudent.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showStudentDetailsToolStripMenuItem});
            this.cmstripStudent.Name = "cmsStudent";
            this.cmstripStudent.Size = new System.Drawing.Size(184, 26);
            // 
            // showStudentDetailsToolStripMenuItem
            // 
            this.showStudentDetailsToolStripMenuItem.Name = "showStudentDetailsToolStripMenuItem";
            this.showStudentDetailsToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.showStudentDetailsToolStripMenuItem.Text = "Show student details";
            this.showStudentDetailsToolStripMenuItem.Click += new System.EventHandler(this.showStudentDetailsToolStripMenuItem_Click);
            // 
            // cmstripLecturer
            // 
            this.cmstripLecturer.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showLecturerDetailsToolStripMenuItem});
            this.cmstripLecturer.Name = "cmstripLecturer";
            this.cmstripLecturer.Size = new System.Drawing.Size(184, 26);
            // 
            // showLecturerDetailsToolStripMenuItem
            // 
            this.showLecturerDetailsToolStripMenuItem.Name = "showLecturerDetailsToolStripMenuItem";
            this.showLecturerDetailsToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.showLecturerDetailsToolStripMenuItem.Text = "Show lecturer details";
            this.showLecturerDetailsToolStripMenuItem.Click += new System.EventHandler(this.showLecturerDetailsToolStripMenuItem_Click);
            // 
            // cmstripCollege
            // 
            this.cmstripCollege.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showToolStripMenuItem,
            this.hideToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.cmstripCollege.Name = "cmstripCollege";
            this.cmstripCollege.Size = new System.Drawing.Size(104, 70);
            // 
            // showToolStripMenuItem
            // 
            this.showToolStripMenuItem.Name = "showToolStripMenuItem";
            this.showToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.showToolStripMenuItem.Text = "Show";
            this.showToolStripMenuItem.Click += new System.EventHandler(this.showToolStripMenuItem_Click);
            // 
            // hideToolStripMenuItem
            // 
            this.hideToolStripMenuItem.Name = "hideToolStripMenuItem";
            this.hideToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.hideToolStripMenuItem.Text = "Hide";
            this.hideToolStripMenuItem.Click += new System.EventHandler(this.hideToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // ntIconCollege
            // 
            this.ntIconCollege.ContextMenuStrip = this.cmstripCollege;
            this.ntIconCollege.Icon = ((System.Drawing.Icon)(resources.GetObject("ntIconCollege.Icon")));
            this.ntIconCollege.Text = "College";
            this.ntIconCollege.Visible = true;
            // 
            // staffIdDataGridViewTextBoxColumn
            // 
            this.staffIdDataGridViewTextBoxColumn.DataPropertyName = "StaffId";
            this.staffIdDataGridViewTextBoxColumn.HeaderText = "Staff ID";
            this.staffIdDataGridViewTextBoxColumn.Name = "staffIdDataGridViewTextBoxColumn";
            this.staffIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "First Name";
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            this.firstNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // surnameDataGridViewTextBoxColumn
            // 
            this.surnameDataGridViewTextBoxColumn.DataPropertyName = "Surname";
            this.surnameDataGridViewTextBoxColumn.HeaderText = "Surname";
            this.surnameDataGridViewTextBoxColumn.Name = "surnameDataGridViewTextBoxColumn";
            this.surnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cityDataGridViewTextBoxColumn
            // 
            this.cityDataGridViewTextBoxColumn.DataPropertyName = "City";
            this.cityDataGridViewTextBoxColumn.HeaderText = "City";
            this.cityDataGridViewTextBoxColumn.Name = "cityDataGridViewTextBoxColumn";
            this.cityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // countryDataGridViewTextBoxColumn
            // 
            this.countryDataGridViewTextBoxColumn.DataPropertyName = "Country";
            this.countryDataGridViewTextBoxColumn.HeaderText = "Country";
            this.countryDataGridViewTextBoxColumn.Name = "countryDataGridViewTextBoxColumn";
            this.countryDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pPSNumberDataGridViewTextBoxColumn
            // 
            this.pPSNumberDataGridViewTextBoxColumn.DataPropertyName = "PPSNumber";
            this.pPSNumberDataGridViewTextBoxColumn.HeaderText = "PPS Number";
            this.pPSNumberDataGridViewTextBoxColumn.Name = "pPSNumberDataGridViewTextBoxColumn";
            this.pPSNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // phoneNumberDataGridViewTextBoxColumn
            // 
            this.phoneNumberDataGridViewTextBoxColumn.DataPropertyName = "PhoneNumber";
            this.phoneNumberDataGridViewTextBoxColumn.HeaderText = "Phone Number";
            this.phoneNumberDataGridViewTextBoxColumn.Name = "phoneNumberDataGridViewTextBoxColumn";
            this.phoneNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // eMailDataGridViewTextBoxColumn
            // 
            this.eMailDataGridViewTextBoxColumn.DataPropertyName = "EMail";
            this.eMailDataGridViewTextBoxColumn.HeaderText = "E-Mail";
            this.eMailDataGridViewTextBoxColumn.Name = "eMailDataGridViewTextBoxColumn";
            this.eMailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // salaryDataGridViewTextBoxColumn
            // 
            this.salaryDataGridViewTextBoxColumn.DataPropertyName = "Salary";
            this.salaryDataGridViewTextBoxColumn.HeaderText = "Salary in €";
            this.salaryDataGridViewTextBoxColumn.Name = "salaryDataGridViewTextBoxColumn";
            this.salaryDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // subjectTaughtDataGridViewTextBoxColumn
            // 
            this.subjectTaughtDataGridViewTextBoxColumn.DataPropertyName = "SubjectTaught";
            this.subjectTaughtDataGridViewTextBoxColumn.HeaderText = "Subject(s) Taught";
            this.subjectTaughtDataGridViewTextBoxColumn.Name = "subjectTaughtDataGridViewTextBoxColumn";
            this.subjectTaughtDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // College
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(705, 360);
            this.Controls.Add(this.pnlScreen);
            this.Controls.Add(this.btnShowStud);
            this.Controls.Add(this.btnIconSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblTitleDgvs);
            this.Controls.Add(this.dgvLecturer);
            this.Controls.Add(this.dgvStudent);
            this.Controls.Add(this.btnShowLect);
            this.Controls.Add(this.btnAddLect);
            this.Controls.Add(this.btnAddStud);
            this.Controls.Add(this.pnlSearch);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "College";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "College - OOP Assessment";
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLecturer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lecturerBindingSource)).EndInit();
            this.pnlScreen.ResumeLayout(false);
            this.pnlScreen.PerformLayout();
            this.cmstripStudent.ResumeLayout(false);
            this.cmstripLecturer.ResumeLayout(false);
            this.cmstripCollege.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddStud;
        private System.Windows.Forms.Button btnAddLect;
        private System.Windows.Forms.Button btnShowStud;
        private System.Windows.Forms.Button btnShowLect;
        private System.Windows.Forms.DataGridView dgvStudent;
        private System.Windows.Forms.DataGridView dgvLecturer;
        private System.Windows.Forms.Label lblTitleDgvs;
        private System.Windows.Forms.Panel pnlScreen;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnIconSearch;
        private System.Windows.Forms.Panel pnlSearch;
        private System.Windows.Forms.BindingSource lecturerBindingSource;
        private System.Windows.Forms.ContextMenuStrip cmstripStudent;
        private System.Windows.Forms.ToolStripMenuItem showStudentDetailsToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn surnameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn countryDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn pPSNumberDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumberDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn eMailDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentStatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn degreeTitleDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private System.Windows.Forms.ContextMenuStrip cmstripLecturer;
        private System.Windows.Forms.ToolStripMenuItem showLecturerDetailsToolStripMenuItem;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.ContextMenuStrip cmstripCollege;
        private System.Windows.Forms.ToolStripMenuItem showToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hideToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.NotifyIcon ntIconCollege;
        private System.Windows.Forms.DataGridViewTextBoxColumn staffIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn surnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pPSNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eMailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salaryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subjectTaughtDataGridViewTextBoxColumn;
    }
}

