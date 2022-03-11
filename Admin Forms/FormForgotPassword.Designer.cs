namespace Product_Management_System.Forms
{
    partial class FormForgotPassword
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.viewPass = new System.Windows.Forms.CheckBox();
            this.btnCheck = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtUserID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ViewPass2 = new System.Windows.Forms.CheckBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtFRePassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.viewPass);
            this.groupBox1.Controls.Add(this.btnCheck);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtUserID);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(76, 102);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(384, 386);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Forgot Password";
            // 
            // viewPass
            // 
            this.viewPass.AutoSize = true;
            this.viewPass.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.viewPass.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.viewPass.Location = new System.Drawing.Point(140, 257);
            this.viewPass.Margin = new System.Windows.Forms.Padding(2);
            this.viewPass.Name = "viewPass";
            this.viewPass.Size = new System.Drawing.Size(108, 22);
            this.viewPass.TabIndex = 4;
            this.viewPass.Text = "Show Email";
            this.viewPass.UseVisualStyleBackColor = true;
            this.viewPass.CheckedChanged += new System.EventHandler(this.viewPass_CheckedChanged);
            // 
            // btnCheck
            // 
            this.btnCheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheck.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnCheck.Location = new System.Drawing.Point(140, 316);
            this.btnCheck.Margin = new System.Windows.Forms.Padding(2);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(107, 30);
            this.btnCheck.TabIndex = 2;
            this.btnCheck.Text = "Check";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtEmail.Location = new System.Drawing.Point(27, 191);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(330, 27);
            this.txtEmail.TabIndex = 1;
            this.txtEmail.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label5.Location = new System.Drawing.Point(27, 153);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 21);
            this.label5.TabIndex = 0;
            this.label5.Text = "Email";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtUserID
            // 
            this.txtUserID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUserID.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtUserID.Location = new System.Drawing.Point(27, 99);
            this.txtUserID.Margin = new System.Windows.Forms.Padding(2);
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.Size = new System.Drawing.Size(330, 27);
            this.txtUserID.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label4.Location = new System.Drawing.Point(27, 60);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 21);
            this.label4.TabIndex = 0;
            this.label4.Text = "User ID";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ViewPass2);
            this.groupBox2.Controls.Add(this.btnSave);
            this.groupBox2.Controls.Add(this.txtFRePassword);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtFPassword);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold);
            this.groupBox2.Location = new System.Drawing.Point(608, 102);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(384, 386);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Forgot Password";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // ViewPass2
            // 
            this.ViewPass2.AutoSize = true;
            this.ViewPass2.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ViewPass2.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.ViewPass2.Location = new System.Drawing.Point(141, 257);
            this.ViewPass2.Margin = new System.Windows.Forms.Padding(2);
            this.ViewPass2.Name = "ViewPass2";
            this.ViewPass2.Size = new System.Drawing.Size(136, 22);
            this.ViewPass2.TabIndex = 4;
            this.ViewPass2.Text = "Show Password";
            this.ViewPass2.UseVisualStyleBackColor = true;
            this.ViewPass2.Visible = false;
            this.ViewPass2.CheckedChanged += new System.EventHandler(this.ViewPass2_CheckedChanged);
            // 
            // btnSave
            // 
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnSave.Location = new System.Drawing.Point(141, 316);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(107, 30);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Visible = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtFRePassword
            // 
            this.txtFRePassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFRePassword.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtFRePassword.Location = new System.Drawing.Point(27, 191);
            this.txtFRePassword.Margin = new System.Windows.Forms.Padding(2);
            this.txtFRePassword.Name = "txtFRePassword";
            this.txtFRePassword.ReadOnly = true;
            this.txtFRePassword.Size = new System.Drawing.Size(330, 27);
            this.txtFRePassword.TabIndex = 1;
            this.txtFRePassword.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label2.Location = new System.Drawing.Point(27, 153);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Re - Password";
            // 
            // txtFPassword
            // 
            this.txtFPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFPassword.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtFPassword.Location = new System.Drawing.Point(27, 99);
            this.txtFPassword.Margin = new System.Windows.Forms.Padding(2);
            this.txtFPassword.Name = "txtFPassword";
            this.txtFPassword.ReadOnly = true;
            this.txtFPassword.Size = new System.Drawing.Size(330, 27);
            this.txtFPassword.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label3.Location = new System.Drawing.Point(27, 60);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 21);
            this.label3.TabIndex = 0;
            this.label3.Text = "Password";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Image = global::Product_Management_System.Properties.Resources.xamarin_48px;
            this.button2.Location = new System.Drawing.Point(1028, 10);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(28, 28);
            this.button2.TabIndex = 7;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FormForgotPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1066, 614);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FormForgotPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormForgotPassword_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox viewPass;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtUserID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox ViewPass2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtFRePassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
    }
}