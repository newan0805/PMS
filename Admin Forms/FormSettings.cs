using Product_Management_System.Admin_Forms;
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

namespace Product_Management_System.Forms
{
    public partial class FormSettings : Form
    {
        DbConnector db;
        int userId = LoginInfo.UserID;
        public FormSettings()
        {
            InitializeComponent();
            db = new DbConnector();
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

        private void btnSignup_Click(object sender, EventArgs e)
        {
            if (isValid() == true)
            {
                if (isUpdate() == true)
                {

                }
            }
        }

        private bool isUpdate()
        {
            DateTime dob = Dob.Value;
            int userId = LoginInfo.UserID;

            string Dataset = " UPDATE user_table SET email = '" + txtEmail.Text + "'" +
                             " ,username = '" + txtUsername.Text + "', password = '" + txtPassword.Text + "' " +
                             " ,tel = '" + txtTelephone.Text + "', address = '" + txtAddress.Text + "' " +
                             " ,UserType = Admin, dob = '" + dob.ToString("yyyy-MM-dd") + "' " +
                             " WHERE id = '" + userId + "' ";
            /*MessageBox.Show("'"+Dataset+"'","Dataset");*/
           string Auth = db.performCRUD(Dataset);
            if (Auth == null)
            {
                MessageBox.Show("Data Updated Successful !", "User Updated !",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else
            {
                MessageBox.Show("Data Update Unsuccessful !", "User Didn't Updated !",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void FormSettings_Load(object sender, EventArgs e)
        {
            string[] Data = db.getArray("SELECT * FROM user_table WHERE id = '" + userId + "' ", 8);
            
            if (Data.Length > 0)
            {
                txtEmail.Text = Data[1];
                txtUsername.Text = Data[2];
                txtPassword.Text = txtRePassword.Text = Data[3];
                txtTelephone.Text = Data[4];
                txtAddress.Text = Data[5];
                Dob.Text = Convert.ToDateTime(Data[7]).ToString("yyyy-MM-dd");
                /*int id = Convert.ToInt32(Data[1]);
                string uname = Data[2];
                string pass = Data[3];
                int tel = Convert.ToInt32(Data[4]);
                string addr = Data[5];
                string DoB = Convert.ToDateTime(Data[7]).ToString("yyyy-MM-dd");*/

                /*MessageBox.Show(" '"+id+ "', '"+uname+"','"+pass+"','"+tel+"','"+addr+"','"+DoB+"' ", "Data From Users");*/
                /*MessageBox.Show(" '" + uname + "'", "Data From Users");*/
            }
            else
            {
                MessageBox.Show("No Data Fountded !", "Data Could'nt Be Fetched !",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormDashboard fl = new FormDashboard();
            this.Hide();
            fl.ShowDialog();
            this.Dispose(true);
            this.Close();
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
