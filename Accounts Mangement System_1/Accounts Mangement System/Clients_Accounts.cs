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
    public partial class Clients_Accounts : Sample3
    {
        reterival r = new reterival();
        insertion i = new insertion();
        updation u = new updation();
        public Clients_Accounts()
        {
            InitializeComponent();
        }

        private void Clients_Accounts_Load(object sender, EventArgs e)
        {
            r.getList("st_getClientList", clientNameDD, "Client Name", "ID");
            userLabel.Text = reterival.EMP_NAME;
        }

        private void clientNameDD_SelectedIndexChanged(object sender, EventArgs e)
        {
            r.showClientAccount(dataGridView1, Convert.ToInt64(clientNameDD.SelectedValue), clientAccountIDGV, DescriptionGV, CreditAmountGV, DebitAmountGV, DateGV, BalanceAmountGV, null);
            userLabel.Text = Convert.ToString(clientNameDD.Text);
        }

        public override void searchboxTXT_TextChanged(object sender, EventArgs e)
        {
            if (searchboxTXT.Text != "")
                r.showClientAccountSearch(dataGridView1, clientAccountIDGV, DescriptionGV, CreditAmountGV, DebitAmountGV, DateGV, searchboxTXT.Text, BalanceAmountGV);
            else
                r.showClientAccount(dataGridView1, Convert.ToInt64(clientNameDD.SelectedValue), clientAccountIDGV, DescriptionGV, CreditAmountGV, DebitAmountGV, DateGV, BalanceAmountGV, null);
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
            saveFileDialoge.FileName = "ReportView_Client_Accounts";
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
