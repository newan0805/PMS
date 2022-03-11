namespace Product_Management_System.Admin_Forms
{
    partial class FormUserManagement
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
            this.cnbAdd = new System.Windows.Forms.CheckBox();
            this.cnbDelete = new System.Windows.Forms.CheckBox();
            this.cnbUpdate = new System.Windows.Forms.CheckBox();
            this.cnbSearch = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbUserType = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTelephone = new System.Windows.Forms.TextBox();
            this.txtRePassword = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.showPass = new System.Windows.Forms.CheckBox();
            this.Dob = new System.Windows.Forms.DateTimePicker();
            this.txtAddress = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cnbAdd
            // 
            this.cnbAdd.AutoSize = true;
            this.cnbAdd.Location = new System.Drawing.Point(331, 694);
            this.cnbAdd.Margin = new System.Windows.Forms.Padding(4);
            this.cnbAdd.Name = "cnbAdd";
            this.cnbAdd.Size = new System.Drawing.Size(15, 14);
            this.cnbAdd.TabIndex = 29;
            this.cnbAdd.UseVisualStyleBackColor = true;
            this.cnbAdd.CheckedChanged += new System.EventHandler(this.cnbAdd_CheckedChanged);
            // 
            // cnbDelete
            // 
            this.cnbDelete.AutoSize = true;
            this.cnbDelete.Location = new System.Drawing.Point(554, 694);
            this.cnbDelete.Margin = new System.Windows.Forms.Padding(4);
            this.cnbDelete.Name = "cnbDelete";
            this.cnbDelete.Size = new System.Drawing.Size(15, 14);
            this.cnbDelete.TabIndex = 30;
            this.cnbDelete.UseVisualStyleBackColor = true;
            this.cnbDelete.CheckedChanged += new System.EventHandler(this.cnbDelete_CheckedChanged);
            // 
            // cnbUpdate
            // 
            this.cnbUpdate.AutoSize = true;
            this.cnbUpdate.Location = new System.Drawing.Point(786, 694);
            this.cnbUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.cnbUpdate.Name = "cnbUpdate";
            this.cnbUpdate.Size = new System.Drawing.Size(15, 14);
            this.cnbUpdate.TabIndex = 31;
            this.cnbUpdate.UseVisualStyleBackColor = true;
            this.cnbUpdate.CheckedChanged += new System.EventHandler(this.cnbUpdate_CheckedChanged);
            // 
            // cnbSearch
            // 
            this.cnbSearch.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cnbSearch.FormattingEnabled = true;
            this.cnbSearch.Items.AddRange(new object[] {
            "ID",
            "Username"});
            this.cnbSearch.Location = new System.Drawing.Point(811, 86);
            this.cnbSearch.Margin = new System.Windows.Forms.Padding(4);
            this.cnbSearch.MaxDropDownItems = 3;
            this.cnbSearch.Name = "cnbSearch";
            this.cnbSearch.Size = new System.Drawing.Size(115, 25);
            this.cnbSearch.TabIndex = 23;
            this.cnbSearch.Text = "- Select -";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(368, 684);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(83, 34);
            this.btnAdd.TabIndex = 25;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(811, 684);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(83, 34);
            this.btnUpdate.TabIndex = 26;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(589, 686);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(83, 34);
            this.btnDelete.TabIndex = 27;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToOrderColumns = true;
            this.dataGridView2.AllowUserToResizeColumns = false;
            this.dataGridView2.AllowUserToResizeRows = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(806, 148);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(553, 484);
            this.dataGridView2.TabIndex = 22;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(948, 86);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(209, 23);
            this.txtSearch.TabIndex = 28;
            // 
            // btnClear
            // 
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnClear.Location = new System.Drawing.Point(150, 686);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(83, 34);
            this.btnClear.TabIndex = 36;
            this.btnClear.Text = "Clear All";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Image = global::Product_Management_System.Properties.Resources.refresh_24px;
            this.btnRefresh.Location = new System.Drawing.Point(1076, 683);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(4);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(98, 34);
            this.btnRefresh.TabIndex = 33;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // button1
            // 
            this.button1.Image = global::Product_Management_System.Properties.Resources.xamarin_48px;
            this.button1.Location = new System.Drawing.Point(1349, 14);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(37, 34);
            this.button1.TabIndex = 32;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Image = global::Product_Management_System.Properties.Resources.search_24px;
            this.btnSearch.Location = new System.Drawing.Point(1184, 83);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(36, 34);
            this.btnSearch.TabIndex = 24;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbUserType);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtTelephone);
            this.groupBox1.Controls.Add(this.txtRePassword);
            this.groupBox1.Controls.Add(this.txtPassword);
            this.groupBox1.Controls.Add(this.txtUsername);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.showPass);
            this.groupBox1.Controls.Add(this.Dob);
            this.groupBox1.Controls.Add(this.txtAddress);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(33, 23);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox1.Size = new System.Drawing.Size(740, 609);
            this.groupBox1.TabIndex = 37;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "UM Form";
            // 
            // cmbUserType
            // 
            this.cmbUserType.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.cmbUserType.FormattingEnabled = true;
            this.cmbUserType.Items.AddRange(new object[] {
            "Client",
            "Admin"});
            this.cmbUserType.Location = new System.Drawing.Point(527, 141);
            this.cmbUserType.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cmbUserType.Name = "cmbUserType";
            this.cmbUserType.Size = new System.Drawing.Size(163, 27);
            this.cmbUserType.TabIndex = 3;
            this.cmbUserType.Text = "- Select -";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.label8.Location = new System.Drawing.Point(524, 105);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 19);
            this.label8.TabIndex = 7;
            this.label8.Text = "User Type";
            // 
            // txtTelephone
            // 
            this.txtTelephone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTelephone.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelephone.Location = new System.Drawing.Point(247, 489);
            this.txtTelephone.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtTelephone.Name = "txtTelephone";
            this.txtTelephone.Size = new System.Drawing.Size(225, 24);
            this.txtTelephone.TabIndex = 6;
            // 
            // txtRePassword
            // 
            this.txtRePassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRePassword.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRePassword.Location = new System.Drawing.Point(247, 251);
            this.txtRePassword.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtRePassword.Name = "txtRePassword";
            this.txtRePassword.Size = new System.Drawing.Size(225, 24);
            this.txtRePassword.TabIndex = 6;
            this.txtRePassword.UseSystemPasswordChar = true;
            // 
            // txtPassword
            // 
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassword.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(247, 199);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(225, 24);
            this.txtPassword.TabIndex = 6;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // txtUsername
            // 
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsername.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(247, 141);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(225, 24);
            this.txtUsername.TabIndex = 6;
            // 
            // txtEmail
            // 
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(247, 91);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(225, 24);
            this.txtEmail.TabIndex = 6;
            // 
            // showPass
            // 
            this.showPass.AutoSize = true;
            this.showPass.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.showPass.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showPass.Location = new System.Drawing.Point(524, 251);
            this.showPass.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.showPass.Name = "showPass";
            this.showPass.Size = new System.Drawing.Size(132, 23);
            this.showPass.TabIndex = 5;
            this.showPass.Text = "Show Password";
            this.showPass.UseVisualStyleBackColor = true;
            this.showPass.CheckedChanged += new System.EventHandler(this.showPass_CheckedChanged);
            // 
            // Dob
            // 
            this.Dob.CustomFormat = "";
            this.Dob.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dob.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Dob.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Dob.Location = new System.Drawing.Point(247, 303);
            this.Dob.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Dob.Name = "Dob";
            this.Dob.Size = new System.Drawing.Size(226, 24);
            this.Dob.TabIndex = 4;
            // 
            // txtAddress
            // 
            this.txtAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAddress.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(247, 362);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(367, 97);
            this.txtAddress.TabIndex = 3;
            this.txtAddress.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(47, 91);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Email";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(47, 388);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 19);
            this.label6.TabIndex = 2;
            this.label6.Text = "Address";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(48, 308);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 19);
            this.label4.TabIndex = 2;
            this.label4.Text = "Date Of Birth";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(47, 489);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 19);
            this.label7.TabIndex = 2;
            this.label7.Text = "Telephone No.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(47, 141);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Username";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(47, 251);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 19);
            this.label5.TabIndex = 2;
            this.label5.Text = "Re-Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 199);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Password";
            // 
            // FormUserManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1400, 768);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cnbAdd);
            this.Controls.Add(this.cnbDelete);
            this.Controls.Add(this.cnbUpdate);
            this.Controls.Add(this.cnbSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.txtSearch);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormUserManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormUserManagement";
            this.Load += new System.EventHandler(this.FormUserManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox cnbAdd;
        private System.Windows.Forms.CheckBox cnbDelete;
        private System.Windows.Forms.CheckBox cnbUpdate;
        private System.Windows.Forms.ComboBox cnbSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbUserType;
        internal System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTelephone;
        private System.Windows.Forms.TextBox txtRePassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.CheckBox showPass;
        private System.Windows.Forms.DateTimePicker Dob;
        private System.Windows.Forms.RichTextBox txtAddress;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
    }
}