namespace Product_Management_System.Forms
{
    partial class FormLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.viewPass = new System.Windows.Forms.CheckBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.viewPass);
            this.GroupBox1.Controls.Add(this.btnLogin);
            this.GroupBox1.Controls.Add(this.txtPassword);
            this.GroupBox1.Controls.Add(this.txtUsername);
            this.GroupBox1.Controls.Add(this.label8);
            this.GroupBox1.Controls.Add(this.Label6);
            this.GroupBox1.Controls.Add(this.Label5);
            this.GroupBox1.Controls.Add(this.Label4);
            this.GroupBox1.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold);
            this.GroupBox1.Location = new System.Drawing.Point(634, 97);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(439, 537);
            this.GroupBox1.TabIndex = 10;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Login";
            // 
            // viewPass
            // 
            this.viewPass.AutoSize = true;
            this.viewPass.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Italic);
            this.viewPass.Location = new System.Drawing.Point(149, 305);
            this.viewPass.Name = "viewPass";
            this.viewPass.Size = new System.Drawing.Size(131, 21);
            this.viewPass.TabIndex = 4;
            this.viewPass.Text = "Show Password";
            this.viewPass.UseVisualStyleBackColor = true;
            this.viewPass.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // btnLogin
            // 
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Century Gothic", 7.8F);
            this.btnLogin.ForeColor = System.Drawing.Color.Black;
            this.btnLogin.Location = new System.Drawing.Point(158, 467);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(122, 33);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.Button1_Click);
            this.btnLogin.Enter += new System.EventHandler(this.Button1_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtPassword.Location = new System.Drawing.Point(29, 238);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(377, 27);
            this.txtPassword.TabIndex = 2;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtUsername.Location = new System.Drawing.Point(29, 150);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(377, 27);
            this.txtUsername.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Italic);
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(186, 387);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 17);
            this.label8.TabIndex = 4;
            this.label8.Text = "Signup";
            this.label8.Click += new System.EventHandler(this.Label6_Click);
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Italic);
            this.Label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Label6.Location = new System.Drawing.Point(156, 426);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(128, 17);
            this.Label6.TabIndex = 5;
            this.Label6.Text = "Forgot password?";
            this.Label6.Click += new System.EventHandler(this.Label6_Click);
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.Label5.Location = new System.Drawing.Point(29, 203);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(82, 21);
            this.Label5.TabIndex = 0;
            this.Label5.Text = "Password";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.Label4.Location = new System.Drawing.Point(29, 114);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(88, 21);
            this.Label4.TabIndex = 0;
            this.Label4.Text = "Username";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.Label3.Location = new System.Drawing.Point(24, 682);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(302, 17);
            this.Label3.TabIndex = 9;
            this.Label3.Text = "Copyrights © 2020. All Reserved By NSK Soulutions.";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Italic);
            this.Label2.ForeColor = System.Drawing.Color.Gray;
            this.Label2.Location = new System.Drawing.Point(220, 447);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(130, 18);
            this.Label2.TabIndex = 8;
            this.Label2.Text = "By NSK Solutions. ";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold);
            this.Label1.Location = new System.Drawing.Point(119, 396);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(335, 26);
            this.Label1.TabIndex = 7;
            this.Label1.Text = "Product Management System.";
            // 
            // PictureBox1
            // 
            this.PictureBox1.Image = global::Product_Management_System.Properties.Resources.truck_100px;
            this.PictureBox1.Location = new System.Drawing.Point(187, 208);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(218, 144);
            this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBox1.TabIndex = 6;
            this.PictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Image = global::Product_Management_System.Properties.Resources.xamarin_48px;
            this.button1.Location = new System.Drawing.Point(1146, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(30, 30);
            this.button1.TabIndex = 12;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1200, 720);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.PictureBox1);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormLogin";
            this.Load += new System.EventHandler(this.FormLogin_Load);
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.Button btnLogin;
        internal System.Windows.Forms.TextBox txtPassword;
        internal System.Windows.Forms.TextBox txtUsername;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.PictureBox PictureBox1;
        private System.Windows.Forms.CheckBox viewPass;
        private System.Windows.Forms.Button button1;
        internal System.Windows.Forms.Label label8;
    }
}