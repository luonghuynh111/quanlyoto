namespace Project
{
    partial class lblEmployee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(lblEmployee));
            this.tabDepartment = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tblEmployee = new System.Windows.Forms.DataGridView();
            this.EmployeeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateOfBirth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DepartName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button33 = new System.Windows.Forms.Button();
            this.button29 = new System.Windows.Forms.Button();
            this.btnUpdate_em = new System.Windows.Forms.Button();
            this.btnDelete_em = new System.Windows.Forms.Button();
            this.button37 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.searchEmployee = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tab_department = new System.Windows.Forms.TabPage();
            this.dgvDepartment = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.searchDe = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.txtsearchDe = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabDepartment.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblEmployee)).BeginInit();
            this.tab_department.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepartment)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabDepartment
            // 
            this.tabDepartment.Controls.Add(this.tabPage1);
            this.tabDepartment.Controls.Add(this.tab_department);
            this.tabDepartment.Location = new System.Drawing.Point(7, 12);
            this.tabDepartment.Name = "tabDepartment";
            this.tabDepartment.SelectedIndex = 0;
            this.tabDepartment.Size = new System.Drawing.Size(722, 403);
            this.tabDepartment.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tblEmployee);
            this.tabPage1.Controls.Add(this.button33);
            this.tabPage1.Controls.Add(this.button29);
            this.tabPage1.Controls.Add(this.btnUpdate_em);
            this.tabPage1.Controls.Add(this.btnDelete_em);
            this.tabPage1.Controls.Add(this.button37);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.searchEmployee);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(714, 377);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Employee";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tblEmployee
            // 
            this.tblEmployee.AllowUserToAddRows = false;
            this.tblEmployee.AllowUserToDeleteRows = false;
            this.tblEmployee.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tblEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblEmployee.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EmployeeId,
            this.FirstName,
            this.LastName,
            this.Sex,
            this.DateOfBirth,
            this.Address,
            this.Phone,
            this.DepartName,
            this.UserName,
            this.Password});
            this.tblEmployee.Location = new System.Drawing.Point(9, 89);
            this.tblEmployee.MultiSelect = false;
            this.tblEmployee.Name = "tblEmployee";
            this.tblEmployee.ReadOnly = true;
            this.tblEmployee.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tblEmployee.Size = new System.Drawing.Size(688, 231);
            this.tblEmployee.TabIndex = 45;
            this.tblEmployee.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tblEmployee_CellContentClick);
            // 
            // EmployeeId
            // 
            this.EmployeeId.DataPropertyName = "EmployeeId";
            this.EmployeeId.HeaderText = "Mã nhân viên";
            this.EmployeeId.Name = "EmployeeId";
            this.EmployeeId.ReadOnly = true;
            // 
            // FirstName
            // 
            this.FirstName.DataPropertyName = "FirstName";
            this.FirstName.HeaderText = "Họ";
            this.FirstName.Name = "FirstName";
            this.FirstName.ReadOnly = true;
            // 
            // LastName
            // 
            this.LastName.DataPropertyName = "LastName";
            this.LastName.HeaderText = "Tên";
            this.LastName.Name = "LastName";
            this.LastName.ReadOnly = true;
            // 
            // Sex
            // 
            this.Sex.DataPropertyName = "Sex";
            this.Sex.HeaderText = "Giới tính";
            this.Sex.Name = "Sex";
            this.Sex.ReadOnly = true;
            // 
            // DateOfBirth
            // 
            this.DateOfBirth.DataPropertyName = "DateOfBirth";
            this.DateOfBirth.HeaderText = "Ngày sinh";
            this.DateOfBirth.Name = "DateOfBirth";
            this.DateOfBirth.ReadOnly = true;
            // 
            // Address
            // 
            this.Address.DataPropertyName = "Address";
            this.Address.HeaderText = "Địa chỉ";
            this.Address.Name = "Address";
            this.Address.ReadOnly = true;
            // 
            // Phone
            // 
            this.Phone.DataPropertyName = "Phone";
            this.Phone.HeaderText = "Số điện thoại";
            this.Phone.Name = "Phone";
            this.Phone.ReadOnly = true;
            // 
            // DepartName
            // 
            this.DepartName.DataPropertyName = "DepartmentName";
            this.DepartName.HeaderText = "Vị trí";
            this.DepartName.Name = "DepartName";
            this.DepartName.ReadOnly = true;
            // 
            // UserName
            // 
            this.UserName.DataPropertyName = "UserName";
            this.UserName.HeaderText = "Tài khoản";
            this.UserName.Name = "UserName";
            this.UserName.ReadOnly = true;
            // 
            // Password
            // 
            this.Password.DataPropertyName = "Password";
            this.Password.HeaderText = "Mật khẩu";
            this.Password.Name = "Password";
            this.Password.ReadOnly = true;
            // 
            // button33
            // 
            this.button33.Image = ((System.Drawing.Image)(resources.GetObject("button33.Image")));
            this.button33.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button33.Location = new System.Drawing.Point(9, 344);
            this.button33.Name = "button33";
            this.button33.Size = new System.Drawing.Size(76, 29);
            this.button33.TabIndex = 41;
            this.button33.Text = "Report";
            this.button33.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button33.UseVisualStyleBackColor = true;
            this.button33.Click += new System.EventHandler(this.button33_Click);
            // 
            // button29
            // 
            this.button29.Image = ((System.Drawing.Image)(resources.GetObject("button29.Image")));
            this.button29.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button29.Location = new System.Drawing.Point(627, 37);
            this.button29.Name = "button29";
            this.button29.Size = new System.Drawing.Size(70, 25);
            this.button29.TabIndex = 40;
            this.button29.Text = " Details";
            this.button29.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button29.UseVisualStyleBackColor = true;
            this.button29.Click += new System.EventHandler(this.button29_Click_2);
            // 
            // btnUpdate_em
            // 
            this.btnUpdate_em.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate_em.Image")));
            this.btnUpdate_em.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdate_em.Location = new System.Drawing.Point(440, 37);
            this.btnUpdate_em.Name = "btnUpdate_em";
            this.btnUpdate_em.Size = new System.Drawing.Size(70, 25);
            this.btnUpdate_em.TabIndex = 39;
            this.btnUpdate_em.Text = " Update";
            this.btnUpdate_em.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdate_em.UseVisualStyleBackColor = true;
            this.btnUpdate_em.Click += new System.EventHandler(this.btnUpdate_em_Click);
            // 
            // btnDelete_em
            // 
            this.btnDelete_em.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete_em.Image")));
            this.btnDelete_em.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete_em.Location = new System.Drawing.Point(536, 37);
            this.btnDelete_em.Name = "btnDelete_em";
            this.btnDelete_em.Size = new System.Drawing.Size(70, 25);
            this.btnDelete_em.TabIndex = 38;
            this.btnDelete_em.Text = " Delete";
            this.btnDelete_em.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelete_em.UseVisualStyleBackColor = true;
            this.btnDelete_em.Click += new System.EventHandler(this.btnDelete_em_Click);
            // 
            // button37
            // 
            this.button37.Image = ((System.Drawing.Image)(resources.GetObject("button37.Image")));
            this.button37.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button37.Location = new System.Drawing.Point(358, 37);
            this.button37.Name = "button37";
            this.button37.Size = new System.Drawing.Size(62, 26);
            this.button37.TabIndex = 37;
            this.button37.Text = " New";
            this.button37.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button37.UseVisualStyleBackColor = true;
            this.button37.Click += new System.EventHandler(this.button37_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(205, 35);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(67, 28);
            this.button1.TabIndex = 13;
            this.button1.Text = " Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // searchEmployee
            // 
            this.searchEmployee.Location = new System.Drawing.Point(9, 38);
            this.searchEmployee.Name = "searchEmployee";
            this.searchEmployee.Size = new System.Drawing.Size(182, 20);
            this.searchEmployee.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Search Employee Name";
            // 
            // tab_department
            // 
            this.tab_department.Controls.Add(this.dgvDepartment);
            this.tab_department.Controls.Add(this.groupBox1);
            this.tab_department.Location = new System.Drawing.Point(4, 22);
            this.tab_department.Name = "tab_department";
            this.tab_department.Padding = new System.Windows.Forms.Padding(3);
            this.tab_department.Size = new System.Drawing.Size(714, 377);
            this.tab_department.TabIndex = 1;
            this.tab_department.Text = "Department";
            this.tab_department.UseVisualStyleBackColor = true;
            // 
            // dgvDepartment
            // 
            this.dgvDepartment.AllowUserToAddRows = false;
            this.dgvDepartment.AllowUserToDeleteRows = false;
            this.dgvDepartment.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDepartment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDepartment.Location = new System.Drawing.Point(14, 108);
            this.dgvDepartment.Name = "dgvDepartment";
            this.dgvDepartment.ReadOnly = true;
            this.dgvDepartment.Size = new System.Drawing.Size(681, 226);
            this.dgvDepartment.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.searchDe);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.txtsearchDe);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(15, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(680, 96);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Department";
            // 
            // searchDe
            // 
            this.searchDe.Location = new System.Drawing.Point(278, 47);
            this.searchDe.Name = "searchDe";
            this.searchDe.Size = new System.Drawing.Size(65, 23);
            this.searchDe.TabIndex = 37;
            this.searchDe.Text = " Search";
            this.searchDe.UseVisualStyleBackColor = true;
            this.searchDe.Click += new System.EventHandler(this.button5_Click);
            // 
            // button2
            // 
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(517, 45);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(70, 25);
            this.button2.TabIndex = 36;
            this.button2.Text = " Delete";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(426, 44);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(62, 26);
            this.button3.TabIndex = 35;
            this.button3.Text = " New";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtsearchDe
            // 
            this.txtsearchDe.Location = new System.Drawing.Point(91, 47);
            this.txtsearchDe.Name = "txtsearchDe";
            this.txtsearchDe.Size = new System.Drawing.Size(172, 20);
            this.txtsearchDe.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = " Name";
            // 
            // lblEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 416);
            this.Controls.Add(this.tabDepartment);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "lblEmployee";
            this.Text = "lblEmployee";
            this.Load += new System.EventHandler(this.lblEmployee_Load_1);
            this.tabDepartment.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblEmployee)).EndInit();
            this.tab_department.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepartment)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabDepartment;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tab_department;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox searchEmployee;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvDepartment;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtsearchDe;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button29;
        private System.Windows.Forms.Button btnUpdate_em;
        private System.Windows.Forms.Button btnDelete_em;
        private System.Windows.Forms.Button button37;
        private System.Windows.Forms.Button button33;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView tblEmployee;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeId;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sex;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateOfBirth;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn DepartName;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Password;
        private System.Windows.Forms.Button searchDe;
    }
}