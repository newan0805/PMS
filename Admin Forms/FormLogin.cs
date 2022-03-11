using Product_Management_System.Admin_Forms;
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
    public partial class FormLogin : Form
    {
        DbConnector db;
        public FormLogin()
        {
            InitializeComponent();
            db = new DbConnector();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (isFormValid() == true)
            {
                if (checkLogin() == true)
                {
                    if (LoginInfo.userType == "Admin")
                    {
                        FormDashboard fd = new FormDashboard();
                        this.Hide();
                        fd.ShowDialog();
                        this.Dispose(true);
                        this.Close();
                    }
                    else if(LoginInfo.userType == "Client")
                    {
                        FormClientDashboard fcd = new FormClientDashboard();
                        this.Hide();
                        fcd.ShowDialog();
                        this.Dispose(true);
                        this.Close();
                        
                    }
                }
            }
        }

        private bool checkLogin()
        {

            string[] getUserData = db.getArray("SELECT id, username, userType FROM user_table " +
                                                 "WHERE username = '" + txtUsername.Text + "' " +
                                                 " AND  password = '" + txtPassword.Text + "' ", 3);
            int id = Convert.ToInt32(getUserData[0]);
            string username = getUserData[1];
            string userType = getUserData[2];

           // MessageBox.Show(id.ToString(), username);

            if (getUserData != null)
            {
                LoginInfo.UserID = id;
                LoginInfo.UserName = username;
                LoginInfo.userType = userType;
            }

            //MessageBox.Show(LoginInfo.UserID.ToString(), LoginInfo.UserName);

            /*string user = cnbUserType.Text.ToString();*/
            string Auth = db.getSingleValue("SELECT * FROM user_table " +
                                                 "WHERE username = '" + txtUsername.Text + "' " +
                                                 " AND  password = '" + txtPassword.Text + "' "
                                                 , out Auth, 0);

            if (Auth == null)
            {
                MessageBox.Show("Data Doesn't Match !", "Incorrect Cridentials !"
                                , MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                return true;
            }
        }

        private bool isFormValid()
        {
            if (txtPassword.Text.ToString().Trim() == string.Empty || txtUsername.Text.ToString().Trim() == string.Empty)
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

        private void Label6_Click(object sender, EventArgs e)
        {
            FormForgotPassword fs = new FormForgotPassword();
            this.Hide();
            fs.ShowDialog();
            this.Close();
            this.Dispose(true);
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (viewPass.Checked == true)
            {
                txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose(true);
            Application.Exit();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
