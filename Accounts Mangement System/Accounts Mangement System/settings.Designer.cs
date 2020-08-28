namespace Accounts_Mangement_System
{
    partial class settings
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
            this.saveBtn = new System.Windows.Forms.Button();
            this.isCB = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.password_db_text = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.user_id_text = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.database_text = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.server_text = new System.Windows.Forms.TextBox();
            this.leftPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // leftPanel
            // 
            this.leftPanel.Controls.Add(this.saveBtn);
            this.leftPanel.Controls.Add(this.isCB);
            this.leftPanel.Controls.Add(this.label6);
            this.leftPanel.Controls.Add(this.password_db_text);
            this.leftPanel.Controls.Add(this.label5);
            this.leftPanel.Controls.Add(this.user_id_text);
            this.leftPanel.Controls.Add(this.label4);
            this.leftPanel.Controls.Add(this.database_text);
            this.leftPanel.Controls.Add(this.label3);
            this.leftPanel.Controls.Add(this.server_text);
            this.leftPanel.Size = new System.Drawing.Size(200, 508);
            this.leftPanel.Controls.SetChildIndex(this.panel3, 0);
            this.leftPanel.Controls.SetChildIndex(this.server_text, 0);
            this.leftPanel.Controls.SetChildIndex(this.label3, 0);
            this.leftPanel.Controls.SetChildIndex(this.database_text, 0);
            this.leftPanel.Controls.SetChildIndex(this.label4, 0);
            this.leftPanel.Controls.SetChildIndex(this.user_id_text, 0);
            this.leftPanel.Controls.SetChildIndex(this.label5, 0);
            this.leftPanel.Controls.SetChildIndex(this.password_db_text, 0);
            this.leftPanel.Controls.SetChildIndex(this.label6, 0);
            this.leftPanel.Controls.SetChildIndex(this.isCB, 0);
            this.leftPanel.Controls.SetChildIndex(this.saveBtn, 0);
            // 
            // rightPanel
            // 
            this.rightPanel.Size = new System.Drawing.Size(431, 508);
            // 
            // saveBtn
            // 
            this.saveBtn.FlatAppearance.BorderSize = 2;
            this.saveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveBtn.ForeColor = System.Drawing.Color.White;
            this.saveBtn.Location = new System.Drawing.Point(3, 356);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(194, 28);
            this.saveBtn.TabIndex = 20;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // isCB
            // 
            this.isCB.AutoSize = true;
            this.isCB.ForeColor = System.Drawing.Color.White;
            this.isCB.Location = new System.Drawing.Point(3, 331);
            this.isCB.Name = "isCB";
            this.isCB.Size = new System.Drawing.Size(125, 19);
            this.isCB.TabIndex = 19;
            this.isCB.Text = "Integrated Security";
            this.isCB.UseVisualStyleBackColor = true;
            this.isCB.CheckedChanged += new System.EventHandler(this.isCB_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(3, 283);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 15);
            this.label6.TabIndex = 18;
            this.label6.Text = "Password";
            // 
            // password_db_text
            // 
            this.password_db_text.Location = new System.Drawing.Point(3, 301);
            this.password_db_text.MaxLength = 50;
            this.password_db_text.Name = "password_db_text";
            this.password_db_text.Size = new System.Drawing.Size(194, 23);
            this.password_db_text.TabIndex = 17;
            this.password_db_text.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(3, 230);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 15);
            this.label5.TabIndex = 16;
            this.label5.Text = "User ID";
            // 
            // user_id_text
            // 
            this.user_id_text.Location = new System.Drawing.Point(3, 248);
            this.user_id_text.MaxLength = 50;
            this.user_id_text.Name = "user_id_text";
            this.user_id_text.Size = new System.Drawing.Size(194, 23);
            this.user_id_text.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(3, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 15);
            this.label4.TabIndex = 14;
            this.label4.Text = "Database";
            // 
            // database_text
            // 
            this.database_text.Location = new System.Drawing.Point(3, 195);
            this.database_text.MaxLength = 50;
            this.database_text.Name = "database_text";
            this.database_text.Size = new System.Drawing.Size(194, 23);
            this.database_text.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(3, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 15);
            this.label3.TabIndex = 12;
            this.label3.Text = "Server";
            // 
            // server_text
            // 
            this.server_text.Location = new System.Drawing.Point(3, 142);
            this.server_text.MaxLength = 50;
            this.server_text.Name = "server_text";
            this.server_text.Size = new System.Drawing.Size(194, 23);
            this.server_text.TabIndex = 11;
            // 
            // settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 508);
            this.Name = "settings";
            this.Text = "settings";
            this.leftPanel.ResumeLayout(false);
            this.leftPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.CheckBox isCB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox password_db_text;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox user_id_text;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox database_text;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox server_text;
    }
}