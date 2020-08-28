﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Accounts_Mangement_System
{
    public partial class settings : Sample
    {
        public settings()
        {
            InitializeComponent();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            string s;
            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            if (isCB.Checked)
            {
                if (server_text.Text != "" && database_text.Text != "")
                {
                    s = "Data Source=" + server_text.Text + ";Initial Catalog=" + database_text.Text + ";Integrated Security=true;MultipleActiveResultSets=true;";
                    File.WriteAllText(path + "\\connect_account", s);
                    DialogResult dr = MessageBox.Show("Settings Saved Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (dr == DialogResult.OK)
                    {
                        login log = new login();
                        MainClass.show_window(log, this, Form1.ActiveForm);
                    }
                }
                else
                {
                    MessageBox.Show("Please provide complete information");
                }
            }
            else
            {
                if (server_text.Text != "" && database_text.Text != "" && user_id_text.Text != "" && password_db_text.Text != "")
                {
                    s = "Data Source=" + server_text.Text + ";Initial Catalog=" + database_text.Text + ";User ID=" + user_id_text.Text + ";Password=" + password_db_text.Text + ";MultipleActiveResultSets=true;";
                    File.WriteAllText(path + "\\connect_account", s);
                    DialogResult dr = MessageBox.Show("Settings Saved Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (dr == DialogResult.OK)
                    {
                        login log = new login();
                        MainClass.show_window(log, this, Form1.ActiveForm);
                    }
                }
                else
                {
                    MessageBox.Show("Please provide complete information");
                }
            }
        }

        private void isCB_CheckedChanged(object sender, EventArgs e)
        {
            if (isCB.Checked)
            {
                user_id_text.Enabled = false;
                password_db_text.Enabled = false;
                user_id_text.Text = "";
                password_db_text.Text = "";
            }
            else
            {
                user_id_text.Enabled = true;
                password_db_text.Enabled = true;
            }
        }
    }
}
