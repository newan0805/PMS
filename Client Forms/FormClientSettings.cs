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
    public partial class FormClientSettings : Form
    {
        DbConnector db;
        public FormClientSettings()
        {
            InitializeComponent();
            db = new DbConnector();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormClientDashboard fcd = new FormClientDashboard();
            this.Hide();
            fcd.ShowDialog();
            this.Close();
            this.Dispose(true);
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

        private void btnUpdateData_Click(object sender, EventArgs e)
        {
            if (isValid() == true)
            {
                if (updateData())
                {

                }
            }
        }

        private bool updateData()
        {
            string DataSet = "UPDATE user_table SET email = '" +txtEmail.Text+ "' ,username = '" +txtUsername.Text+ "' " +
                             ",password = '" +txtPassword.Text+ "' ,tel = '" +txtTelephone.Text+ "' ,address = '" +txtAddress.Text+ "' , dob = '" +Dob.Value+ "' "; 
            string Auth = db.performCRUD(DataSet);
            if(Auth == null)
            {

                return false;
            }
            else
            {
                return true;
            }
        }

        private bool isValid()
        {
            if( txtPassword.Text.ToString().Trim() == string.Empty || txtRePassword.Text.ToString().Trim() == string.Empty ||
               txtAddress.Text.ToString().Trim() == string.Empty || txtAddress.Text.ToString().Trim() == string.Empty || 
               txtEmail.Text.ToString().Trim() == string.Empty || txtTelephone.Text.ToString().Trim() == string.Empty ||
               txtUsername.Text.ToString().Trim() == string.Empty || Dob.Value == DateTime.Today)
            {
                return false;
            }
            else
            {
                return true;
            }
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

        private void FormClientSettings_Load(object sender, EventArgs e)
        {

        }
    }
}
