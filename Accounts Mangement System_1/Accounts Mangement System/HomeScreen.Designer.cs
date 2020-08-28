namespace Accounts_Mangement_System
{
    partial class HomeScreen
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.clientsBtn = new System.Windows.Forms.Button();
            this.incomeBtn = new System.Windows.Forms.Button();
            this.expenditureBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.clientBtn = new System.Windows.Forms.Button();
            this.surmailBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.leftPanel.SuspendLayout();
            this.rightPanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // leftPanel
            // 
            this.leftPanel.Controls.Add(this.label2);
            this.leftPanel.Size = new System.Drawing.Size(200, 508);
            this.leftPanel.Controls.SetChildIndex(this.panel3, 0);
            this.leftPanel.Controls.SetChildIndex(this.label2, 0);
            // 
            // rightPanel
            // 
            this.rightPanel.Controls.Add(this.tableLayoutPanel1);
            this.rightPanel.Size = new System.Drawing.Size(431, 508);
            this.rightPanel.Controls.SetChildIndex(this.tableLayoutPanel1, 0);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.clientsBtn, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.incomeBtn, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.expenditureBtn, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.button1, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.clientBtn, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.surmailBtn, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 40);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.9992F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.9992F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.9992F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.9992F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(431, 468);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // clientsBtn
            // 
            this.clientsBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clientsBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clientsBtn.FlatAppearance.BorderSize = 2;
            this.clientsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clientsBtn.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientsBtn.Image = global::Accounts_Mangement_System.Properties.Resources.user_64;
            this.clientsBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.clientsBtn.Location = new System.Drawing.Point(3, 3);
            this.clientsBtn.Name = "clientsBtn";
            this.clientsBtn.Size = new System.Drawing.Size(101, 111);
            this.clientsBtn.TabIndex = 1;
            this.clientsBtn.Text = "Clients";
            this.clientsBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.clientsBtn.UseVisualStyleBackColor = true;
            this.clientsBtn.Click += new System.EventHandler(this.clientsBtn_Click);
            // 
            // incomeBtn
            // 
            this.incomeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.incomeBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.incomeBtn.FlatAppearance.BorderSize = 2;
            this.incomeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.incomeBtn.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.incomeBtn.Image = global::Accounts_Mangement_System.Properties.Resources.money;
            this.incomeBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.incomeBtn.Location = new System.Drawing.Point(110, 3);
            this.incomeBtn.Name = "incomeBtn";
            this.incomeBtn.Size = new System.Drawing.Size(101, 111);
            this.incomeBtn.TabIndex = 2;
            this.incomeBtn.Text = "Income";
            this.incomeBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.incomeBtn.UseVisualStyleBackColor = true;
            this.incomeBtn.Click += new System.EventHandler(this.incomeBtn_Click);
            // 
            // expenditureBtn
            // 
            this.expenditureBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.expenditureBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.expenditureBtn.FlatAppearance.BorderSize = 2;
            this.expenditureBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.expenditureBtn.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expenditureBtn.Image = global::Accounts_Mangement_System.Properties.Resources.expenses__1_;
            this.expenditureBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.expenditureBtn.Location = new System.Drawing.Point(217, 3);
            this.expenditureBtn.Name = "expenditureBtn";
            this.expenditureBtn.Size = new System.Drawing.Size(101, 111);
            this.expenditureBtn.TabIndex = 3;
            this.expenditureBtn.Text = "Expenditure";
            this.expenditureBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.expenditureBtn.UseVisualStyleBackColor = true;
            this.expenditureBtn.Click += new System.EventHandler(this.expenditureBtn_Click);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::Accounts_Mangement_System.Properties.Resources.ledger__4_;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(324, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 111);
            this.button1.TabIndex = 4;
            this.button1.Text = "Cash on Hand";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // clientBtn
            // 
            this.clientBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clientBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clientBtn.FlatAppearance.BorderSize = 2;
            this.clientBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clientBtn.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientBtn.Image = global::Accounts_Mangement_System.Properties.Resources.ledger__3_;
            this.clientBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.clientBtn.Location = new System.Drawing.Point(3, 120);
            this.clientBtn.Name = "clientBtn";
            this.clientBtn.Size = new System.Drawing.Size(101, 111);
            this.clientBtn.TabIndex = 5;
            this.clientBtn.Text = "Accounts";
            this.clientBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.clientBtn.UseVisualStyleBackColor = true;
            this.clientBtn.Click += new System.EventHandler(this.clientBtn_Click);
            // 
            // surmailBtn
            // 
            this.surmailBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.surmailBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.surmailBtn.FlatAppearance.BorderSize = 2;
            this.surmailBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.surmailBtn.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.surmailBtn.Image = global::Accounts_Mangement_System.Properties.Resources.ledger__2_;
            this.surmailBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.surmailBtn.Location = new System.Drawing.Point(110, 120);
            this.surmailBtn.Name = "surmailBtn";
            this.surmailBtn.Size = new System.Drawing.Size(101, 111);
            this.surmailBtn.TabIndex = 6;
            this.surmailBtn.Text = "Surmail";
            this.surmailBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.surmailBtn.UseVisualStyleBackColor = true;
            this.surmailBtn.Click += new System.EventHandler(this.surmailBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Script", 18.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(2, 215);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 117);
            this.label2.TabIndex = 1;
            this.label2.Text = "Accounts \r\nManagement \r\nSystem";
            // 
            // HomeScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 508);
            this.Name = "HomeScreen";
            this.Text = "HomeScreen";
            this.Load += new System.EventHandler(this.HomeScreen_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.HomeScreen_KeyDown);
            this.leftPanel.ResumeLayout(false);
            this.leftPanel.PerformLayout();
            this.rightPanel.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button clientsBtn;
        private System.Windows.Forms.Button incomeBtn;
        private System.Windows.Forms.Button expenditureBtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button clientBtn;
        private System.Windows.Forms.Button surmailBtn;
    }
}