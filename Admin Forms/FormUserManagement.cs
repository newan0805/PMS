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
    public partial class FormUserManagement : Form
    {
        DbConnector db;
        public FormUserManagement()
        {
            InitializeComponent();
            db = new DbConnector();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            db.fillDataGridView("SELECT * FROM user_table", dataGridView2);
        }

        private void FormUserManagement_Load(object sender, EventArgs e)
        {
            db.fillDataGridView("SELECT * FROM user_table", dataGridView2);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormDashboard fd = new FormDashboard();
            this.Hide();
            fd.ShowDialog();
            this.Dispose(true);
            this.Close();
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void cnbUpdate_CheckedChanged(object sender, EventArgs e)
        {

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

                txtAddress.ReadOnly = false;
                txtEmail.ReadOnly = false;
                txtPassword.ReadOnly = false;
                txtRePassword.ReadOnly = false;
                txtTelephone.ReadOnly = false;
                txtUsername.ReadOnly = false;
            }
            else
            {
                cnbUpdate.Enabled = true;
                btnUpdate.Enabled = true;

                cnbAdd.Enabled = true;
                btnAdd.Enabled = true;

                txtAddress.ReadOnly = true;
                txtEmail.ReadOnly = true;
                txtPassword.ReadOnly = true;
                txtRePassword.ReadOnly = true;
                txtTelephone.ReadOnly = true;
                txtUsername.ReadOnly = true;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (isValid() == true)
            {
                if (userAdd() == true)
                {

                }
            }
        }

        private bool userAdd()
        {
            DateTime dob = Dob.Value;
            string userType = cmbUserType.Text.ToString();
            string Dataset = "INSERT INTO user_table (email,username,password,tel,address,userType,dob)" +
                             "VALUES ('" + txtEmail.Text.ToString() + "', '" + txtUsername.Text.ToString() + "', " +
                                     "'" + txtPassword.Text.ToString() + "', '" + txtTelephone.Text.ToString() + "'" +
                                     "'" + txtAddress.Text.ToString() + "', '" + userType + "', '" + dob.ToString("yyyy-MM-dd") + "') ";

            string Auth = db.performCRUD(Dataset);

            if (Auth == null)
            {
                MessageBox.Show("Username Or Password Is Incorrect !", "Incorrect Cridentials !"
                                , MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                MessageBox.Show("Successful", "User Added Successfully !"
                                , MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
        }

        private bool isValid()
        {
            if (txtPassword.Text != txtRePassword.Text)
            {
                MessageBox.Show("Passwords Does Not Match !", "Please Use An One Password !",
                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (Dob.Value >= DateTime.Today)
            {
                MessageBox.Show("Enter A Propper Date Of Birth !", "Date Of Birth Is Not Valid !",
                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (txtPassword.Text.ToString().Trim() == string.Empty || txtRePassword.Text.ToString().Trim() == string.Empty ||
               txtAddress.Text.ToString().Trim() == string.Empty || txtEmail.Text.ToString().Trim() == string.Empty ||
               txtTelephone.Text.ToString().Trim() == string.Empty ||
               txtUsername.Text.ToString().Trim() == string.Empty ||
               Dob.Value == DateTime.Today)
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
                txtAddress.ReadOnly = false;
                txtEmail.ReadOnly = false;
                txtPassword.ReadOnly = false;
                txtRePassword.ReadOnly = false;
                txtTelephone.ReadOnly = false;
                txtUsername.ReadOnly = false;
            }
            else
            {
                cnbDelete.Enabled = true;
                btnDelete.Enabled = true;

                cnbUpdate.Enabled = true;
                btnUpdate.Enabled = true;

                txtAddress.ReadOnly = true;
                txtEmail.ReadOnly = true;
                txtPassword.ReadOnly = true;
                txtRePassword.ReadOnly = true;
                txtTelephone.ReadOnly = true;
                txtUsername.ReadOnly = true;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtPassword.Text = string.Empty;
            txtRePassword.Text = string.Empty;
            txtAddress.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtTelephone.Text = string.Empty;
            txtUsername.Text = string.Empty;
            Dob.Value = DateTime.Today;
        }

        private void showPass_CheckedChanged(object sender, EventArgs e)
        {
            if (showPass.Checked == true)
            {
                txtPassword.UseSystemPasswordChar = false;
                txtRePassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
                txtRePassword.UseSystemPasswordChar = true;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string Qrydata = txtSearch.Text;
            string data = cnbSearch.Text;
            if (data == "ID")
            {
                string DataAuth = db.fillDataGridView("SELECT * FROM user_table WHERE id LIKE '" + Qrydata + "' ", dataGridView2);
                if (DataAuth == null)
                {
                    MessageBox.Show("Data Cannot Be Found !", " Or Check Cridentials !",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else if (data == "Username")
            {
                string DataAuth = db.fillDataGridView("SELECT * FROM user_table WHERE username LIKE '" + Qrydata + "' ", dataGridView2);
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
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView2.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dataGridView2.CurrentRow.Selected = true;
                txtEmail.Text = dataGridView2.Rows[e.RowIndex].Cells["email"].FormattedValue.ToString();
                txtUsername.Text = dataGridView2.Rows[e.RowIndex].Cells["email"].FormattedValue.ToString();
                txtPassword.Text = txtRePassword.Text = dataGridView2.Rows[e.RowIndex].Cells["password"].FormattedValue.ToString();
                txtTelephone.Text = dataGridView2.Rows[e.RowIndex].Cells["tel"].FormattedValue.ToString();
                txtAddress.Text = dataGridView2.Rows[e.RowIndex].Cells["address"].FormattedValue.ToString();
                Dob.Value = Convert.ToDateTime(dataGridView2.Rows[e.RowIndex].Cells["dob"].FormattedValue.ToString());
            }
        }
    }
}
