using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Accounts_Mangement_System
{
    public partial class client : Sample2
    {
        int edit = 0; //this 0 is an indication for save operation and 1 is an indication for update operation
        Int64 clientID;
        insertion i = new insertion();
        reterival r = new reterival();
        updation u = new updation();
        Regex reg = new Regex(@"^-?[0-9][0-9,\.]+$");

        public client()
        {
            InitializeComponent();
        }

        private void client_Load(object sender, EventArgs e)
        {
            MainClass.disable_reset(leftPanel);
            r.show_clients(dataGridView1, clientIDGV, NameGV, addressGV, PhoneGV);
            userLabel.Text = reterival.EMP_NAME;
        }

        public override void addBtn_Click(object sender, EventArgs e)
        {
            MainClass.enable_reset(leftPanel);
            edit = 0;
            nameTxt.Focus();
        }

        public override void editBtn_Click(object sender, EventArgs e)
        {
            edit = 1;
            MainClass.enable(leftPanel);
        }

        public override void savebtn_Click(object sender, EventArgs e)
        {
            if (nameTxt.Text == "")
                nameError.Visible = true;
            else
                nameError.Visible = false;

            if (addressTxt.Text == "")
                usrError.Visible = true;
            else
                usrError.Visible = false;

            if (phTxt.Text.Length < 11 || !(reg.IsMatch(phTxt.Text)) || !(phTxt.Text.StartsWith("03")))
            {
                MessageBox.Show("Invalid Mobile No.");
                phTxt.Text = "";
                phTxt.Focus();
            }

            if (phTxt.Text == "")
                phError.Visible = true;
            else
                phError.Visible = false;

            if (nameError.Visible || usrError.Visible || phError.Visible)
            {
                MainClass.show_msg("Fields with * are mandatory", "Stop", "Error"); //Error is the type of msg
            }
            else
            {
                if (edit == 0) // code for save operation
                {
                    i.insertClients(nameTxt.Text, addressTxt.Text, phTxt.Text);
                    r.show_clients(dataGridView1, clientIDGV, NameGV, addressGV, PhoneGV);
                    MainClass.disable_reset(leftPanel);
                }
                else if (edit == 1) // code for update operation
                {
                    DialogResult dr = MessageBox.Show("Are you sure, you want to update record?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        u.updateClients(clientID, nameTxt.Text, addressTxt.Text, phTxt.Text);
                        r.show_clients(dataGridView1, clientIDGV, NameGV, addressGV, PhoneGV);
                        MainClass.disable_reset(leftPanel);
                    }
                }
            }
        }

        public override void delBtn_Click(object sender, EventArgs e)
        {
            if (edit == 1)
            {
                DialogResult dr = MessageBox.Show("Are you sure, you want to delete record?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    deletion d = new deletion();
                    d.delete(clientID, "st_deleteClients", "@id");
                    r.show_clients(dataGridView1, clientIDGV, NameGV, addressGV, PhoneGV);
                }
            }
        }

        public override void viewBtn_Click(object sender, EventArgs e)
        {
            r.show_clients(dataGridView1, clientIDGV, NameGV, addressGV, PhoneGV);
        }

        public override void searchTxt_TextChanged(object sender, EventArgs e)
        {
            if (searchTxt.Text != "")
                r.show_clients(dataGridView1, clientIDGV, NameGV, addressGV, PhoneGV, searchTxt.Text);
            else
                r.show_clients(dataGridView1, clientIDGV, NameGV, addressGV, PhoneGV);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                edit = 1;
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                clientID = Convert.ToInt32(row.Cells["clientIDGV"].Value.ToString());
                nameTxt.Text = row.Cells["NameGV"].Value.ToString();
                addressTxt.Text = row.Cells["addressGV"].Value.ToString();
                phTxt.Text = row.Cells["PhoneGV"].Value.ToString();
                MainClass.disable(leftPanel);
            }
        }
    }
}
