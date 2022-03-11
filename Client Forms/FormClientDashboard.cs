using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Product_Management_System.Admin_Forms;
using Product_Management_System.Forms;

using SLRDbConnector;

namespace Product_Management_System.Client_Forms
{
    public partial class FormClientDashboard : Form
    {
        DbConnector db;
        int PanelWidth;
        bool isCollapsed;

        public FormClientDashboard()
        {
            db = new DbConnector();
            InitializeComponent();
            timeTimer.Start();
            PanelWidth = panelLeft.Width;
            isCollapsed = false;
            lblUsername.Text = LoginInfo.UserName;
        }

        private void FormClientDashboars_Load(object sender, EventArgs e)
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

        private void btnAboutUs_Click(object sender, EventArgs e)
        {
            FormAboutClient fa = new FormAboutClient();
            this.Hide();
            fa.ShowDialog();
            this.Dispose(true);
            this.Close();
            
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

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timeTimer_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            labelTime.Text = dt.ToString("HH:MM:ss");
        }

        private void lblUsername_Click(object sender, EventArgs e)
        {
            lblUsername.Text = LoginInfo.UserName;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            db.fillDataGridView("SELECT * FROM product_table", dataGridView1);
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            FormLogin fl = new FormLogin();
            fl.ShowDialog();
            this.Close();
            this.Dispose(true);
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormClientProductPlacements pcp = new FormClientProductPlacements();
            pcp.ShowDialog();
            this.Close();
            this.Dispose(true);
        }

        private void btnAboutUs_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            FormAboutClient fa = new FormAboutClient();
            fa.ShowDialog();
            this.Close();
            this.Dispose(true);
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormSettings sf = new FormSettings();
            sf.ShowDialog();
            this.Close();
            this.Dispose(true);
        }
    }
}
