using Product_Management_System.Forms;
using SLRDbConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Product_Management_System.Admin_Forms
{
    public partial class FormProductCrud : Form
    {
        DbConnector db;

        public FormProductCrud()
        {
            InitializeComponent();
            db = new DbConnector();
        }

        private void button4_Click(object sender, EventArgs e)
        {
           /* string QrydataIndex = cnbSearch.SelectedIndex.ToString;*/
            string Qrydata = txtSearch.Text;
            string data = cnbSearch.Text;
            if (data == "ID")
            {
                string QrydataIndex = "id";
                string DataAuth = db.fillDataGridView("SELECT * FROM product_table WHERE id = '" + Qrydata + "' ", dataGridView2);
                if (DataAuth == null)
                {
                    MessageBox.Show("Data Cannot Be Found !", " Or Check Cridentials !",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else if (data == "Name")
            {
                string QrydataIndex = "pName";
                string DataAuth = db.fillDataGridView("SELECT * FROM product_table WHERE pName = '" + Qrydata + "' ", dataGridView2);
                if (DataAuth == null)
                {
                    MessageBox.Show("Data Cannot Be Found !", " Or Check Cridentials !",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Silected Index Couldn Not Be Initialized !", " Index Did Not Initialized !",
                                  MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            /*bool textNoT;
            try
            {
                int.Parse(txtSearch.Text);
                textNoT = true;
            }
            catch
            {
                textNoT = false;
            }
            string dd =
            if (textNoT == true)
            {
                string DataAuth = db.fillDataGridView("SELECT * FROM product_table WHERE '" + QrydataIndex + "' = '" + Qrydata + "' ", dataGridView2);
            }
            else if (textNoT == false)
            {
                string DataAuth = db.fillDataGridView("SELECT * FROM product_table WHERE '" + QrydataIndex + "' = '" + Qrydata + "' ", dataGridView2);
            }*/

            /*string hidenData = txtSearch.Text.Trim();

            double Num;

            bool isNum = double.TryParse(hidenData, out Num);

            if (isNum)
            {
                string DataAuth = db.fillDataGridView("SELECT * FROM product_table WHERE '" + QrydataIndex + "' = '" + Convert.ToInt32(Qrydata) + "' ", dataGridView2);
                if (DataAuth == null)
                {
                    MessageBox.Show("Data Cannot Be Found !", " Or Check Cridentials !",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                string DataAuth = db.fillDataGridView("SELECT * FROM product_table WHERE '" + QrydataIndex + "' = '" + Convert.ToString(Qrydata) + "' ", dataGridView2);
                if (DataAuth == null)
                {
                MessageBox.Show("Data Cannot Be Found !", " Or Check Cridentials !",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }*/

            /*string DataAuth = db.fillDataGridView("SELECT * FROM product_table WHERE '" + QrydataIndex + "' = '" + Qrydata + "' ", dataGridView2);*/

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you Want To Delete Product ?!", "Sucessfully !"
                              , MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                if (isValidDel() == true)
                {
                    if (ExecDel())
                    {
                        txtPID.Text = null;
                        txtPName.Text = null;
                        txtPPrice.Text = null;
                        txtPqnt.Text = null;
                        txtPCategory.Text = null;
                        txtSearch.Text = null;
                    }
                }
            }
        }

        private bool ExecDel()
        {
            int id = Convert.ToInt32(txtPID.Text);
            string dataSet = " DELETE FROM product_table WHERE id = '" +id+ "' "; 
            string Auth = db.performCRUD(dataSet);

            if(Auth != null)
            {
                MessageBox.Show("Data Has Been Deleted !", "",
                                   MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool isValidDel()
        {
            if(txtPID.Text.ToString().Trim() == String.Empty || txtPName.Text.ToString().Trim() == String.Empty)
            {

                MessageBox.Show("Required Fields Are Empty !", "Please Fill All Required Fields !",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                return true;
            }
        }

        private void cnbUpdate_CheckedChanged(object sender, EventArgs e)
        {
            if (cnbUpdate.Checked)
            {
                btnUpdate.Enabled = true;

                cnbDelete.Enabled = false;
                btnDelete.Enabled = false;

                cnbAdd.Enabled = false;
                btnAdd.Enabled = false;

                txtPPrice.ReadOnly = false;
                txtPqnt.ReadOnly = false;
                txtPCategory.ReadOnly = false;
            }
            else
            {
                cnbDelete.Enabled = true;
                btnDelete.Enabled = true;

                cnbAdd.Enabled = true;
                btnAdd.Enabled = true;

                txtPPrice.ReadOnly = true;
                txtPqnt.ReadOnly = true;
                txtPCategory.ReadOnly = true;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (cnbAdd.Checked)
            {
                btnAdd.Enabled = true;

                cnbDelete.Enabled = false;
                btnDelete.Enabled = false;
                
                cnbUpdate.Enabled = false;
                btnUpdate.Enabled = false;

               /* txtPID.ReadOnly = true;*/
                txtPPrice.ReadOnly = false;
                txtPqnt.ReadOnly = false;
                txtPCategory.ReadOnly = false;
            }
            else
            {
                cnbDelete.Enabled = true;
                btnDelete.Enabled = true;

                cnbUpdate.Enabled = true;
                btnUpdate.Enabled = true;

                txtPPrice.ReadOnly = true;
                txtPqnt.ReadOnly = true;
                txtPCategory.ReadOnly = true;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (cnbDelete.Checked)
            {
                btnDelete.Enabled = true;

                cnbUpdate.Enabled = false;
                btnUpdate.Enabled = false;

                cnbAdd.Enabled = false;
                btnAdd.Enabled = false;

                txtPPrice.ReadOnly = true;
                txtPqnt.ReadOnly = true;
                txtPCategory.ReadOnly = true;
            }
            else
            {
                cnbUpdate.Enabled = true;
                btnUpdate.Enabled = true;

                cnbAdd.Enabled = true;
                btnAdd.Enabled = true;

                txtPPrice.ReadOnly = false;
                txtPqnt.ReadOnly = false;
                txtPCategory.ReadOnly = false;
            }
        }

        private void FormProductCrud_Load(object sender, EventArgs e)
        {
            db.fillDataGridView("SELECT * FROM product_table", dataGridView2);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormDashboard fd = new FormDashboard();
            this.Hide();
            fd.ShowDialog();
            this.Dispose(true);
            this.Close();
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(isValid() == true)
            {
                if (addExecute() == true)
                {
                    txtPID.Text = null;
                    txtPName.Text = null;
                    txtPPrice.Text = null;
                    txtPqnt.Text = null;
                    txtPCategory.Text = null;
                    txtSearch.Text = null;
                }
            }
        }

        private bool addExecute()
        {
            int ID = Convert.ToInt32(txtPID.Text);
            double Price = Convert.ToDouble(txtPPrice.Text);
            int Qnt = Convert.ToInt32(txtPqnt.Text);

            string[] count = db.getArray("SELECT MAX(OrderId) FROM orders_table",1);
            string data = count[0];
            /*int ordersCount = Convert.ToInt32(data);
            int proID = ordersCount + 1;*/ /*MessageBox.Show(data, "Dataset");*/

            string DataSet = "INSERT INTO product_table (id, pName, pPrice, pQnt, pType)" +
                              "VALUES ('" + txtPID.Text + "','" + txtPName.Text + "', '" + Price + "'" +
                                      ",'" + Qnt + "', '" + txtPCategory.Text + "') ";

           /* MessageBox.Show(DataSet,"Dataset");*/

            string Auth = db.performCRUD(DataSet);

            if (Auth == null)
            {
                MessageBox.Show("Could Not Add !", "Incorrect Cridentials !"
                                , MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                MessageBox.Show("Product Inserted !", "Sucessfully !"
                               , MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
        }

        private bool isValid()
        {
            if( txtPID.Text.ToString().Trim() == String.Empty || txtPName.Text.ToString().Trim() == String.Empty ||
                txtPPrice.Text.ToString().Trim() == String.Empty || txtPqnt.Text.ToString().Trim() == String.Empty ||
                txtPCategory.Text.ToString().Trim() == String.Empty)
            {

                MessageBox.Show("Required Fields Are Empty !", "Please Fill All Required Fields !",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                return true;
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            db.fillDataGridView("SELECT * FROM product_table", dataGridView2);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtPID_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPqnt_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPCategory_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cnbSearch_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            if (isValid() == true)
            {
                if (updateData() == true)
                {
                    MessageBox.Show("Product Updated !", "Sucessfully !"
                               , MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private bool updateData()
        {
            int ID = Convert.ToInt32(txtPID.Text);
            decimal Price = Convert.ToInt32(txtPPrice.Text);
            int Qnt = Convert.ToInt32(txtPqnt.Text);

            string DataSet = "UPDATE product_table SET pName = '" + txtPName.Text + "', pPrice = '" + Price + "', pQnt = '" + Qnt + "', pType = '" + txtPCategory.Text + "' WHERE id = '" + ID + "' "; 
  
            string Auth = db.performCRUD(DataSet);

            if (Auth == null)
            {
                MessageBox.Show("Fill necessary fields !", "Incorrect Cridentials !"
                                , MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                return true;
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView2.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dataGridView2.CurrentRow.Selected = true;
                txtPID.Text = dataGridView2.Rows[e.RowIndex].Cells["id"].FormattedValue.ToString();
                txtPName.Text = dataGridView2.Rows[e.RowIndex].Cells["pName"].FormattedValue.ToString();
                txtPPrice.Text = dataGridView2.Rows[e.RowIndex].Cells["pPrice"].FormattedValue.ToString();
                txtPqnt.Text = dataGridView2.Rows[e.RowIndex].Cells["pQnt"].FormattedValue.ToString();
                txtPCategory.Text = dataGridView2.Rows[e.RowIndex].Cells["pType"].FormattedValue.ToString();
            }
        }
    }
}
