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
    public partial class FormForgotPassword : Form
    {
        DbConnector db;

        public FormForgotPassword()
        {
            InitializeComponent();
            db = new DbConnector(); 
        }

        private void viewPass_CheckedChanged(object sender, EventArgs e)
        {
            if (viewPass.Checked == true)
            {
                txtEmail.UseSystemPasswordChar = false;
            }
            else
            {
                txtEmail.UseSystemPasswordChar = true;
            }
        }

        private void ViewPass2_CheckedChanged(object sender, EventArgs e)
        {
            if (ViewPass2.Checked == true)
            {
                txtFPassword.UseSystemPasswordChar = false;
                txtFRePassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtFPassword.UseSystemPasswordChar = true;
                txtFRePassword.UseSystemPasswordChar = true;
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (checkPassValid())
            {
                if (updateFields())
                {

                }
            }
        }

        private bool checkPassValid()
        {
            if (!(txtFPassword.Text == txtFRePassword.Text))
            {
                MessageBox.Show("Passwords Doesn't Match !", "And Try Again !",
                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (txtFPassword.Text.ToString().Trim() == string.Empty ||
                txtFRePassword.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Fill All Necessary Fields !", "And Try Again !",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                return true;
            }
        }

        private bool updateFields()
        {
            int id = 0;
            id = Convert.ToInt32(txtUserID.Text);
            string update = "UPDATE user_table SET password = '" +txtFPassword.Text+ "' WHERE id = '" + id + "' ";
            string auth = db.performCRUD(update);

            if(auth != null)
            {
                MessageBox.Show("Password Has Been Updated !", "Your Password Updated Successfully !",
                               MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (auth != null)
                {
                    txtUserID.Text = null;
                    txtEmail.Text = null;
                    txtFPassword.Text = null;
                    txtFRePassword.Text = null;

                    FormLogin fl = new FormLogin();
                    this.Hide();
                    fl.ShowDialog();
                    this.Dispose(true);
                    this.Close();
                }
                return true;
            }
            else
            {
                MessageBox.Show("Password Has'nt Updated !", "And Try Again !",
                              MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {
            /*this.Hide();*/
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            if(isValid())
            {
                if(checkData())
                {
                    txtFPassword.ReadOnly = false;
                    txtFRePassword.ReadOnly = false;
                    viewPass.Hide();

                    btnSave.Show();

                    txtUserID.ReadOnly = true;
                    txtEmail.ReadOnly = true;
                    ViewPass2.Visible = true;
                }
            }
        }

        private bool checkData()
        {
            int pass = 0;
             pass = Convert.ToInt32(txtUserID.Text);
            string DataAuth = db.getSingleValue("SELECT * FROM user_table " +
                                                "WHERE id = '" + pass + "' " +
                                                " AND  email = '" + txtEmail.Text + "' "
                                                , out DataAuth, 0);

            if (DataAuth == null)
            {
                MessageBox.Show("User ID Or Email Is Incorrect !", "Incorrect Cridentials !"
                                , MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                return true;
            }
        }

        private bool isValid()
        {
            if(txtUserID.Text.ToString() == string.Empty || txtEmail.Text.ToString().Trim() == string.Empty)
            {
                MessageBox.Show("Fill All Fields !", "And Try Again !",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (!txtUserID.Text.All(c => Char.IsNumber(c)))
            {
                MessageBox.Show("Only Numarical Value Could Be Applied !", "",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                return true;
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

        private void FormForgotPassword_Load(object sender, EventArgs e)
        {

        }
    }
}
