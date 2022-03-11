using Product_Management_System.Forms;
using System;
using SLRDbConnector;
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
    public partial class FormProducts : Form
    {
        int PanelWidth;
        bool isCollapsed;
        DbConnector db;

        public FormProducts()
        {
            InitializeComponent();
            db = new DbConnector();
            timeTimer.Start();
            PanelWidth = panelLeft.Width;
            isCollapsed = false;
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            FormDashboard fd = new FormDashboard();
            this.Hide();
            fd.Show();
            this.Dispose(true);
            this.Close();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormUsers fu = new FormUsers();
            this.Hide();
            fu.Show();
            this.Dispose(true);
            this.Close();
            
        }

        private void btnAboutUs_Click(object sender, EventArgs e)
        {
            FormAboutClient fa = new FormAboutClient();
            fa.Show();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            FormSettings fs = new FormSettings();
            this.Hide();
            fs.Show();
            this.Dispose(true);
            this.Close();
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormProductCrud cr = new FormProductCrud();
            this.Hide();
            cr.ShowDialog();
            this.Dispose(true);
            this.Close();
            
        }

        private void FormProducts_Load(object sender, EventArgs e)
        {
            db.fillDataGridView("SELECT * FROM product_table", dataGridView1);
            lblUsername.Text = LoginInfo.UserName;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            db.fillDataGridView("SELECT * FROM product_table", dataGridView1);
        }

        private void timeTimer_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            labelTime.Text = dt.ToString("HH:MM:ss");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isCollapsed)
            {
                panelLeft.Width = panelLeft.Width + 10;
                if (panelLeft.Width >= PanelWidth)
                {
                    timer1.Stop();
                    isCollapsed = false;
                    this.Refresh();
                }
            }
            else
            {
                panelLeft.Width = panelLeft.Width - 10;
                if (panelLeft.Width <= 68)
                {
                    timer1.Stop();
                    isCollapsed = true;
                    this.Refresh();
                }
            }
        }

        private void lblUsername_Click(object sender, EventArgs e)
        {
            lblUsername.Text = LoginInfo.UserName;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            lblUsername.Text = LoginInfo.UserName;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
           
            
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void btnDashboard_Click_1(object sender, EventArgs e)
        {
            FormDashboard fd = new FormDashboard();
            this.Hide();
            fd.ShowDialog();
            this.Dispose(true);
            this.Close();
        }

        private void btnUsers_Click_1(object sender, EventArgs e)
        {
            FormUserManagement fum = new FormUserManagement();
            this.Hide();
            fum.ShowDialog();
            this.Dispose(true);
            this.Close();
        }

        private void btnSettings_Click_1(object sender, EventArgs e)
        {
            FormSettings fums = new FormSettings();
            this.Hide();
            fums.ShowDialog();
            this.Dispose(true);
            this.Close();
        }

        private void btnAboutUs_Click_1(object sender, EventArgs e)
        {
            FormAboutClient fumsa = new FormAboutClient();
            this.Hide();
            fumsa.ShowDialog();
            this.Dispose(true);
            this.Close();
        }
    }
}
