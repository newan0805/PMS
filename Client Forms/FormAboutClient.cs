using Product_Management_System.Client_Forms;
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
    public partial class FormAboutClient : Form
    {
        public FormAboutClient()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (LoginInfo.userType == "Admin")
            {
                FormDashboard fd = new FormDashboard();
                this.Hide();
                fd.ShowDialog();
                this.Dispose(true);
                this.Close();
            }
            else if (LoginInfo.userType == "Client")
            {
                FormClientDashboard fcd = new FormClientDashboard();
                this.Hide();
                fcd.ShowDialog();
                this.Dispose(true);
                this.Close();
            }
            else
            {
                FormLogin fl = new FormLogin();
                this.Hide();
                fl.ShowDialog();
                this.Dispose(true);
                this.Close();
            }
           
        }

        private void FormAboutClient_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }
    }
}
