namespace Accounts_Mangement_System
{
    partial class login
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
            this.label2 = new System.Windows.Forms.Label();
            this.loginBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.password_text = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.username_text = new System.Windows.Forms.TextBox();
            this.usrNameError = new System.Windows.Forms.Label();
            this.pass_Error = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.leftPanel.SuspendLayout();
            this.rightPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // leftPanel
            // 
            this.leftPanel.Controls.Add(this.pictureBox1);
            this.leftPanel.Controls.Add(this.label2);
            this.leftPanel.Controls.Add(this.loginBtn);
            this.leftPanel.Controls.Add(this.label4);
            this.leftPanel.Controls.Add(this.password_text);
            this.leftPanel.Controls.Add(this.label3);
            this.leftPanel.Controls.Add(this.username_text);
            this.leftPanel.Controls.Add(this.usrNameError);
            this.leftPanel.Controls.Add(this.pass_Error);
            this.leftPanel.Size = new System.Drawing.Size(200, 645);
            this.leftPanel.Controls.SetChildIndex(this.panel3, 0);
            this.leftPanel.Controls.SetChildIndex(this.pass_Error, 0);
            this.leftPanel.Controls.SetChildIndex(this.usrNameError, 0);
            this.leftPanel.Controls.SetChildIndex(this.username_text, 0);
            this.leftPanel.Controls.SetChildIndex(this.label3, 0);
            this.leftPanel.Controls.SetChildIndex(this.password_text, 0);
            this.leftPanel.Controls.SetChildIndex(this.label4, 0);
            this.leftPanel.Controls.SetChildIndex(this.loginBtn, 0);
            this.leftPanel.Controls.SetChildIndex(this.label2, 0);
            this.leftPanel.Controls.SetChildIndex(this.pictureBox1, 0);
            // 
            // rightPanel
            // 
            this.rightPanel.Controls.Add(this.panel1);
            this.rightPanel.Size = new System.Drawing.Size(1038, 645);
            this.rightPanel.Controls.SetChildIndex(this.panel1, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(3, 323);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 15);
            this.label2.TabIndex = 24;
            this.label2.Text = "Forgot Password?";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // loginBtn
            // 
            this.loginBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginBtn.FlatAppearance.BorderSize = 2;
            this.loginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginBtn.ForeColor = System.Drawing.Color.White;
            this.loginBtn.Location = new System.Drawing.Point(3, 280);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(194, 30);
            this.loginBtn.TabIndex = 21;
            this.loginBtn.Text = "Login";
            this.loginBtn.UseVisualStyleBackColor = true;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(3, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 15);
            this.label4.TabIndex = 20;
            this.label4.Text = "Password";
            // 
            // password_text
            // 
            this.password_text.Location = new System.Drawing.Point(3, 242);
            this.password_text.MaxLength = 30;
            this.password_text.Name = "password_text";
            this.password_text.Size = new System.Drawing.Size(194, 23);
            this.password_text.TabIndex = 19;
            this.password_text.UseSystemPasswordChar = true;
            this.password_text.TextChanged += new System.EventHandler(this.password_text_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(3, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 15);
            this.label3.TabIndex = 18;
            this.label3.Text = "Username";
            // 
            // username_text
            // 
            this.username_text.Location = new System.Drawing.Point(3, 198);
            this.username_text.MaxLength = 30;
            this.username_text.Name = "username_text";
            this.username_text.Size = new System.Drawing.Size(194, 23);
            this.username_text.TabIndex = 17;
            this.username_text.TextChanged += new System.EventHandler(this.username_text_TextChanged);
            // 
            // usrNameError
            // 
            this.usrNameError.AutoSize = true;
            this.usrNameError.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usrNameError.ForeColor = System.Drawing.Color.Salmon;
            this.usrNameError.Location = new System.Drawing.Point(177, 179);
            this.usrNameError.Name = "usrNameError";
            this.usrNameError.Size = new System.Drawing.Size(17, 21);
            this.usrNameError.TabIndex = 22;
            this.usrNameError.Text = "*";
            this.usrNameError.Visible = false;
            // 
            // pass_Error
            // 
            this.pass_Error.AutoSize = true;
            this.pass_Error.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pass_Error.ForeColor = System.Drawing.Color.Salmon;
            this.pass_Error.Location = new System.Drawing.Point(177, 224);
            this.pass_Error.Name = "pass_Error";
            this.pass_Error.Size = new System.Drawing.Size(17, 21);
            this.pass_Error.TabIndex = 23;
            this.pass_Error.Text = "*";
            this.pass_Error.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1038, 605);
            this.panel1.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe Script", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(341, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(505, 96);
            this.label5.TabIndex = 0;
            this.label5.Text = "Welcome to\r\nAccounts Management System";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Accounts_Mangement_System.Properties.Resources.Login;
            this.pictureBox1.Location = new System.Drawing.Point(60, 98);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 66);
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1238, 645);
            this.Name = "login";
            this.Text = "login";
            this.leftPanel.ResumeLayout(false);
            this.leftPanel.PerformLayout();
            this.rightPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox password_text;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox username_text;
        private System.Windows.Forms.Label usrNameError;
        private System.Windows.Forms.Label pass_Error;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
    }
}