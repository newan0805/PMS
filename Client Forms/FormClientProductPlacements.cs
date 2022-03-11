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
    public partial class FormClientProductPlacements : Form
    {
        DbConnector db;
        public FormClientProductPlacements()
        {
            InitializeComponent();
            db = new DbConnector();
        }

        private void FormClientProductPlacements_Load(object sender, EventArgs e)
        {
            int loginId = LoginInfo.UserID;
            db.fillDataGridView("SELECT * FROM orders_table WHERE CustomerId = '" +loginId+ "' ", dataGridView1);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            int loginId = LoginInfo.UserID;
            db.fillDataGridView("SELECT * FROM orders_table WHERE CustomerId = '" + loginId + "' ", dataGridView1);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void timeTimer_Tick(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void labelTime_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void btnSettings_Click(object sender, EventArgs e)
        {

        }

        private void panelSide_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnProduct_Click(object sender, EventArgs e)
        {

        }

        private void panelLeft_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void lblUsername_Click(object sender, EventArgs e)
        {

        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {

        }

        private void btnAboutUs_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnEditPlacements_Click(object sender, EventArgs e)
        {
            FormClientProductCrud crud = new FormClientProductCrud();
            this.Hide();
            crud.ShowDialog();
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

        private void btnProduct_Click_1(object sender, EventArgs e)
        {
            FormClientProductCrud crud = new FormClientProductCrud();
            this.Hide();
            crud.ShowDialog();
            this.Dispose(true);
            this.Close();
        }
    }
}
