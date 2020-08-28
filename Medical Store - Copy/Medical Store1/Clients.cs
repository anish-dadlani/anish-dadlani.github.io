﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using Excel = Microsoft.Office.Interop.Excel;
using System.IO;
using System.Reflection;
using System.Text.RegularExpressions;

namespace Medical_Store
{
    public partial class Clients : Sample2
    {
        int edit = 0; //this 0 is an indication for save operation and 1 is an indication for update operation
        int custID;
        reterival r = new reterival();
        Regex reg = new Regex(@"^-?[0-9][0-9,\.]+$");
        public Clients()
        {
            InitializeComponent();
        }

        private void Clients_Load(object sender, EventArgs e)
        {
            MainClass.disable_reset(leftPanel);
            r.showCustomers(dataGridView1, custIDGV, custtNameGV, mobileGV, addressGV);
            userLabel.Text = reterival.EMP_NAME;
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
            if (customerTxt.Text == "")
                customerNError.Visible = true;
            else
                customerNError.Visible = false;

            if (mobileTxt.Text.Length < 11 || !(reg.IsMatch(mobileTxt.Text)) || !(mobileTxt.Text.StartsWith("03")))
            {
                MessageBox.Show("Invalid Phone No.");
                mobileTxt.Text = "";
                mobileTxt.Focus();
            }

            if (mobileTxt.Text == "")
                mobileError.Visible = true;
            else
                mobileError.Visible = false;

            if (addressTxt.Text == "")
                addressError.Visible = true;
            else
                addressError.Visible = false;

            if (customerNError.Visible || mobileError.Visible | addressError.Visible)
            {
                MainClass.show_msg("Fields with * are mandatory", "Stop", "Error"); //Error is the type of msg
            }
            else
            {
                if (edit == 0) // code for save operation
                {
                    insertion i = new insertion();
                    i.insertCustomers(customerTxt.Text, mobileTxt.Text, addressTxt.Text);
                    r.showCustomers(dataGridView1, custIDGV, custtNameGV, mobileGV, addressGV);
                    MainClass.disable_reset(leftPanel);

                }
                else if (edit == 1) // code for update operation
                {
                    DialogResult dr = MessageBox.Show("Are you sure, you want to update record?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        updation u = new updation();
                        u.updateCustomers(custID, customerTxt.Text, mobileTxt.Text, addressTxt.Text);
                        r.showCustomers(dataGridView1, custIDGV, custtNameGV, mobileGV, addressGV);
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
                    d.delete(custID, "st_deleteCustomer", "@id");
                    r.showCustomers(dataGridView1, custIDGV, custtNameGV, mobileGV, addressGV);
                    MainClass.disable_reset(leftPanel);
                }
            }
        }

        public override void searchTxt_TextChanged(object sender, EventArgs e)
        {
            if (searchTxt.Text != "")
            {
                r.showCustomers(dataGridView1, custIDGV, custtNameGV, mobileGV, addressGV, searchTxt.Text);
            }
            else
            {
                r.showCustomers(dataGridView1, custIDGV, custtNameGV, mobileGV, addressGV);
            }
        }

        public override void viewBtn_Click(object sender, EventArgs e)
        {
            r.showCustomers(dataGridView1, custIDGV, custtNameGV, mobileGV, addressGV);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                edit = 1;
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                custID = Convert.ToInt32(row.Cells["custIDGV"].Value.ToString());
                customerTxt.Text = row.Cells["custtNameGV"].Value.ToString();
                mobileTxt.Text = row.Cells["mobileGV"].Value.ToString();
                addressTxt.Text = row.Cells["addressGV"].Value.ToString();
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
            saveFileDialoge.FileName = "ReportView_Clients";
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
