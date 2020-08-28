namespace Accounts_Mangement_System
{
    partial class Plots
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.plotIDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.projectIDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cityGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sizeGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StatusGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDD = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.noTxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.sizeTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cityTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.projectTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.projectDD = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.noError = new System.Windows.Forms.Label();
            this.sizeError = new System.Windows.Forms.Label();
            this.cityError = new System.Windows.Forms.Label();
            this.projectError = new System.Windows.Forms.Label();
            this.statusError = new System.Windows.Forms.Label();
            this.leftPanel.SuspendLayout();
            this.rightPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // leftPanel
            // 
            this.leftPanel.Controls.Add(this.statusDD);
            this.leftPanel.Controls.Add(this.label6);
            this.leftPanel.Controls.Add(this.noTxt);
            this.leftPanel.Controls.Add(this.label5);
            this.leftPanel.Controls.Add(this.sizeTxt);
            this.leftPanel.Controls.Add(this.label4);
            this.leftPanel.Controls.Add(this.cityTxt);
            this.leftPanel.Controls.Add(this.label3);
            this.leftPanel.Controls.Add(this.projectTxt);
            this.leftPanel.Controls.Add(this.label2);
            this.leftPanel.Controls.Add(this.projectDD);
            this.leftPanel.Controls.Add(this.label7);
            this.leftPanel.Controls.Add(this.noError);
            this.leftPanel.Controls.Add(this.sizeError);
            this.leftPanel.Controls.Add(this.cityError);
            this.leftPanel.Controls.Add(this.projectError);
            this.leftPanel.Controls.Add(this.statusError);
            this.leftPanel.Size = new System.Drawing.Size(200, 507);
            this.leftPanel.Controls.SetChildIndex(this.panel3, 0);
            this.leftPanel.Controls.SetChildIndex(this.statusError, 0);
            this.leftPanel.Controls.SetChildIndex(this.projectError, 0);
            this.leftPanel.Controls.SetChildIndex(this.cityError, 0);
            this.leftPanel.Controls.SetChildIndex(this.sizeError, 0);
            this.leftPanel.Controls.SetChildIndex(this.noError, 0);
            this.leftPanel.Controls.SetChildIndex(this.label7, 0);
            this.leftPanel.Controls.SetChildIndex(this.projectDD, 0);
            this.leftPanel.Controls.SetChildIndex(this.label2, 0);
            this.leftPanel.Controls.SetChildIndex(this.projectTxt, 0);
            this.leftPanel.Controls.SetChildIndex(this.label3, 0);
            this.leftPanel.Controls.SetChildIndex(this.cityTxt, 0);
            this.leftPanel.Controls.SetChildIndex(this.label4, 0);
            this.leftPanel.Controls.SetChildIndex(this.sizeTxt, 0);
            this.leftPanel.Controls.SetChildIndex(this.label5, 0);
            this.leftPanel.Controls.SetChildIndex(this.noTxt, 0);
            this.leftPanel.Controls.SetChildIndex(this.label6, 0);
            this.leftPanel.Controls.SetChildIndex(this.statusDD, 0);
            // 
            // rightPanel
            // 
            this.rightPanel.Controls.Add(this.dataGridView1);
            this.rightPanel.Size = new System.Drawing.Size(580, 507);
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
            this.projectIDGV,
            this.NameGV,
            this.cityGV,
            this.sizeGV,
            this.noGV,
            this.StatusGV});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 85);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(580, 422);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // plotIDGV
            // 
            this.plotIDGV.HeaderText = "plotID";
            this.plotIDGV.Name = "plotIDGV";
            this.plotIDGV.ReadOnly = true;
            this.plotIDGV.Visible = false;
            // 
            // projectIDGV
            // 
            this.projectIDGV.HeaderText = "projectID";
            this.projectIDGV.Name = "projectIDGV";
            this.projectIDGV.ReadOnly = true;
            this.projectIDGV.Visible = false;
            // 
            // NameGV
            // 
            this.NameGV.HeaderText = "Project Name";
            this.NameGV.Name = "NameGV";
            this.NameGV.ReadOnly = true;
            // 
            // cityGV
            // 
            this.cityGV.HeaderText = "City";
            this.cityGV.Name = "cityGV";
            this.cityGV.ReadOnly = true;
            // 
            // sizeGV
            // 
            this.sizeGV.HeaderText = "Plot Size";
            this.sizeGV.Name = "sizeGV";
            this.sizeGV.ReadOnly = true;
            // 
            // noGV
            // 
            this.noGV.HeaderText = "Plot No #";
            this.noGV.Name = "noGV";
            this.noGV.ReadOnly = true;
            // 
            // StatusGV
            // 
            this.StatusGV.HeaderText = "Status";
            this.StatusGV.Name = "StatusGV";
            this.StatusGV.ReadOnly = true;
            // 
            // statusDD
            // 
            this.statusDD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.statusDD.FormattingEnabled = true;
            this.statusDD.Items.AddRange(new object[] {
            "Vacant",
            "Purchased"});
            this.statusDD.Location = new System.Drawing.Point(3, 379);
            this.statusDD.Name = "statusDD";
            this.statusDD.Size = new System.Drawing.Size(194, 23);
            this.statusDD.TabIndex = 71;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(3, 360);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 15);
            this.label6.TabIndex = 70;
            this.label6.Text = "Status";
            // 
            // noTxt
            // 
            this.noTxt.Location = new System.Drawing.Point(3, 326);
            this.noTxt.MaxLength = 50;
            this.noTxt.Name = "noTxt";
            this.noTxt.Size = new System.Drawing.Size(194, 23);
            this.noTxt.TabIndex = 65;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(3, 307);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 15);
            this.label5.TabIndex = 64;
            this.label5.Text = "Plot No #";
            // 
            // sizeTxt
            // 
            this.sizeTxt.Location = new System.Drawing.Point(3, 272);
            this.sizeTxt.MaxLength = 100;
            this.sizeTxt.Name = "sizeTxt";
            this.sizeTxt.Size = new System.Drawing.Size(194, 23);
            this.sizeTxt.TabIndex = 63;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(3, 253);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 15);
            this.label4.TabIndex = 62;
            this.label4.Text = "Plot Size";
            // 
            // cityTxt
            // 
            this.cityTxt.Location = new System.Drawing.Point(3, 220);
            this.cityTxt.MaxLength = 100;
            this.cityTxt.Name = "cityTxt";
            this.cityTxt.Size = new System.Drawing.Size(194, 23);
            this.cityTxt.TabIndex = 61;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(3, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 15);
            this.label3.TabIndex = 60;
            this.label3.Text = "City";
            // 
            // projectTxt
            // 
            this.projectTxt.Location = new System.Drawing.Point(3, 171);
            this.projectTxt.MaxLength = 100;
            this.projectTxt.Name = "projectTxt";
            this.projectTxt.Size = new System.Drawing.Size(194, 23);
            this.projectTxt.TabIndex = 59;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(3, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 15);
            this.label2.TabIndex = 58;
            this.label2.Text = "New Project";
            // 
            // projectDD
            // 
            this.projectDD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.projectDD.FormattingEnabled = true;
            this.projectDD.Location = new System.Drawing.Point(3, 122);
            this.projectDD.Name = "projectDD";
            this.projectDD.Size = new System.Drawing.Size(194, 23);
            this.projectDD.TabIndex = 57;
            this.projectDD.SelectedIndexChanged += new System.EventHandler(this.projectDD_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(3, 104);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 15);
            this.label7.TabIndex = 56;
            this.label7.Text = "Existing Projects";
            // 
            // noError
            // 
            this.noError.AutoSize = true;
            this.noError.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noError.ForeColor = System.Drawing.Color.Salmon;
            this.noError.Location = new System.Drawing.Point(180, 307);
            this.noError.Name = "noError";
            this.noError.Size = new System.Drawing.Size(17, 21);
            this.noError.TabIndex = 66;
            this.noError.Text = "*";
            this.noError.Visible = false;
            // 
            // sizeError
            // 
            this.sizeError.AutoSize = true;
            this.sizeError.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sizeError.ForeColor = System.Drawing.Color.Salmon;
            this.sizeError.Location = new System.Drawing.Point(180, 253);
            this.sizeError.Name = "sizeError";
            this.sizeError.Size = new System.Drawing.Size(17, 21);
            this.sizeError.TabIndex = 67;
            this.sizeError.Text = "*";
            this.sizeError.Visible = false;
            // 
            // cityError
            // 
            this.cityError.AutoSize = true;
            this.cityError.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cityError.ForeColor = System.Drawing.Color.Salmon;
            this.cityError.Location = new System.Drawing.Point(180, 202);
            this.cityError.Name = "cityError";
            this.cityError.Size = new System.Drawing.Size(17, 21);
            this.cityError.TabIndex = 68;
            this.cityError.Text = "*";
            this.cityError.Visible = false;
            // 
            // projectError
            // 
            this.projectError.AutoSize = true;
            this.projectError.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.projectError.ForeColor = System.Drawing.Color.Salmon;
            this.projectError.Location = new System.Drawing.Point(180, 153);
            this.projectError.Name = "projectError";
            this.projectError.Size = new System.Drawing.Size(17, 21);
            this.projectError.TabIndex = 69;
            this.projectError.Text = "*";
            this.projectError.Visible = false;
            // 
            // statusError
            // 
            this.statusError.AutoSize = true;
            this.statusError.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusError.ForeColor = System.Drawing.Color.Salmon;
            this.statusError.Location = new System.Drawing.Point(180, 360);
            this.statusError.Name = "statusError";
            this.statusError.Size = new System.Drawing.Size(17, 21);
            this.statusError.TabIndex = 72;
            this.statusError.Text = "*";
            this.statusError.Visible = false;
            // 
            // Plots
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 507);
            this.Name = "Plots";
            this.Text = "Plots";
            this.Load += new System.EventHandler(this.Plots_Load);
            this.leftPanel.ResumeLayout(false);
            this.leftPanel.PerformLayout();
            this.rightPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn plotIDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn projectIDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn sizeGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn noGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn StatusGV;
        private System.Windows.Forms.ComboBox statusDD;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox noTxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox sizeTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox cityTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox projectTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox projectDD;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label noError;
        private System.Windows.Forms.Label sizeError;
        private System.Windows.Forms.Label cityError;
        private System.Windows.Forms.Label projectError;
        private System.Windows.Forms.Label statusError;
    }
}