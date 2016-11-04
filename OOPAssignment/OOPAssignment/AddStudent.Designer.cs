namespace OOPAssignment
{
    partial class AddStudent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddStudent));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAddStud = new System.Windows.Forms.Button();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.txtDegree = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblDegree = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtPPS = new System.Windows.Forms.TextBox();
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.txtFirst = new System.Windows.Forms.TextBox();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblPPS = new System.Windows.Forms.Label();
            this.lblCountry = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.lblFirst = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAddStud);
            this.groupBox1.Controls.Add(this.cmbStatus);
            this.groupBox1.Controls.Add(this.txtDegree);
            this.groupBox1.Controls.Add(this.txtId);
            this.groupBox1.Controls.Add(this.lblStatus);
            this.groupBox1.Controls.Add(this.lblDegree);
            this.groupBox1.Controls.Add(this.lblId);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.txtPhone);
            this.groupBox1.Controls.Add(this.txtPPS);
            this.groupBox1.Controls.Add(this.txtCountry);
            this.groupBox1.Controls.Add(this.txtCity);
            this.groupBox1.Controls.Add(this.txtAddress);
            this.groupBox1.Controls.Add(this.txtSurname);
            this.groupBox1.Controls.Add(this.txtFirst);
            this.groupBox1.Controls.Add(this.lblCity);
            this.groupBox1.Controls.Add(this.lblEmail);
            this.groupBox1.Controls.Add(this.lblPhone);
            this.groupBox1.Controls.Add(this.lblPPS);
            this.groupBox1.Controls.Add(this.lblCountry);
            this.groupBox1.Controls.Add(this.lblAddress);
            this.groupBox1.Controls.Add(this.lblSurname);
            this.groupBox1.Controls.Add(this.lblFirst);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(683, 391);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Student Details";
            // 
            // btnAddStud
            // 
            this.btnAddStud.Location = new System.Drawing.Point(478, 205);
            this.btnAddStud.Name = "btnAddStud";
            this.btnAddStud.Size = new System.Drawing.Size(180, 41);
            this.btnAddStud.TabIndex = 22;
            this.btnAddStud.Text = "Add Student";
            this.btnAddStud.UseVisualStyleBackColor = true;
            this.btnAddStud.Click += new System.EventHandler(this.btnAddStud_Click);
            // 
            // cmbStatus
            // 
            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "UnderGrad",
            "PostGrad"});
            this.cmbStatus.Location = new System.Drawing.Point(478, 115);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(180, 21);
            this.cmbStatus.TabIndex = 21;
            // 
            // txtDegree
            // 
            this.txtDegree.Location = new System.Drawing.Point(478, 75);
            this.txtDegree.Name = "txtDegree";
            this.txtDegree.Size = new System.Drawing.Size(180, 22);
            this.txtDegree.TabIndex = 20;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(478, 34);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(180, 22);
            this.txtId.TabIndex = 19;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(358, 123);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(81, 13);
            this.lblStatus.TabIndex = 18;
            this.lblStatus.Text = "Current Status";
            // 
            // lblDegree
            // 
            this.lblDegree.AutoSize = true;
            this.lblDegree.Location = new System.Drawing.Point(358, 82);
            this.lblDegree.Name = "lblDegree";
            this.lblDegree.Size = new System.Drawing.Size(68, 13);
            this.lblDegree.TabIndex = 17;
            this.lblDegree.Text = "Degree Title";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(358, 41);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(62, 13);
            this.lblId.TabIndex = 16;
            this.lblId.Text = "Student ID";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(120, 321);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(180, 22);
            this.txtEmail.TabIndex = 15;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(120, 280);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(180, 22);
            this.txtPhone.TabIndex = 14;
            // 
            // txtPPS
            // 
            this.txtPPS.Location = new System.Drawing.Point(120, 239);
            this.txtPPS.Name = "txtPPS";
            this.txtPPS.Size = new System.Drawing.Size(180, 22);
            this.txtPPS.TabIndex = 13;
            // 
            // txtCountry
            // 
            this.txtCountry.Location = new System.Drawing.Point(120, 198);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(180, 22);
            this.txtCountry.TabIndex = 12;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(120, 157);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(180, 22);
            this.txtCity.TabIndex = 11;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(120, 116);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(180, 22);
            this.txtAddress.TabIndex = 10;
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(120, 75);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(180, 22);
            this.txtSurname.TabIndex = 9;
            // 
            // txtFirst
            // 
            this.txtFirst.Location = new System.Drawing.Point(120, 34);
            this.txtFirst.Name = "txtFirst";
            this.txtFirst.Size = new System.Drawing.Size(180, 22);
            this.txtFirst.TabIndex = 8;
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(16, 164);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(26, 13);
            this.lblCity.TabIndex = 7;
            this.lblCity.Text = "City";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(16, 328);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(39, 13);
            this.lblEmail.TabIndex = 6;
            this.lblEmail.Text = "E-Mail";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(16, 287);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(84, 13);
            this.lblPhone.TabIndex = 5;
            this.lblPhone.Text = "Phone Number";
            // 
            // lblPPS
            // 
            this.lblPPS.AutoSize = true;
            this.lblPPS.Location = new System.Drawing.Point(16, 246);
            this.lblPPS.Name = "lblPPS";
            this.lblPPS.Size = new System.Drawing.Size(69, 13);
            this.lblPPS.TabIndex = 4;
            this.lblPPS.Text = "PPS Number";
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Location = new System.Drawing.Point(16, 205);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(48, 13);
            this.lblCountry.TabIndex = 3;
            this.lblCountry.Text = "Country";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(16, 123);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(48, 13);
            this.lblAddress.TabIndex = 2;
            this.lblAddress.Text = "Address";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Location = new System.Drawing.Point(16, 82);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(52, 13);
            this.lblSurname.TabIndex = 1;
            this.lblSurname.Text = "Surname";
            // 
            // lblFirst
            // 
            this.lblFirst.AutoSize = true;
            this.lblFirst.Location = new System.Drawing.Point(16, 41);
            this.lblFirst.Name = "lblFirst";
            this.lblFirst.Size = new System.Drawing.Size(61, 13);
            this.lblFirst.TabIndex = 0;
            this.lblFirst.Text = "First Name";
            // 
            // AddStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 413);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddStudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Student";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblPPS;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label lblFirst;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtPPS;
        private System.Windows.Forms.TextBox txtCountry;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.TextBox txtFirst;
        private System.Windows.Forms.Button btnAddStud;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.TextBox txtDegree;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblDegree;
        private System.Windows.Forms.Label lblId;
    }
}