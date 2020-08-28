namespace Accounts_Mangement_System
{
    partial class Installment_Plans
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label3 = new System.Windows.Forms.Label();
            this.projectDD = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.selectGV = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.IP_IDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.plotIDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.projectIDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cityGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sizeGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noOfInstallmentGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PricePerMarlaGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalPriceGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.leftPanel.SuspendLayout();
            this.rightPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // leftPanel
            // 
            this.leftPanel.Controls.Add(this.label3);
            this.leftPanel.Controls.Add(this.projectDD);
            this.leftPanel.Size = new System.Drawing.Size(200, 486);
            this.leftPanel.Controls.SetChildIndex(this.panel3, 0);
            this.leftPanel.Controls.SetChildIndex(this.projectDD, 0);
            this.leftPanel.Controls.SetChildIndex(this.label3, 0);
            // 
            // rightPanel
            // 
            this.rightPanel.Controls.Add(this.dataGridView1);
            this.rightPanel.Size = new System.Drawing.Size(431, 486);
            this.rightPanel.Controls.SetChildIndex(this.dataGridView1, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(2, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Select Project";
            // 
            // projectDD
            // 
            this.projectDD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.projectDD.FormattingEnabled = true;
            this.projectDD.Location = new System.Drawing.Point(3, 113);
            this.projectDD.Name = "projectDD";
            this.projectDD.Size = new System.Drawing.Size(194, 23);
            this.projectDD.TabIndex = 7;
            this.projectDD.SelectedIndexChanged += new System.EventHandler(this.projectDD_SelectedIndexChanged);
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
            this.selectGV,
            this.IP_IDGV,
            this.plotIDGV,
            this.projectIDGV,
            this.nameGV,
            this.cityGV,
            this.sizeGV,
            this.noOfInstallmentGV,
            this.PricePerMarlaGV,
            this.TotalPriceGV});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 85);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView1.Size = new System.Drawing.Size(431, 401);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEndEdit);
            this.dataGridView1.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridView1_DataError);
            // 
            // selectGV
            // 
            this.selectGV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.selectGV.FalseValue = "0";
            this.selectGV.HeaderText = "";
            this.selectGV.Name = "selectGV";
            this.selectGV.TrueValue = "1";
            this.selectGV.Width = 5;
            // 
            // IP_IDGV
            // 
            this.IP_IDGV.HeaderText = "installPlanID";
            this.IP_IDGV.Name = "IP_IDGV";
            this.IP_IDGV.ReadOnly = true;
            this.IP_IDGV.Visible = false;
            // 
            // plotIDGV
            // 
            this.plotIDGV.HeaderText = "Plot ID";
            this.plotIDGV.Name = "plotIDGV";
            this.plotIDGV.ReadOnly = true;
            this.plotIDGV.Visible = false;
            // 
            // projectIDGV
            // 
            this.projectIDGV.HeaderText = "Project ID";
            this.projectIDGV.Name = "projectIDGV";
            this.projectIDGV.ReadOnly = true;
            this.projectIDGV.Visible = false;
            // 
            // nameGV
            // 
            this.nameGV.HeaderText = "Project Name";
            this.nameGV.Name = "nameGV";
            this.nameGV.ReadOnly = true;
            // 
            // cityGV
            // 
            this.cityGV.HeaderText = "City";
            this.cityGV.Name = "cityGV";
            this.cityGV.ReadOnly = true;
            // 
            // sizeGV
            // 
            this.sizeGV.HeaderText = "Size";
            this.sizeGV.Name = "sizeGV";
            this.sizeGV.ReadOnly = true;
            // 
            // noOfInstallmentGV
            // 
            dataGridViewCellStyle2.NullValue = null;
            this.noOfInstallmentGV.DefaultCellStyle = dataGridViewCellStyle2;
            this.noOfInstallmentGV.HeaderText = "No# of Installments";
            this.noOfInstallmentGV.Name = "noOfInstallmentGV";
            // 
            // PricePerMarlaGV
            // 
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = null;
            this.PricePerMarlaGV.DefaultCellStyle = dataGridViewCellStyle3;
            this.PricePerMarlaGV.HeaderText = "Price Per Marla";
            this.PricePerMarlaGV.Name = "PricePerMarlaGV";
            // 
            // TotalPriceGV
            // 
            dataGridViewCellStyle4.Format = "N2";
            dataGridViewCellStyle4.NullValue = null;
            this.TotalPriceGV.DefaultCellStyle = dataGridViewCellStyle4;
            this.TotalPriceGV.HeaderText = "Total Price";
            this.TotalPriceGV.Name = "TotalPriceGV";
            this.TotalPriceGV.ReadOnly = true;
            // 
            // Installment_Plans
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 486);
            this.Name = "Installment_Plans";
            this.Text = "Installment_Plans";
            this.Load += new System.EventHandler(this.Installment_Plans_Load);
            this.leftPanel.ResumeLayout(false);
            this.leftPanel.PerformLayout();
            this.rightPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox projectDD;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn selectGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn IP_IDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn plotIDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn projectIDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn sizeGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn noOfInstallmentGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn PricePerMarlaGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalPriceGV;
    }
}