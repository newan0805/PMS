using SLRDbConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Product_Management_System.Test
{
    public partial class TestInsert : Form
    {
       /* DateTime dob = Dob.Value;
        string Dataset = "INSERT INTO user_table (email,username,password,tel,address,userType,dob)" +
                                          "VALUES('" + txtEmail + "', '" + txtUsername + "', " +
                                                  "'" + txtPassword + "', '" + txtTelephone + "')" +
                                                  "'" + txtAddress + "', Client, '" + dob + "' ";*/
        DbConnector db;
        public TestInsert()
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
            if (isFormValid())
            {
                if (checkInsert())
                {
                    
                }
            }
        }

        public string Dataset()
        {
            DateTimeFormatInfo format = new DateTimeFormatInfo();
            format.ShortDatePattern = "yyyy-MM-dd";
            format.DateSeparator = "-";
            DateTime date = Dob.Value;
            DateTime shortDate = Convert.ToDateTime(date, format);

            DateTime dob = shortDate;
            string Dataset = "INSERT INTO user_table (email,username,password,tel,address,userType,dob)" +
                                              "VALUES('" + txtEmail.Text.ToString() + "', '" + txtUsername.Text.ToString() + "', " +
                                                      "'" + txtPassword.Text.ToString() + "', '" + txtTelephone.Text.ToString() + "')" +
                                                      "'" + txtAddress.Text.ToString() + "', Client, '" + date.ToString("yyyy-MM-dd") + "' ";
            
            return Dataset;
        }

        private bool checkInsert()
        {
            /*DateTime dob = Dob.Value;
            string Dataset = "INSERT INTO user_table (email,username,password,tel,address,userType,dob)" +
                                              "VALUES('" + txtEmail + "', '" + txtUsername + "', " +
                                                      "'" + txtPassword + "', '" + txtTelephone + "')" +
                                                      "'" + txtAddress + "', Client, '" + dob + "' ";*/


            string Auth = db.performCRUD(Dataset());

            if (Auth == null)
            {
                MessageBox.Show("Username Or Password Is Incorrect !", "Incorrect Cridentials !"
                                , MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                MessageBox.Show("User Added Successfully !");
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

        private void TestInsert_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*DateTimeFormatInfo format = new DateTimeFormatInfo();
            format.ShortDatePattern = "yyyy-MM-dd";
            format.DateSeparator = "-";
            DateTime date = Dob.Value;
            DateTime shortDate = Convert.ToDateTime(date, format);
            MessageBox.Show(date.ToString("yyyy-MM-dd"), "Date");*/
            MessageBox.Show(Dataset(), "Dataset");
            /*MessageBox.Show(txtEmail.Text.ToString(), "Dataset");*/
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            /* string[] count = db.getArray("SELECT MAX(OrderId) FROM orders_table",1);
             string data = count[0];
             *//*int ordersCount = Convert.ToInt32(data);
             int proID = ordersCount + 1;*//*
             MessageBox.Show(data, "Dataset");*/

            string count = db.getSingleValue("SELECT MAX(OrderId) FROM orders_table",out count, 0);
            string data = count;
            /*int ordersCount = Convert.ToInt32(data);
            int proID = ordersCount + 1;*/
            MessageBox.Show(data, "Dataset");
        }
    }
}
