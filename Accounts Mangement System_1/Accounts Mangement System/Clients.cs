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
using System.Data.OleDb;
using Excel = Microsoft.Office.Interop.Excel;
using System.IO;
using System.Reflection;

namespace Accounts_Mangement_System
{
    public partial class Clients : Sample2
    {
        int edit = 0; //this 0 is an indication for save operation and 1 is an indication for update operation
        Int64 clientID;
        short stat;
        reterival r = new reterival();
        Regex reg = new Regex(@"^-?[0-9][0-9,\.]+$");
        public Clients()
        {
            InitializeComponent();
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
            if (nameTxt.Text == "")
                nameError.Visible = true;
            else
                nameError.Visible = false;

            if (addressTxt.Text == "")
                addressError.Visible = true;
            else
                addressError.Visible = false;

            if (statusCB.SelectedIndex == -1)
                statusError.Visible = true;
            else
                statusError.Visible = false;

            if (nameError.Visible || addressError.Visible || statusError.Visible)
            {
                MainClass.show_msg("Fields with * are mandatory", "Stop", "Error"); //Error is the type of msg
            }
            else
            {
                if (statusCB.SelectedIndex == 0)
                    stat = 1;
                else if (statusCB.SelectedIndex == 1)
                    stat = 0;

                if (edit == 0) // code for save operation
                {
                    insertion i = new insertion();
                    i.insertClients(nameTxt.Text, addressTxt.Text, stat);
                    r.showClients(dataGridView1, clientIDGV, NameGV, addressGV, StatusGV);
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

                        u.updateClients(clientID, nameTxt.Text, addressTxt.Text, stat);
                        r.showClients(dataGridView1, clientIDGV, NameGV, addressGV, StatusGV);
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
                    d.delete(clientID, "st_deleteClient", "@id");
                    r.showClients(dataGridView1, clientIDGV, NameGV, addressGV, StatusGV);
                }
            }
        }

        public override void viewBtn_Click(object sender, EventArgs e)
        {
            r.showClients(dataGridView1, clientIDGV, NameGV, addressGV, StatusGV);
        }

        public override void searchTxt_TextChanged(object sender, EventArgs e)
        {
            if (searchTxt.Text != "")
                r.showClients(dataGridView1, clientIDGV, NameGV, addressGV, StatusGV, searchTxt.Text);
            else
                r.showClients(dataGridView1, clientIDGV, NameGV, addressGV, StatusGV);
        }

        private void Clients_Load(object sender, EventArgs e)
        {
            MainClass.disable_reset(leftPanel);
            userLabel.Text = "Clients";
            r.showClients(dataGridView1, clientIDGV, NameGV, addressGV, StatusGV);
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
