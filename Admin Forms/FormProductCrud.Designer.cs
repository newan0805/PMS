namespace Product_Management_System.Admin_Forms
{
    partial class FormProductCrud
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtPqnt = new System.Windows.Forms.NumericUpDown();
            this.txtPCategory = new System.Windows.Forms.TextBox();
            this.txtPPrice = new System.Windows.Forms.TextBox();
            this.txtPName = new System.Windows.Forms.TextBox();
            this.txtPID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.cnbSearch = new System.Windows.Forms.ComboBox();
            this.cnbUpdate = new System.Windows.Forms.CheckBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.cnbDelete = new System.Windows.Forms.CheckBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cnbAdd = new System.Windows.Forms.CheckBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPqnt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtPqnt);
            this.groupBox1.Controls.Add(this.txtPCategory);
            this.groupBox1.Controls.Add(this.txtPPrice);
            this.groupBox1.Controls.Add(this.txtPName);
            this.groupBox1.Controls.Add(this.txtPID);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(63, 57);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(499, 473);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Product CRUD";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtPqnt
            // 
            this.txtPqnt.Location = new System.Drawing.Point(214, 292);
            this.txtPqnt.Name = "txtPqnt";
            this.txtPqnt.ReadOnly = true;
            this.txtPqnt.Size = new System.Drawing.Size(223, 27);
            this.txtPqnt.TabIndex = 6;
            // 
            // txtPCategory
            // 
            this.txtPCategory.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPCategory.Location = new System.Drawing.Point(214, 350);
            this.txtPCategory.Name = "txtPCategory";
            this.txtPCategory.ReadOnly = true;
            this.txtPCategory.Size = new System.Drawing.Size(223, 23);
            this.txtPCategory.TabIndex = 5;
            // 
            // txtPPrice
            // 
            this.txtPPrice.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPPrice.Location = new System.Drawing.Point(214, 238);
            this.txtPPrice.Name = "txtPPrice";
            this.txtPPrice.ReadOnly = true;
            this.txtPPrice.Size = new System.Drawing.Size(223, 23);
            this.txtPPrice.TabIndex = 5;
            this.txtPPrice.TextChanged += new System.EventHandler(this.txtPPrice_TextChanged);
            // 
            // txtPName
            // 
            this.txtPName.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPName.Location = new System.Drawing.Point(214, 175);
            this.txtPName.Name = "txtPName";
            this.txtPName.Size = new System.Drawing.Size(223, 23);
            this.txtPName.TabIndex = 5;
            this.txtPName.TextChanged += new System.EventHandler(this.txtPName_TextChanged);
            // 
            // txtPID
            // 
            this.txtPID.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPID.Location = new System.Drawing.Point(214, 122);
            this.txtPID.Name = "txtPID";
            this.txtPID.Size = new System.Drawing.Size(223, 23);
            this.txtPID.TabIndex = 5;
            this.txtPID.TextChanged += new System.EventHandler(this.txtPID_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(32, 351);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Product Category :";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(74, 292);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Product Qnt :";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(63, 239);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Product Price :";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(59, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Product Name:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(87, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Product ID :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(438, 637);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(73, 24);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(737, 85);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(242, 23);
            this.txtSearch.TabIndex = 5;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
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
            this.dataGridView2.Location = new System.Drawing.Point(615, 135);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(520, 396);
            this.dataGridView2.TabIndex = 1;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick_1);
            // 
            // cnbSearch
            // 
            this.cnbSearch.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cnbSearch.FormattingEnabled = true;
            this.cnbSearch.Items.AddRange(new object[] {
            "ID",
            "Name"});
            this.cnbSearch.Location = new System.Drawing.Point(615, 84);
            this.cnbSearch.Name = "cnbSearch";
            this.cnbSearch.Size = new System.Drawing.Size(99, 25);
            this.cnbSearch.TabIndex = 2;
            this.cnbSearch.Text = "- Select -";
            this.cnbSearch.SelectedIndexChanged += new System.EventHandler(this.cnbSearch_SelectedIndexChanged);
            // 
            // cnbUpdate
            // 
            this.cnbUpdate.AutoSize = true;
            this.cnbUpdate.Location = new System.Drawing.Point(689, 644);
            this.cnbUpdate.Name = "cnbUpdate";
            this.cnbUpdate.Size = new System.Drawing.Size(15, 14);
            this.cnbUpdate.TabIndex = 6;
            this.cnbUpdate.UseVisualStyleBackColor = true;
            this.cnbUpdate.CheckedChanged += new System.EventHandler(this.cnbUpdate_CheckedChanged);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(721, 638);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(73, 24);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click_1);
            // 
            // cnbDelete
            // 
            this.cnbDelete.AutoSize = true;
            this.cnbDelete.Location = new System.Drawing.Point(408, 643);
            this.cnbDelete.Name = "cnbDelete";
            this.cnbDelete.Size = new System.Drawing.Size(15, 14);
            this.cnbDelete.TabIndex = 6;
            this.cnbDelete.UseVisualStyleBackColor = true;
            this.cnbDelete.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Century Gothic", 7.8F);
            this.btnAdd.Location = new System.Drawing.Point(160, 637);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(73, 24);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cnbAdd
            // 
            this.cnbAdd.AutoSize = true;
            this.cnbAdd.Location = new System.Drawing.Point(130, 644);
            this.cnbAdd.Name = "cnbAdd";
            this.cnbAdd.Size = new System.Drawing.Size(15, 14);
            this.cnbAdd.TabIndex = 6;
            this.cnbAdd.UseVisualStyleBackColor = true;
            this.cnbAdd.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Image = global::Product_Management_System.Properties.Resources.refresh_24px;
            this.btnRefresh.Location = new System.Drawing.Point(978, 634);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(95, 32);
            this.btnRefresh.TabIndex = 20;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // button1
            // 
            this.button1.Image = global::Product_Management_System.Properties.Resources.xamarin_48px;
            this.button1.Location = new System.Drawing.Point(1158, 11);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(30, 28);
            this.button1.TabIndex = 13;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Image = global::Product_Management_System.Properties.Resources.search_24px;
            this.btnSearch.Location = new System.Drawing.Point(1001, 80);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(37, 31);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.button4_Click);
            // 
            // FormProductCrud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1200, 720);
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
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormProductCrud";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormProductCrud";
            this.Load += new System.EventHandler(this.FormProductCrud_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPqnt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtPCategory;
        private System.Windows.Forms.TextBox txtPPrice;
        private System.Windows.Forms.TextBox txtPName;
        private System.Windows.Forms.TextBox txtPID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox cnbSearch;
        private System.Windows.Forms.CheckBox cnbUpdate;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.CheckBox cnbDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.CheckBox cnbAdd;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.NumericUpDown txtPqnt;
    }
}