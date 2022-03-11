using Product_Management_System.Client_Forms;
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
    public partial class FormSignup : Form
    {
        DbConnector db;
        public FormSignup()
        {
            InitializeComponent();
            db = new DbConnector();
        }

        private void FormSignup_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

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

        private void button2_Click(object sender, EventArgs e)
        {
            FormLogin fl = new FormLogin();
            fl.ShowDialog();
            this.Dispose(true);
            this.Close();
            this.Hide();
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            if (isFormValid())
            {
                if (checkInsert())
                {
                    using (FormLogin fl = new FormLogin())
                    {
                        this.Hide();
                        fl.ShowDialog();
                        this.Dispose(true);
                        this.Close();
                    }
                }
            }
        }

        private bool checkInsert()
        {
            DateTime dob = Dob.Value;
            string Max = db.getSingleValue("SELECT MAX(id) FROM user_table", out Max ,0);
            int ID = Convert.ToInt32(Max) + 1;
            string Dataset = "INSERT INTO user_table ( email, username, password, tel, address, userType, dob)" +
                             " VALUES ('" + txtEmail.Text.ToString() + "', '" + txtUsername.Text.ToString() + "', " +
                                     "'" + txtPassword.Text.ToString() + "', '" + txtTelephone.Text.ToString() + "'," +
                                     "'" + txtAddress.Text.ToString() + "', 'Client', '" + dob.ToString("yyyy-MM-dd") + "') ";

            /*MessageBox.Show(Dataset);*/

           string Auth = db.performCRUD(Dataset);

           /* MessageBox.Show(Auth);*/

            if (Auth == null)
            {
                MessageBox.Show("Username Or Password Is Incorrect !", "Incorrect Cridentials !"
                                , MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                MessageBox.Show("User Added Successfully !" ,"Please Login Now !"
                               , MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
        } 

        private bool isFormValid()
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
               Dob.Value == DateTime.Today )
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

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void txtTelephone_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtRePassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void Dob_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
