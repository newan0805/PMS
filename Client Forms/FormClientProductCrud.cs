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

namespace Product_Management_System.Client_Forms
{
    public partial class FormClientProductCrud : Form
    {
        DbConnector db;
        public FormClientProductCrud()
        {
            InitializeComponent();
            db = new DbConnector();
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView2.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dataGridView2.CurrentRow.Selected = true;
                txtPID.Text = dataGridView2.Rows[e.RowIndex].Cells["OrderId"].FormattedValue.ToString();
                txtPName.Text = dataGridView2.Rows[e.RowIndex].Cells["CustomerId"].FormattedValue.ToString();
                txtPPrice.Text = dataGridView2.Rows[e.RowIndex].Cells["ProductId"].FormattedValue.ToString();
                txtPqnt.Text = dataGridView2.Rows[e.RowIndex].Cells["pName"].FormattedValue.ToString();
                txtPCategory.Text = dataGridView2.Rows[e.RowIndex].Cells["pQnt"].FormattedValue.ToString();
                txtTotal.Text = dataGridView2.Rows[e.RowIndex].Cells["Bill"].FormattedValue.ToString();
            }
            else
            {
                MessageBox.Show("Empty !", "Try Again !"
                               , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormClientProductCrud_Load(object sender, EventArgs e)
        {
            int id = LoginInfo.UserID;
            db.fillDataGridView("SELECT * FROM product_table", dataGridView1);
            db.fillDataGridView("SELECT * FROM orders_table WHERE CustomerId = '" + id + "' ", dataGridView2);

            
                btnUpdate.Enabled = false;

                cnbDelete.Enabled = true;
                btnDelete.Enabled = false;

                cnbAdd.Enabled = true;
                btnAdd.Enabled = false;

                txtPPrice.ReadOnly = true;
                txtPqnt.ReadOnly = true;
                txtPCategory.ReadOnly = true;
            
                cnbDelete.Enabled = true;
                btnDelete.Enabled = false;

                cnbAdd.Enabled = true;
                btnAdd.Enabled = false;

                txtPPrice.ReadOnly = true;
                txtPqnt.ReadOnly = true;
                txtPCategory.ReadOnly = true;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dataGridView1.CurrentRow.Selected = true;
                txtPID.Text = dataGridView1.Rows[e.RowIndex].Cells["id"].FormattedValue.ToString();
                txtPName.Text = dataGridView1.Rows[e.RowIndex].Cells["pName"].FormattedValue.ToString();
                txtPPrice.Text = dataGridView1.Rows[e.RowIndex].Cells["pPrice"].FormattedValue.ToString();
                txtPqnt.Text = dataGridView1.Rows[e.RowIndex].Cells["pQnt"].FormattedValue.ToString();
                txtPCategory.Text = dataGridView1.Rows[e.RowIndex].Cells["pType"].FormattedValue.ToString();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            int id = LoginInfo.UserID;
            db.fillDataGridView("SELECT * FROM product_table", dataGridView1);
            db.fillDataGridView("SELECT * FROM orders_table WHERE CustomerId = '" + id + "' ", dataGridView2);
            txtPID.Text = null;
            txtPName.Text = null;
            txtPPrice = null;
            txtPqnt = null;
            txtSearch = null;
            txtTotal = null;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(isValid() == true)
            {
                if(isDone() == true)
                {

                }
            }
        }

        private bool isDone()
        {   
            int userid = LoginInfo.UserID;
            double price = Convert.ToDouble(txtPPrice.Text);
            int qnt = Convert.ToInt32(txtPqnt.Text);
            double total = price * qnt;
            txtTotal.Text = total.ToString();

            string count = db.getSingleValue("SELECT MAX(OrderId) FROM orders_table", out count, 0);
            int OrderId = (Convert.ToInt32(count)) + 1;

            string Dataset = " INSERT INTO orders_table (OrderId,CustomerId,ProductId,pName,pQnt,pCategory,Bill)" +
                             " VALUES ( '" + OrderId + "', '" + userid + "', '" + txtPID.Text + "', '" + txtPName.Text+ "', '"+ txtPqnt.Text + "', " +
                             "'" + txtPCategory.Text + "', '" + total + "') ";
            MessageBox.Show(Dataset,"Dataset");
            string Auth = db.performCRUD(Dataset);

            if (Auth == null)
            {
                MessageBox.Show("Could Not Add !", "Try Again !"
                                , MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                MessageBox.Show("Product Added !", "Sucessfully !"
                               , MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
        }

        private bool isValid()
        {
           if(txtPID.ToString().Trim() == String.Empty || txtPName.ToString().Trim() == String.Empty || txtPPrice.ToString().Trim() == String.Empty ||
                txtPqnt.ToString().Trim() == String.Empty || txtPCategory.ToString().Trim() == String.Empty || txtTotal.ToString().Trim() == String.Empty)
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

        private void button1_Click(object sender, EventArgs e)
        {
            FormClientDashboard fd = new FormClientDashboard();
            this.Hide();
            fd.ShowDialog();
            this.Close();
            this.Dispose(true);
        }

        private void label7_Click(object sender, EventArgs e)
        {
            double price = Convert.ToDouble(txtPPrice.Text);
            int qnt = Convert.ToInt32(txtPqnt.Text);
            double total = price * qnt;
            txtTotal.Text = total.ToString();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        private void cnbAdd_CheckedChanged(object sender, EventArgs e)
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

        private void cnbDelete_CheckedChanged(object sender, EventArgs e)
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
