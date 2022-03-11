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

namespace Product_Management_System.Client_Forms
{
    public partial class FormClientProducts : Form
    {
        DbConnector db;
        public FormClientProducts()
        {
            InitializeComponent();
            db = new DbConnector();
        }

        private void FormClientProducts_Load(object sender, EventArgs e)
        {
            int id = LoginInfo.UserID;
            db.fillDataGridView("SELECT * FROM product_table WHERE id = '"+id+"'", dataGridView1);
            lblUsername.Text = LoginInfo.UserName;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            db.fillDataGridView("SELECT * FROM product_table", dataGridView1);
            lblUsername.Text = LoginInfo.UserName;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            db.fillDataGridView("SELECT * FROM product_table", dataGridView1);
        }

        private void btnAboutUs_Click(object sender, EventArgs e)
        {

        }

        private void btnSettings_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormLogin lf = new FormLogin();
            this.Hide(); 
            lf.ShowDialog();
            this.Dispose(true);
            this.Close();
            
        }

        private void btnAboutUs_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            FormAboutClient fa = new FormAboutClient();
            fa.ShowDialog();
            this.Close();
            this.Dispose(true);
        }

        private void btnSettings_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            FormSettings sf = new FormSettings();
            sf.ShowDialog();
            this.Close();
            this.Dispose(true);
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormClientProductCrud sf = new FormClientProductCrud();
            sf.ShowDialog();
            this.Close();
            this.Dispose(true);
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {

        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            FormDashboard crud = new FormDashboard();
            this.Hide();
            crud.ShowDialog();
            this.Dispose(true);
            this.Close();
        }
    }
}
