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
    public partial class Installment_Plans : Sample2
    {
        insertion i = new insertion();
        reterival r = new reterival();
        updation u = new updation();

        public Installment_Plans()
        {
            InitializeComponent();
            r.getList("st_projectList", projectDD, "Project Name", "Project ID");
        }

        private void Installment_Plans_Load(object sender, EventArgs e)
        {
            //base.addBtn.Enabled = false;
            //base.editBtn.Enabled = false;
            //base.viewBtn.Enabled = false;
            //base.delBtn.Enabled = false;
            dataGridView1.AutoGenerateColumns = false;
            userLabel.Text = reterival.EMP_NAME;
        }

        private void projectDD_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (projectDD.SelectedIndex != -1 && projectDD.SelectedIndex != 0)
            {
                r.show_plansWRTProjectID(Convert.ToInt64(projectDD.SelectedValue.ToString()), dataGridView1, IP_IDGV, plotIDGV, projectIDGV, nameGV, cityGV, sizeGV, PricePerMarlaGV, TotalPriceGV, noOfInstallmentGV);
            }
        }

        public override void savebtn_Click(object sender, EventArgs e)
        {
            int check = 0;
            if (projectDD.SelectedIndex != -1 && projectDD.SelectedIndex != 0)
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if ((bool)row.Cells["selectGV"].FormattedValue == true)
                    {
                        check++;
                        Int64 plotID = Convert.ToInt64(row.Cells["plotIDGV"].Value.ToString());
                        Int64 projectID = Convert.ToInt64(row.Cells["projectIDGV"].Value.ToString());
                        float ppm = Convert.ToSingle(row.Cells["PricePerMarlaGV"].Value.ToString());
                        float total_price = Convert.ToSingle(row.Cells["TotalPriceGV"].Value.ToString());
                        int installNo = Convert.ToInt32(row.Cells["noOfInstallmentGV"].Value.ToString());

                        u.updatePlans(ppm, total_price, installNo, plotID, projectID);
                    }
                }
                if (check > 0)
                {
                    MainClass.show_msg("Plot Plan updated successfully", "Success", "Success");
                    check = 0;
                }
                else
                {
                    MainClass.show_msg("Please select any plot", "Error", "Error");
                    check = 0;
                }
            }
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                string packing = row.Cells["sizeGV"].Value.ToString();
                object output = Regex.Replace(packing, "[^0-9]+", string.Empty);

                float ppm = Convert.ToSingle(row.Cells["PricePerMarlaGV"].Value.ToString());
                float total_price = Convert.ToSingle(output) * ppm;
                row.Cells["TotalPriceGV"].Value = total_price;
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }
    }
}
