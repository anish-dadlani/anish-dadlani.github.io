﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using Excel = Microsoft.Office.Interop.Excel;
using System.IO;
using System.Reflection;

namespace Accounts_Mangement_System
{
    public partial class Users : Sample2
    {
        int edit = 0; //this 0 is an indication for save operation and 1 is an indication for update operation
        Int64 userID;
        short stat;
        reterival r = new reterival();
        Regex reg = new Regex(@"^-?[0-9][0-9,\.]+$");
        public Users()
        {
            InitializeComponent();
        }

        private void Users_Load(object sender, EventArgs e)
        {
            MainClass.disable_reset(leftPanel);
            userLabel.Text = reterival.EMP_NAME;
            r.show_users(dataGridView1, userIDGV, NameGV, UserNameGV, PassGV, PhoneGV, EmailGV, StatusGV);
        }

        public override void addBtn_Click(object sender, EventArgs e)
        {
            MainClass.enable_reset(leftPanel);
            edit = 0;
        }

        public override void editBtn_Click(object sender, EventArgs e)
        {
            edit = 1;
            MainClass.enable(leftPanel);
        }

        public override void savebtn_Click(object sender, EventArgs e)
        {
            string pattern = null;
            pattern = "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";

            if (nameTxt.Text == "")
                nameError.Visible = true;
            else
                nameError.Visible = false;

            if (usernameTxt.Text == "")
                usrError.Visible = true;
            else
                usrError.Visible = false;

            if (pwdTxt.Text == "")
                pwdError.Visible = true;
            else
                pwdError.Visible = false;

            if (phTxt.Text.Length < 11 || !(reg.IsMatch(phTxt.Text)) || !(phTxt.Text.StartsWith("03")))
            {
                MessageBox.Show("Invalid Phone No.");
                phTxt.Text = "";
                phTxt.Focus();
            }

            if (phTxt.Text == "")
                phError.Visible = true;
            else
                phError.Visible = false;

            if (!(Regex.IsMatch(emailTxt.Text, pattern)))
            {
                MessageBox.Show("Invalid Email Address.");
                emailTxt.Text = "";
                emailTxt.Focus();
            }

            if (emailTxt.Text == "")
                emailError.Visible = true;
            else
                emailError.Visible = false;

            if (statusCB.SelectedIndex == -1)
                statusError.Visible = true;
            else
                statusError.Visible = false;

            if (nameError.Visible || usrError.Visible || pwdError.Visible || phError.Visible || emailError.Visible || statusError.Visible)
            {
                MainClass.show_msg("Fields with * are mandatory", "Stop", "Error"); //Error is the type of msg
            }
            else
            {
                if (statusCB.SelectedIndex == 0)
                {
                    stat = 1;
                }
                else if (statusCB.SelectedIndex == 1)
                {
                    stat = 0;
                }
                if (edit == 0) // code for save operation
                {
                    insertion i = new insertion();
                    i.insertUsers(nameTxt.Text, usernameTxt.Text, pwdTxt.Text, emailTxt.Text, phTxt.Text, stat);
                    r.show_users(dataGridView1, userIDGV, NameGV, UserNameGV, PassGV, PhoneGV, EmailGV, StatusGV);
                    MainClass.disable_reset(leftPanel);
                }
                else if (edit == 1) // code for update operation
                {
                    DialogResult dr = MessageBox.Show("Are you sure, you want to update record?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        updation u = new updation();

                        if (statusCB.SelectedIndex == 0)
                            stat = 1;
                        else if (statusCB.SelectedIndex == 1)
                            stat = 0;

                        u.updateUsers(userID, nameTxt.Text, usernameTxt.Text, pwdTxt.Text, emailTxt.Text, phTxt.Text, stat);
                        r.show_users(dataGridView1, userIDGV, NameGV, UserNameGV, PassGV, PhoneGV, EmailGV, StatusGV);
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
                    d.delete(userID, "st_deleteUser", "@id");
                    r.show_users(dataGridView1, userIDGV, NameGV, UserNameGV, PassGV, PhoneGV, EmailGV, StatusGV);
                }
            }
        }

        public override void viewBtn_Click(object sender, EventArgs e)
        {
            r.show_users(dataGridView1, userIDGV, NameGV, UserNameGV, PassGV, PhoneGV, EmailGV, StatusGV);
        }

        public override void searchTxt_TextChanged(object sender, EventArgs e)
        {
            if (searchTxt.Text != "")
            {
                r.show_users(dataGridView1, userIDGV, NameGV, UserNameGV, PassGV, PhoneGV, EmailGV, StatusGV, searchTxt.Text);
            }
            else
            {
                r.show_users(dataGridView1, userIDGV, NameGV, UserNameGV, PassGV, PhoneGV, EmailGV, StatusGV);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                edit = 1;
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                userID = Convert.ToInt32(row.Cells["userIDGV"].Value.ToString());
                nameTxt.Text = row.Cells["NameGV"].Value.ToString();
                usernameTxt.Text = row.Cells["UserNameGV"].Value.ToString();
                pwdTxt.Text = row.Cells["PassGV"].Value.ToString();
                phTxt.Text = row.Cells["PhoneGV"].Value.ToString();
                emailTxt.Text = row.Cells["EmailGV"].Value.ToString();
                statusCB.SelectedItem = row.Cells["StatusGV"].Value.ToString();
                MainClass.disable(leftPanel);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Excel.Application xlApp;
            Excel.Workbook xlWorkBook;
            Excel.Worksheet xlWorkSheet;
            object misValue = System.Reflection.Missing.Value;

            xlApp = new Excel.Application();
            xlWorkBook = xlApp.Workbooks.Add(misValue);
            xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);


            for (int x = 1; x < dataGridView1.Columns.Count + 1; x++)
            {
                xlWorkSheet.Cells[1, x] = dataGridView1.Columns[x - 1].HeaderText;
            }

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {
                    xlWorkSheet.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value.ToString();
                }
            }

            var saveFileDialoge = new SaveFileDialog();
            saveFileDialoge.FileName = "ReportView_Users";
            saveFileDialoge.DefaultExt = ".xlsx";
            if (saveFileDialoge.ShowDialog() == DialogResult.OK)
            {
                xlWorkBook.SaveAs(saveFileDialoge.FileName, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            }

            xlWorkBook.Close(true, misValue, misValue);
            xlApp.Quit();

            releaseObject(xlWorkSheet);
            releaseObject(xlWorkBook);
            releaseObject(xlApp);
        }

        private void releaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                MessageBox.Show("Exception Occured while releasing object " + ex.ToString());
            }
            finally
            {
                GC.Collect();
            }
        }
    }
}
