using Product_Management_System.Admin_Forms;
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
    public partial class FormDashboard : Form
    {
        DbConnector db;
        int PanelWidth;
        bool isCollapsed;

        public FormDashboard()
        {
            db = new DbConnector();
            InitializeComponent();
            timeTimer.Start();
            PanelWidth = panelLeft.Width;
            isCollapsed = false;
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblRole_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {

        }

        private void timeTimer_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            labelTime.Text = dt.ToString("HH:MM:ss");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            db.fillDataGridView("SELECT * FROM product_table", dataGridView1);
            lblUsername.Text = LoginInfo.UserName;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormLogin fl = new FormLogin();
            this.Hide();
            fl.ShowDialog();
            this.Dispose(true);
            this.Close();
            
        }

        private void timer1_Tick_2(object sender, EventArgs e)
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

        private void labelTime_Click(object sender, EventArgs e)
        {

        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            FormSettings fs = new FormSettings();
            this.Hide();
            fs.ShowDialog();
            this.Dispose(true);
            this.Close();
            
        }

        private void btnAboutUs_Click(object sender, EventArgs e)
        {
            FormAboutClient fa = new FormAboutClient();
            this.Hide();
            fa.ShowDialog();
            this.Dispose(true);
            this.Close();
            
        }

        private void btnJobs_Click(object sender, EventArgs e)
        {
            FormProducts fp = new FormProducts();
            this.Hide();
            fp.ShowDialog();
            this.Dispose(true);
            this.Close();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormUserManagement fum = new FormUserManagement();
            this.Hide();
            fum.ShowDialog();
            this.Dispose(true);
            this.Close();
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            db.fillDataGridView("SELECT * FROM product_table", dataGridView1);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            db.fillDataGridView("SELECT * FROM product_table", dataGridView1);
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {

        }

        private void lblUsername_Click(object sender, EventArgs e)
        {
            lblUsername.Text = LoginInfo.UserName;
        }
    }
}
