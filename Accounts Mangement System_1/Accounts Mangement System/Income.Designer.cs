namespace Accounts_Mangement_System
{
    partial class Income
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label2 = new System.Windows.Forms.Label();
            this.nameError = new System.Windows.Forms.Label();
            this.datepicker = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.descTxt = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.amountRecTxt = new System.Windows.Forms.TextBox();
            this.dateError = new System.Windows.Forms.Label();
            this.DescError = new System.Windows.Forms.Label();
            this.amountError = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.clientIDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.incomeIDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescriptionGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AmountGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientNameTxt = new System.Windows.Forms.TextBox();
            this.existingClientsDD = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.AddBtn = new System.Windows.Forms.Button();
            this.backBtn = new System.Windows.Forms.Button();
            this.leftPanel.SuspendLayout();
            this.rightPanel.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // leftPanel
            // 
            this.leftPanel.Controls.Add(this.AddBtn);
            this.leftPanel.Controls.Add(this.pictureBox1);
            this.leftPanel.Controls.Add(this.label6);
            this.leftPanel.Controls.Add(this.existingClientsDD);
            this.leftPanel.Controls.Add(this.clientNameTxt);
            this.leftPanel.Controls.Add(this.amountRecTxt);
            this.leftPanel.Controls.Add(this.label5);
            this.leftPanel.Controls.Add(this.descTxt);
            this.leftPanel.Controls.Add(this.label4);
            this.leftPanel.Controls.Add(this.label3);
            this.leftPanel.Controls.Add(this.datepicker);
            this.leftPanel.Controls.Add(this.label2);
            this.leftPanel.Controls.Add(this.nameError);
            this.leftPanel.Controls.Add(this.amountError);
            this.leftPanel.Controls.Add(this.dateError);
            this.leftPanel.Controls.Add(this.DescError);
            this.leftPanel.Size = new System.Drawing.Size(200, 679);
            this.leftPanel.Controls.SetChildIndex(this.DescError, 0);
            this.leftPanel.Controls.SetChildIndex(this.dateError, 0);
            this.leftPanel.Controls.SetChildIndex(this.amountError, 0);
            this.leftPanel.Controls.SetChildIndex(this.nameError, 0);
            this.leftPanel.Controls.SetChildIndex(this.panel3, 0);
            this.leftPanel.Controls.SetChildIndex(this.label2, 0);
            this.leftPanel.Controls.SetChildIndex(this.datepicker, 0);
            this.leftPanel.Controls.SetChildIndex(this.label3, 0);
            this.leftPanel.Controls.SetChildIndex(this.label4, 0);
            this.leftPanel.Controls.SetChildIndex(this.descTxt, 0);
            this.leftPanel.Controls.SetChildIndex(this.label5, 0);
            this.leftPanel.Controls.SetChildIndex(this.amountRecTxt, 0);
            this.leftPanel.Controls.SetChildIndex(this.clientNameTxt, 0);
            this.leftPanel.Controls.SetChildIndex(this.existingClientsDD, 0);
            this.leftPanel.Controls.SetChildIndex(this.label6, 0);
            this.leftPanel.Controls.SetChildIndex(this.pictureBox1, 0);
            this.leftPanel.Controls.SetChildIndex(this.AddBtn, 0);
            // 
            // rightPanel
            // 
            this.rightPanel.Controls.Add(this.panel5);
            this.rightPanel.Size = new System.Drawing.Size(690, 679);
            this.rightPanel.Controls.SetChildIndex(this.panel5, 0);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.backBtn);
            this.panel3.Controls.SetChildIndex(this.backBtn, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(3, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Client Name";
            // 
            // nameError
            // 
            this.nameError.AutoSize = true;
            this.nameError.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameError.ForeColor = System.Drawing.Color.Salmon;
            this.nameError.Location = new System.Drawing.Point(177, 168);
            this.nameError.Name = "nameError";
            this.nameError.Size = new System.Drawing.Size(17, 21);
            this.nameError.TabIndex = 49;
            this.nameError.Text = "*";
            this.nameError.Visible = false;
            // 
            // datepicker
            // 
            this.datepicker.CustomFormat = "dd-MMM-yyyy";
            this.datepicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datepicker.Location = new System.Drawing.Point(3, 387);
            this.datepicker.Name = "datepicker";
            this.datepicker.Size = new System.Drawing.Size(194, 23);
            this.datepicker.TabIndex = 67;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(3, 370);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 15);
            this.label3.TabIndex = 51;
            this.label3.Text = "Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(3, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 15);
            this.label4.TabIndex = 52;
            this.label4.Text = "Description";
            // 
            // descTxt
            // 
            this.descTxt.Location = new System.Drawing.Point(4, 233);
            this.descTxt.MaxLength = 500;
            this.descTxt.Name = "descTxt";
            this.descTxt.Size = new System.Drawing.Size(193, 86);
            this.descTxt.TabIndex = 65;
            this.descTxt.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(3, 325);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 15);
            this.label5.TabIndex = 54;
            this.label5.Text = "Amount";
            // 
            // amountRecTxt
            // 
            this.amountRecTxt.Location = new System.Drawing.Point(4, 343);
            this.amountRecTxt.MaxLength = 100;
            this.amountRecTxt.Name = "amountRecTxt";
            this.amountRecTxt.Size = new System.Drawing.Size(193, 23);
            this.amountRecTxt.TabIndex = 66;
            // 
            // dateError
            // 
            this.dateError.AutoSize = true;
            this.dateError.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateError.ForeColor = System.Drawing.Color.Salmon;
            this.dateError.Location = new System.Drawing.Point(177, 371);
            this.dateError.Name = "dateError";
            this.dateError.Size = new System.Drawing.Size(17, 21);
            this.dateError.TabIndex = 56;
            this.dateError.Text = "*";
            this.dateError.Visible = false;
            // 
            // DescError
            // 
            this.DescError.AutoSize = true;
            this.DescError.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescError.ForeColor = System.Drawing.Color.Salmon;
            this.DescError.Location = new System.Drawing.Point(177, 215);
            this.DescError.Name = "DescError";
            this.DescError.Size = new System.Drawing.Size(17, 21);
            this.DescError.TabIndex = 57;
            this.DescError.Text = "*";
            this.DescError.Visible = false;
            // 
            // amountError
            // 
            this.amountError.AutoSize = true;
            this.amountError.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amountError.ForeColor = System.Drawing.Color.Salmon;
            this.amountError.Location = new System.Drawing.Point(177, 326);
            this.amountError.Name = "amountError";
            this.amountError.Size = new System.Drawing.Size(17, 21);
            this.amountError.TabIndex = 58;
            this.amountError.Text = "*";
            this.amountError.Visible = false;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.dataGridView1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 40);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(690, 639);
            this.panel5.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clientIDGV,
            this.incomeIDGV,
            this.DateGV,
            this.DescriptionGV,
            this.AmountGV,
            this.nameGV});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(690, 639);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // clientIDGV
            // 
            this.clientIDGV.HeaderText = "clientID";
            this.clientIDGV.Name = "clientIDGV";
            this.clientIDGV.ReadOnly = true;
            this.clientIDGV.Visible = false;
            // 
            // incomeIDGV
            // 
            this.incomeIDGV.HeaderText = "incomeID";
            this.incomeIDGV.Name = "incomeIDGV";
            this.incomeIDGV.ReadOnly = true;
            this.incomeIDGV.Visible = false;
            // 
            // DateGV
            // 
            this.DateGV.HeaderText = "Date";
            this.DateGV.Name = "DateGV";
            this.DateGV.ReadOnly = true;
            // 
            // DescriptionGV
            // 
            this.DescriptionGV.HeaderText = "Description";
            this.DescriptionGV.Name = "DescriptionGV";
            this.DescriptionGV.ReadOnly = true;
            // 
            // AmountGV
            // 
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = null;
            this.AmountGV.DefaultCellStyle = dataGridViewCellStyle2;
            this.AmountGV.HeaderText = "Amount";
            this.AmountGV.Name = "AmountGV";
            this.AmountGV.ReadOnly = true;
            // 
            // nameGV
            // 
            this.nameGV.HeaderText = "Client Name";
            this.nameGV.Name = "nameGV";
            this.nameGV.ReadOnly = true;
            this.nameGV.Visible = false;
            // 
            // clientNameTxt
            // 
            this.clientNameTxt.Location = new System.Drawing.Point(4, 186);
            this.clientNameTxt.MaxLength = 50;
            this.clientNameTxt.Name = "clientNameTxt";
            this.clientNameTxt.Size = new System.Drawing.Size(193, 23);
            this.clientNameTxt.TabIndex = 64;
            // 
            // existingClientsDD
            // 
            this.existingClientsDD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.existingClientsDD.FormattingEnabled = true;
            this.existingClientsDD.Location = new System.Drawing.Point(3, 140);
            this.existingClientsDD.Name = "existingClientsDD";
            this.existingClientsDD.Size = new System.Drawing.Size(194, 23);
            this.existingClientsDD.TabIndex = 63;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(3, 122);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 15);
            this.label6.TabIndex = 64;
            this.label6.Text = "Exisiting Clients";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::Accounts_Mangement_System.Properties.Resources.Apps_File_Calc_icon__1_;
            this.pictureBox1.Location = new System.Drawing.Point(3, 82);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(33, 36);
            this.pictureBox1.TabIndex = 65;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // AddBtn
            // 
            this.AddBtn.BackColor = System.Drawing.Color.IndianRed;
            this.AddBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddBtn.FlatAppearance.BorderSize = 2;
            this.AddBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddBtn.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddBtn.ForeColor = System.Drawing.Color.White;
            this.AddBtn.Location = new System.Drawing.Point(3, 420);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(194, 50);
            this.AddBtn.TabIndex = 68;
            this.AddBtn.Text = "ADD";
            this.AddBtn.UseVisualStyleBackColor = false;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click_1);
            // 
            // backBtn
            // 
            this.backBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.backBtn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backBtn.Location = new System.Drawing.Point(0, 0);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(60, 40);
            this.backBtn.TabIndex = 2;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // Income
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 679);
            this.Name = "Income";
            this.Text = "Income";
            this.Load += new System.EventHandler(this.Income_Load);
            this.leftPanel.ResumeLayout(false);
            this.leftPanel.PerformLayout();
            this.rightPanel.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label nameError;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker datepicker;
        private System.Windows.Forms.TextBox amountRecTxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox descTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label amountError;
        private System.Windows.Forms.Label DescError;
        private System.Windows.Forms.Label dateError;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox clientNameTxt;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientIDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn incomeIDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescriptionGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn AmountGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameGV;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox existingClientsDD;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Button backBtn;
    }
}