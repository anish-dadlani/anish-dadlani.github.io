namespace Accounts_Mangement_System
{
    partial class Sales
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.plotIDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CityGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sizeGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PlotNoGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noOfInstallmentsGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ppmGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalPrizeGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.plotTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.clientDD = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.nameTxt = new System.Windows.Forms.TextBox();
            this.addressTxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.phTxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.nameError = new System.Windows.Forms.Label();
            this.addressError = new System.Windows.Forms.Label();
            this.numError = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.amountPayTxt = new System.Windows.Forms.TextBox();
            this.paidTxt = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.paidError = new System.Windows.Forms.Label();
            this.payBtn = new System.Windows.Forms.Button();
            this.leftPanel.SuspendLayout();
            this.rightPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // leftPanel
            // 
            this.leftPanel.Controls.Add(this.payBtn);
            this.leftPanel.Controls.Add(this.paidTxt);
            this.leftPanel.Controls.Add(this.label10);
            this.leftPanel.Controls.Add(this.amountPayTxt);
            this.leftPanel.Controls.Add(this.label9);
            this.leftPanel.Controls.Add(this.phTxt);
            this.leftPanel.Controls.Add(this.label6);
            this.leftPanel.Controls.Add(this.addressTxt);
            this.leftPanel.Controls.Add(this.label5);
            this.leftPanel.Controls.Add(this.nameTxt);
            this.leftPanel.Controls.Add(this.label4);
            this.leftPanel.Controls.Add(this.clientDD);
            this.leftPanel.Controls.Add(this.label3);
            this.leftPanel.Controls.Add(this.plotTxt);
            this.leftPanel.Controls.Add(this.label2);
            this.leftPanel.Controls.Add(this.numError);
            this.leftPanel.Controls.Add(this.addressError);
            this.leftPanel.Controls.Add(this.nameError);
            this.leftPanel.Controls.Add(this.paidError);
            this.leftPanel.ForeColor = System.Drawing.Color.Black;
            this.leftPanel.Size = new System.Drawing.Size(200, 514);
            this.leftPanel.Controls.SetChildIndex(this.paidError, 0);
            this.leftPanel.Controls.SetChildIndex(this.nameError, 0);
            this.leftPanel.Controls.SetChildIndex(this.addressError, 0);
            this.leftPanel.Controls.SetChildIndex(this.numError, 0);
            this.leftPanel.Controls.SetChildIndex(this.label2, 0);
            this.leftPanel.Controls.SetChildIndex(this.panel3, 0);
            this.leftPanel.Controls.SetChildIndex(this.plotTxt, 0);
            this.leftPanel.Controls.SetChildIndex(this.label3, 0);
            this.leftPanel.Controls.SetChildIndex(this.clientDD, 0);
            this.leftPanel.Controls.SetChildIndex(this.label4, 0);
            this.leftPanel.Controls.SetChildIndex(this.nameTxt, 0);
            this.leftPanel.Controls.SetChildIndex(this.label5, 0);
            this.leftPanel.Controls.SetChildIndex(this.addressTxt, 0);
            this.leftPanel.Controls.SetChildIndex(this.label6, 0);
            this.leftPanel.Controls.SetChildIndex(this.phTxt, 0);
            this.leftPanel.Controls.SetChildIndex(this.label9, 0);
            this.leftPanel.Controls.SetChildIndex(this.amountPayTxt, 0);
            this.leftPanel.Controls.SetChildIndex(this.label10, 0);
            this.leftPanel.Controls.SetChildIndex(this.paidTxt, 0);
            this.leftPanel.Controls.SetChildIndex(this.payBtn, 0);
            // 
            // rightPanel
            // 
            this.rightPanel.Controls.Add(this.dataGridView1);
            this.rightPanel.Size = new System.Drawing.Size(606, 514);
            this.rightPanel.Controls.SetChildIndex(this.dataGridView1, 0);
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
            this.plotIDGV,
            this.NameGV,
            this.CityGV,
            this.sizeGV,
            this.PlotNoGV,
            this.noOfInstallmentsGV,
            this.ppmGV,
            this.TotalPrizeGV});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 85);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(606, 429);
            this.dataGridView1.TabIndex = 5;
            // 
            // plotIDGV
            // 
            this.plotIDGV.HeaderText = "plotID";
            this.plotIDGV.Name = "plotIDGV";
            this.plotIDGV.ReadOnly = true;
            this.plotIDGV.Visible = false;
            // 
            // NameGV
            // 
            this.NameGV.HeaderText = "Project Name";
            this.NameGV.Name = "NameGV";
            this.NameGV.ReadOnly = true;
            // 
            // CityGV
            // 
            this.CityGV.HeaderText = "City";
            this.CityGV.Name = "CityGV";
            this.CityGV.ReadOnly = true;
            // 
            // sizeGV
            // 
            this.sizeGV.HeaderText = "Size";
            this.sizeGV.Name = "sizeGV";
            this.sizeGV.ReadOnly = true;
            // 
            // PlotNoGV
            // 
            this.PlotNoGV.HeaderText = "Plot No.";
            this.PlotNoGV.Name = "PlotNoGV";
            this.PlotNoGV.ReadOnly = true;
            // 
            // noOfInstallmentsGV
            // 
            this.noOfInstallmentsGV.HeaderText = "No. of Installments";
            this.noOfInstallmentsGV.Name = "noOfInstallmentsGV";
            this.noOfInstallmentsGV.ReadOnly = true;
            // 
            // ppmGV
            // 
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = null;
            this.ppmGV.DefaultCellStyle = dataGridViewCellStyle2;
            this.ppmGV.HeaderText = "Per Marla Prize";
            this.ppmGV.Name = "ppmGV";
            this.ppmGV.ReadOnly = true;
            // 
            // TotalPrizeGV
            // 
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = null;
            this.TotalPrizeGV.DefaultCellStyle = dataGridViewCellStyle3;
            this.TotalPrizeGV.HeaderText = "Total Prize";
            this.TotalPrizeGV.Name = "TotalPrizeGV";
            this.TotalPrizeGV.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(4, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Enter Plot No";
            // 
            // plotTxt
            // 
            this.plotTxt.Location = new System.Drawing.Point(4, 105);
            this.plotTxt.Name = "plotTxt";
            this.plotTxt.Size = new System.Drawing.Size(193, 23);
            this.plotTxt.TabIndex = 1;
            this.plotTxt.Validating += new System.ComponentModel.CancelEventHandler(this.plotTxt_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(4, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Existing Clients";
            // 
            // clientDD
            // 
            this.clientDD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.clientDD.FormattingEnabled = true;
            this.clientDD.Location = new System.Drawing.Point(4, 157);
            this.clientDD.Name = "clientDD";
            this.clientDD.Size = new System.Drawing.Size(193, 23);
            this.clientDD.TabIndex = 3;
            this.clientDD.SelectedIndexChanged += new System.EventHandler(this.clientDD_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(4, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "New Client";
            // 
            // nameTxt
            // 
            this.nameTxt.Location = new System.Drawing.Point(4, 208);
            this.nameTxt.MaxLength = 50;
            this.nameTxt.Name = "nameTxt";
            this.nameTxt.Size = new System.Drawing.Size(193, 23);
            this.nameTxt.TabIndex = 5;
            // 
            // addressTxt
            // 
            this.addressTxt.Location = new System.Drawing.Point(4, 255);
            this.addressTxt.MaxLength = 100;
            this.addressTxt.Name = "addressTxt";
            this.addressTxt.Size = new System.Drawing.Size(193, 23);
            this.addressTxt.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(4, 237);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "Client Address";
            // 
            // phTxt
            // 
            this.phTxt.Location = new System.Drawing.Point(4, 303);
            this.phTxt.MaxLength = 11;
            this.phTxt.Name = "phTxt";
            this.phTxt.Size = new System.Drawing.Size(193, 23);
            this.phTxt.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(4, 285);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 15);
            this.label6.TabIndex = 8;
            this.label6.Text = "Client Mob No.";
            // 
            // nameError
            // 
            this.nameError.AutoSize = true;
            this.nameError.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameError.ForeColor = System.Drawing.Color.Salmon;
            this.nameError.Location = new System.Drawing.Point(180, 190);
            this.nameError.Name = "nameError";
            this.nameError.Size = new System.Drawing.Size(17, 21);
            this.nameError.TabIndex = 49;
            this.nameError.Text = "*";
            this.nameError.Visible = false;
            // 
            // addressError
            // 
            this.addressError.AutoSize = true;
            this.addressError.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressError.ForeColor = System.Drawing.Color.Salmon;
            this.addressError.Location = new System.Drawing.Point(180, 237);
            this.addressError.Name = "addressError";
            this.addressError.Size = new System.Drawing.Size(17, 21);
            this.addressError.TabIndex = 50;
            this.addressError.Text = "*";
            this.addressError.Visible = false;
            // 
            // numError
            // 
            this.numError.AutoSize = true;
            this.numError.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numError.ForeColor = System.Drawing.Color.Salmon;
            this.numError.Location = new System.Drawing.Point(180, 285);
            this.numError.Name = "numError";
            this.numError.Size = new System.Drawing.Size(17, 21);
            this.numError.TabIndex = 51;
            this.numError.Text = "*";
            this.numError.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(4, 334);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 15);
            this.label9.TabIndex = 52;
            this.label9.Text = "Amount to Pay";
            // 
            // amountPayTxt
            // 
            this.amountPayTxt.Enabled = false;
            this.amountPayTxt.Location = new System.Drawing.Point(4, 352);
            this.amountPayTxt.MaxLength = 1000;
            this.amountPayTxt.Name = "amountPayTxt";
            this.amountPayTxt.Size = new System.Drawing.Size(193, 23);
            this.amountPayTxt.TabIndex = 53;
            // 
            // paidTxt
            // 
            this.paidTxt.Location = new System.Drawing.Point(4, 402);
            this.paidTxt.MaxLength = 1000;
            this.paidTxt.Name = "paidTxt";
            this.paidTxt.Size = new System.Drawing.Size(193, 23);
            this.paidTxt.TabIndex = 55;
            this.paidTxt.Validating += new System.ComponentModel.CancelEventHandler(this.paidTxt_Validating);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(4, 384);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(101, 15);
            this.label10.TabIndex = 54;
            this.label10.Text = "Amount Payment";
            // 
            // paidError
            // 
            this.paidError.AutoSize = true;
            this.paidError.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paidError.ForeColor = System.Drawing.Color.Salmon;
            this.paidError.Location = new System.Drawing.Point(180, 384);
            this.paidError.Name = "paidError";
            this.paidError.Size = new System.Drawing.Size(17, 21);
            this.paidError.TabIndex = 56;
            this.paidError.Text = "*";
            this.paidError.Visible = false;
            // 
            // payBtn
            // 
            this.payBtn.BackColor = System.Drawing.Color.LightCoral;
            this.payBtn.FlatAppearance.BorderSize = 2;
            this.payBtn.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.payBtn.ForeColor = System.Drawing.Color.White;
            this.payBtn.Location = new System.Drawing.Point(4, 432);
            this.payBtn.Name = "payBtn";
            this.payBtn.Size = new System.Drawing.Size(193, 52);
            this.payBtn.TabIndex = 57;
            this.payBtn.Text = "Pay";
            this.payBtn.UseVisualStyleBackColor = false;
            this.payBtn.Click += new System.EventHandler(this.payBtn_Click);
            // 
            // Sales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 514);
            this.Name = "Sales";
            this.Text = "Sales";
            this.Load += new System.EventHandler(this.Sales_Load);
            this.leftPanel.ResumeLayout(false);
            this.leftPanel.PerformLayout();
            this.rightPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox plotTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox clientDD;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox nameTxt;
        private System.Windows.Forms.TextBox phTxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox addressTxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label numError;
        private System.Windows.Forms.Label addressError;
        private System.Windows.Forms.Label nameError;
        private System.Windows.Forms.TextBox amountPayTxt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox paidTxt;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label paidError;
        private System.Windows.Forms.Button payBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn plotIDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn CityGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn sizeGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn PlotNoGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn noOfInstallmentsGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn ppmGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalPrizeGV;
    }
}