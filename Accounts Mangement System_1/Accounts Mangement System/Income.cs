using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
    public partial class Income : Sample
    {
        int edit = 0; //this 0 is an indication for save operation and 1 is an indication for update operation
        Int64 incomeID, clientID, client_id_GV;
        object Client_ID;
        reterival r = new reterival();
        insertion i = new insertion();
        updation u = new updation();
        Regex reg = new Regex(@"^-?[0-9][0-9,\.]+$");
        string[] bankAmount = new string[2];
        public Income()
        {
            InitializeComponent();
        }

        private void Income_Load(object sender, EventArgs e)
        {
            userLabel.Text = "Income";
            r.getList("st_getClientList", existingClientsDD, "Client Name", "ID");
            r.showIncomeDetails(dataGridView1, clientIDGV, incomeIDGV, DescriptionGV, AmountGV, DateGV, nameGV);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

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
            saveFileDialoge.FileName = "ReportView_Income";
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

        private void AddBtn_Click_1(object sender, EventArgs e)
        {
            if (!(reg.IsMatch(amountRecTxt.Text)))
            {
                MessageBox.Show("Invalid Amount");
                amountRecTxt.Text = "";
                amountRecTxt.Focus();
            }

            if (amountRecTxt.Text == "")
                amountError.Visible = true;
            else
                amountError.Visible = false;

            if (descTxt.Text == "")
               DescError.Visible = true;
            else
                DescError.Visible = false;

            if (amountError.Visible || DescError.Visible)
            {
                MainClass.show_msg("Fields with * are mandatory", "Stop", "Error"); //Error is the type of msg
            }
            else
            {
                object checkIncomeByDate = r.getIncomeAmount(datepicker.Value);
                float updatedIncomeAmount = Convert.ToSingle(amountRecTxt.Text) + Convert.ToSingle(checkIncomeByDate);

                if (clientNameTxt.Text != "")
                {
                    i.insertClients(clientNameTxt.Text, null, 1);
                    Client_ID = r.getClientID();
                    clientID = Convert.ToInt64(Client_ID);
                    i.insertClientAccount(datepicker.Value, clientID, descTxt.Text, Convert.ToSingle(amountRecTxt.Text), 0);
                    i.insertIncomeDetails(Convert.ToSingle(amountRecTxt.Text), descTxt.Text, datepicker.Value, clientID);
                }
                else
                {
                    i.insertClientAccount(datepicker.Value, Convert.ToInt64(existingClientsDD.SelectedValue), descTxt.Text, Convert.ToSingle(amountRecTxt.Text), 0);
                    i.insertIncomeDetails(Convert.ToSingle(amountRecTxt.Text), descTxt.Text, datepicker.Value, Convert.ToInt64(existingClientsDD.SelectedValue));
                }
                if (checkIncomeByDate == null)
                    i.insertIncomeDaily(Convert.ToSingle(amountRecTxt.Text), datepicker.Value);
                else
                    u.updateIncomeDaily(updatedIncomeAmount, datepicker.Value);
                r.showIncomeDetails(dataGridView1, clientIDGV, incomeIDGV, DescriptionGV, AmountGV, DateGV, nameGV);
            }
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            HomeScreen obj = new HomeScreen();
            MainClass.show_window(obj, this, Form1.ActiveForm);
        }
    }
}
