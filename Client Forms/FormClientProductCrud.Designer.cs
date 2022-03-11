namespace Product_Management_System.Client_Forms
{
    partial class FormClientProductCrud
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
            this.btnRefresh = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.cnbAdd = new System.Windows.Forms.CheckBox();
            this.cnbDelete = new System.Windows.Forms.CheckBox();
            this.cnbUpdate = new System.Windows.Forms.CheckBox();
            this.cnbSearch = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.txtPqnt = new System.Windows.Forms.NumericUpDown();
            this.txtPCategory = new System.Windows.Forms.TextBox();
            this.txtPPrice = new System.Windows.Forms.TextBox();
            this.txtPName = new System.Windows.Forms.TextBox();
            this.txtPID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPqnt)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRefresh
            // 
            this.btnRefresh.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Image = global::Product_Management_System.Properties.Resources.refresh_24px;
            this.btnRefresh.Location = new System.Drawing.Point(58, 282);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(105, 34);
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
            this.button1.Location = new System.Drawing.Point(985, 13);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(37, 34);
            this.button1.TabIndex = 32;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cnbAdd
            // 
            this.cnbAdd.AutoSize = true;
            this.cnbAdd.Location = new System.Drawing.Point(248, 291);
            this.cnbAdd.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cnbAdd.Name = "cnbAdd";
            this.cnbAdd.Size = new System.Drawing.Size(15, 14);
            this.cnbAdd.TabIndex = 29;
            this.cnbAdd.UseVisualStyleBackColor = true;
            this.cnbAdd.CheckedChanged += new System.EventHandler(this.cnbAdd_CheckedChanged);
            // 
            // cnbDelete
            // 
            this.cnbDelete.AutoSize = true;
            this.cnbDelete.Location = new System.Drawing.Point(438, 291);
            this.cnbDelete.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cnbDelete.Name = "cnbDelete";
            this.cnbDelete.Size = new System.Drawing.Size(15, 14);
            this.cnbDelete.TabIndex = 30;
            this.cnbDelete.UseVisualStyleBackColor = true;
            this.cnbDelete.CheckedChanged += new System.EventHandler(this.cnbDelete_CheckedChanged);
            // 
            // cnbUpdate
            // 
            this.cnbUpdate.AutoSize = true;
            this.cnbUpdate.Location = new System.Drawing.Point(642, 292);
            this.cnbUpdate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
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
            "Name"});
            this.cnbSearch.Location = new System.Drawing.Point(49, 35);
            this.cnbSearch.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cnbSearch.Name = "cnbSearch";
            this.cnbSearch.Size = new System.Drawing.Size(106, 25);
            this.cnbSearch.TabIndex = 23;
            this.cnbSearch.Text = "- Select -";
            // 
            // btnSearch
            // 
            this.btnSearch.Image = global::Product_Management_System.Properties.Resources.search_24px;
            this.btnSearch.Location = new System.Drawing.Point(407, 31);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(31, 33);
            this.btnSearch.TabIndex = 24;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(275, 284);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(104, 31);
            this.btnAdd.TabIndex = 25;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(666, 284);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(102, 31);
            this.btnUpdate.TabIndex = 26;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(71, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Product ID :";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(462, 282);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(105, 31);
            this.btnDelete.TabIndex = 27;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(427, 42);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Product Price :";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToResizeColumns = false;
            this.dataGridView2.AllowUserToResizeRows = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(528, 85);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(455, 326);
            this.dataGridView2.TabIndex = 22;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(176, 36);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(212, 23);
            this.txtSearch.TabIndex = 28;
            // 
            // txtPqnt
            // 
            this.txtPqnt.Location = new System.Drawing.Point(559, 98);
            this.txtPqnt.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtPqnt.Name = "txtPqnt";
            this.txtPqnt.ReadOnly = true;
            this.txtPqnt.Size = new System.Drawing.Size(195, 27);
            this.txtPqnt.TabIndex = 6;
            // 
            // txtPCategory
            // 
            this.txtPCategory.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPCategory.Location = new System.Drawing.Point(182, 151);
            this.txtPCategory.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtPCategory.Name = "txtPCategory";
            this.txtPCategory.ReadOnly = true;
            this.txtPCategory.Size = new System.Drawing.Size(196, 23);
            this.txtPCategory.TabIndex = 5;
            // 
            // txtPPrice
            // 
            this.txtPPrice.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPPrice.Location = new System.Drawing.Point(559, 41);
            this.txtPPrice.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtPPrice.Name = "txtPPrice";
            this.txtPPrice.ReadOnly = true;
            this.txtPPrice.Size = new System.Drawing.Size(196, 23);
            this.txtPPrice.TabIndex = 5;
            // 
            // txtPName
            // 
            this.txtPName.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPName.Location = new System.Drawing.Point(182, 98);
            this.txtPName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtPName.Name = "txtPName";
            this.txtPName.ReadOnly = true;
            this.txtPName.Size = new System.Drawing.Size(196, 23);
            this.txtPName.TabIndex = 5;
            // 
            // txtPID
            // 
            this.txtPID.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPID.Location = new System.Drawing.Point(182, 42);
            this.txtPID.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtPID.Name = "txtPID";
            this.txtPID.ReadOnly = true;
            this.txtPID.Size = new System.Drawing.Size(196, 23);
            this.txtPID.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(23, 153);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Product Category :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(438, 98);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Product Qnt :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(46, 97);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Product Name:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.btnRefresh);
            this.groupBox1.Controls.Add(this.txtPqnt);
            this.groupBox1.Controls.Add(this.txtTotal);
            this.groupBox1.Controls.Add(this.cnbAdd);
            this.groupBox1.Controls.Add(this.cnbDelete);
            this.groupBox1.Controls.Add(this.txtPCategory);
            this.groupBox1.Controls.Add(this.cnbUpdate);
            this.groupBox1.Controls.Add(this.txtPPrice);
            this.groupBox1.Controls.Add(this.txtPName);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.txtPID);
            this.groupBox1.Controls.Add(this.btnUpdate);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(110, 432);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(819, 364);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Product CRUD";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(598, 226);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 18);
            this.label8.TabIndex = 35;
            this.label8.Text = "Get Sum ->";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Blue;
            this.label7.Location = new System.Drawing.Point(688, 226);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 18);
            this.label7.TabIndex = 34;
            this.label7.Text = ": SUM :";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // txtTotal
            // 
            this.txtTotal.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(559, 189);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(196, 23);
            this.txtTotal.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(484, 190);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 18);
            this.label6.TabIndex = 4;
            this.label6.Text = "Total :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(49, 85);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(455, 326);
            this.dataGridView1.TabIndex = 22;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // FormClientProductCrud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1036, 837);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cnbSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FormClientProductCrud";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormClientProductCrud";
            this.Load += new System.EventHandler(this.FormClientProductCrud_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPqnt)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.NumericUpDown txtPqnt;
        private System.Windows.Forms.TextBox txtPCategory;
        private System.Windows.Forms.TextBox txtPPrice;
        private System.Windows.Forms.TextBox txtPName;
        private System.Windows.Forms.TextBox txtPID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}