using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Data.OleDb;
using Excel = Microsoft.Office.Interop.Excel;
using System.IO;
using System.Reflection;

namespace Accounts_Mangement_System
{
    public partial class Surmail : Sample
    {
        reterival r = new reterival();
        public Surmail()
        {
            InitializeComponent();
        }

        private void Surmail_Load(object sender, EventArgs e)
        {
            userLabel.Text = "Surmail";
        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            HomeScreen obj = new HomeScreen();
            MainClass.show_window(obj, this, Form1.ActiveForm);
        }

        private void loadBtn_Click(object sender, EventArgs e)
        {
            //--sum (ca.credit  - ca.debit) OVER (ORDER BY ca.client_id) AS Balance
            r.showSurmail(dataGridView1, DateFromPicker.Value, DateToPicker.Value, clientAccountIDGV, descGV, CreditAmountGV, DebitAmountGV, DateGV);
            dataGridView1[1, dataGridView1.Rows.Count - 1].Value = "Total";

            float sum_credit = 0, sum_debit = 0;

            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                float value_credit = Convert.ToSingle(dataGridView1.Rows[i].Cells[3].Value);
                float value_debit = Convert.ToSingle(dataGridView1.Rows[i].Cells[4].Value);

                if (value_credit != 0)
                    sum_credit += value_credit;
                if (value_debit != 0)
                    sum_debit += value_debit;
            }
            if (sum_credit == 0)
            {

            }
            if (sum_debit == 0)
            {

            }

            dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[3].Value = sum_credit.ToString();
            dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[4].Value = sum_debit.ToString();
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
            saveFileDialoge.FileName = "ReportView_Surmail";
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
