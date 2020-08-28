using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Accounts_Mangement_System
{
    public partial class Sales : Sample2
    {
        string[] plotARR = new string[9];
        Int64 plotID;
        insertion i = new insertion();
        updation u = new updation();
        reterival r = new reterival();

        public Sales()
        {
            InitializeComponent();
        }

        private void Sales_Load(object sender, EventArgs e)
        {
            userLabel.Text = reterival.EMP_NAME;
            r.getList("st_getClientList", clientDD, "Client Name", "Client ID");
        }

        bool plotCheck;
        private void plotTxt_Validating(object sender, CancelEventArgs e)
        {
            if (plotTxt.Text != "")
            {
                amountPayTxt.Text = "";
                paidTxt.Text = "";
                nameTxt.Text = "";
                addressTxt.Text = "";
                phTxt.Text = "";
                plotARR = r.show_plotsWRTNO(Convert.ToInt32(plotTxt.Text));

                if (plotARR[0] == null)
                {
                    MessageBox.Show("Plot Not Available.");
                    plotTxt.Text = "";
                    plotTxt.Focus();
                }
                else if (plotARR[6] == "0")
                {
                    MessageBox.Show("Plot: Per Marla Size not Set.");
                    plotTxt.Text = "";
                    plotTxt.Focus();
                }
                else
                {
                    if (dataGridView1.RowCount == 0)
                    {
                        dataGridView1.Rows.Add(plotARR[0], plotARR[1], plotARR[2], plotARR[3], plotARR[4], plotARR[5], plotARR[6], plotARR[7]);
                        plotTxt.Text = "";
                        plotTxt.Focus();
                    }
                    else
                    {
                        foreach (DataGridViewRow row in dataGridView1.Rows)
                        {
                            if (row.Cells["plotIDGV"].Value.ToString() == plotARR[0])
                            {
                                plotCheck = true;
                                break;
                            }
                            else
                                plotCheck = false;
                        }
                        if (plotCheck == true)
                            MessageBox.Show("Plot already added.");
                        else
                        {
                            dataGridView1.Rows.Add(plotARR[0], plotARR[1], plotARR[2], plotARR[3], plotARR[4], plotARR[5], plotARR[6], plotARR[7]);
                            plotTxt.Text = "";
                            plotTxt.Focus();
                        }
                    }
                }
                if (dataGridView1.Rows.Count > 0)
                {
                    float gross = 0;
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        gross = gross + (Convert.ToSingle(row.Cells["TotalPrizeGV"].Value.ToString()) * 25 / 100);
                    }
                    amountPayTxt.Text = Math.Ceiling(gross).ToString();
                }
            }
        }

        private void payBtn_Click(object sender, EventArgs e)
        {
            if (clientDD.SelectedIndex == 0 || clientDD.SelectedIndex == -1)
            {
                if (nameTxt.Text != "")
                    nameError.Visible = false;
                else
                    nameError.Visible = true;

                if (addressTxt.Text != "")
                    addressError.Visible = false;
                else
                    addressError.Visible = true;

                if (phTxt.Text != "")
                    numError.Visible = false;
                else
                    numError.Visible = true;
            }

            if (paidTxt.Text != "")
                paidError.Visible = false;
            else
                paidError.Visible = true;

            if (nameError.Visible || addressError.Visible || numError.Visible || paidError.Visible)
            {
                MainClass.show_msg("Fields with * are mandatory", "Stop", "Error"); //Error is the type of msg
            }
            else
            {
                if (nameTxt.Text != "" && addressTxt.Text != "" && phTxt.Text != "")
                {
                    i.insertClients(nameTxt.Text, addressTxt.Text, phTxt.Text);
                    Int64 clientID = Convert.ToInt64(r.getclientID());

                    i.insertSales(Convert.ToSingle(amountPayTxt.Text), Convert.ToSingle(paidTxt.Text), DateTime.Now, clientID, plotID);
                    Int64 saleID = Convert.ToInt64(r.getsaleID());

                    i.insertSalesDetails(1, DateTime.Now, saleID, clientID);
                }
                else
                {
                    Int64 clientID = Convert.ToInt64(clientDD.SelectedValue.ToString());
                    i.insertSales(Convert.ToSingle(amountPayTxt.Text), Convert.ToSingle(paidTxt.Text), DateTime.Now, clientID, plotID);
                    Int64 saleID = Convert.ToInt64(r.getsaleID());
                    i.insertSalesDetails(1, DateTime.Now, saleID, clientID);
                }
            }
            amountPayTxt.Text = "";
            paidTxt.Text = "";
            nameTxt.Text = "";
            addressTxt.Text = "";
            phTxt.Text = "";
            plotTxt.Text = "";
            plotTxt.Focus();
        }

        private void clientDD_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (clientDD.SelectedIndex != 0 || clientDD.SelectedIndex != -1)
            {
                nameTxt.Enabled = false;
                addressTxt.Enabled = false;
                phTxt.Enabled = false;
            }
            else
            {
                nameTxt.Enabled = true;
                addressTxt.Enabled = true;
                phTxt.Enabled = true;
            }
        }

        private void paidTxt_Validating(object sender, CancelEventArgs e)
        {
            if (amountPayTxt.Text != "" && paidTxt.Text != "")
            {
                if (Convert.ToSingle(paidTxt.Text) < Convert.ToSingle(amountPayTxt.Text))
                {
                    MessageBox.Show("Paid amount is invalid. Please Enter Again.");
                    paidTxt.Text = "";
                    paidTxt.Focus();
                }
            }
        }
    }
}
