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
    public partial class Plots : Sample2
    {
        int edit = 0; Int16 stat;
        Int64 plotID, projectID;
        insertion i = new insertion();
        reterival r = new reterival();
        updation u = new updation();

        public Plots()
        {
            InitializeComponent();
        }

        private void Plots_Load(object sender, EventArgs e)
        {
            MainClass.disable_reset(leftPanel);
            userLabel.Text = reterival.EMP_NAME;
            r.getList("st_projectList", projectDD, "Project Name", "Project ID");
            r.show_plots(dataGridView1, plotIDGV, projectIDGV, NameGV, cityGV, sizeGV, noGV, StatusGV);
        }

        public override void addBtn_Click(object sender, EventArgs e)
        {
            MainClass.enable_reset(leftPanel);
            edit = 0;
            projectTxt.Enabled = true;
            cityTxt.Enabled = true;
        }

        public override void editBtn_Click(object sender, EventArgs e)
        {
            edit = 1;
            MainClass.enable(leftPanel);
            projectTxt.Enabled = false;
            cityTxt.Enabled = false;
            projectDD.Enabled = false;
        }

        public override void savebtn_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(projectDD.SelectedValue) == 0)
            {
                if (projectTxt.Text == "")
                    projectError.Visible = true;
                else
                    projectError.Visible = false;

                if (cityTxt.Text == "")
                    cityError.Visible = true;
                else
                    cityError.Visible = false;
            }

            if (sizeTxt.Text == "")
                sizeError.Visible = true;
            else
                sizeError.Visible = false;

            if (noTxt.Text == "")
                noError.Visible = true;
            else
                noError.Visible = false;

            if (statusDD.SelectedIndex == -1)
                statusError.Visible = true;
            else
                statusError.Visible = false;

            if (projectError.Visible || cityError.Visible || sizeError.Visible || noError.Visible || statusError.Visible)
            {
                MainClass.show_msg("Fields with * are mandatory", "Stop", "Error"); //Error is the type of msg
            }
            else
            {
                if (edit == 0) // code for save operation
                {
                    if (statusDD.SelectedIndex == 0)
                        stat = 1;
                    else if (statusDD.SelectedIndex == 1)
                        stat = 0;

                    if (projectTxt.Text != "" && cityTxt.Text != "")
                    {
                        i.insertProjects(projectTxt.Text, cityTxt.Text);
                        Int64 project_ID = Convert.ToInt64(r.getProjectID());
                        i.insertPlots(sizeTxt.Text, Convert.ToInt32(noTxt.Text), project_ID, stat);
                        r.getList("st_projectList", projectDD, "Project Name", "Project ID");
                    }
                    else
                    {
                        i.insertPlots(sizeTxt.Text, Convert.ToInt32(noTxt.Text), Convert.ToInt64(projectDD.SelectedValue), stat);
                    }
                    Int64 plot_ID = Convert.ToInt64(r.getPlottID());
                    i.insertPlan(0, 0, 0, plot_ID);
                    r.show_plots(dataGridView1, plotIDGV, projectIDGV, NameGV, cityGV, sizeGV, noGV, StatusGV); MainClass.disable_reset(leftPanel);
                    MainClass.disable_reset(leftPanel);
                }
                else if (edit == 1) // code for update operation
                {
                    if (statusDD.SelectedIndex == 0)
                        stat = 1;
                    else if (statusDD.SelectedIndex == 1)
                        stat = 0;

                    DialogResult dr = MessageBox.Show("Are you sure, you want to update record?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        u.updatePlots(plotID, sizeTxt.Text, Convert.ToInt32(noTxt.Text), projectID, stat);
                        r.show_plots(dataGridView1, plotIDGV, projectIDGV, NameGV, cityGV, sizeGV, noGV, StatusGV);
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
                    d.delete(plotID, "st_deletePlots", "@id");
                    r.show_plots(dataGridView1, plotIDGV, projectIDGV, NameGV, cityGV, sizeGV, noGV, StatusGV);
                    MainClass.disable_reset(leftPanel);
                }
            }
        }

        public override void viewBtn_Click(object sender, EventArgs e)
        {
            r.show_plots(dataGridView1, plotIDGV, projectIDGV, NameGV, cityGV, sizeGV, noGV, StatusGV);
        }

        public override void searchTxt_TextChanged(object sender, EventArgs e)
        {
            if (searchTxt.Text != "")
            {
                r.show_plots(dataGridView1, plotIDGV, projectIDGV, NameGV, cityGV, sizeGV, noGV, StatusGV, searchTxt.Text);
            }
            else
            {
                r.show_plots(dataGridView1, plotIDGV, projectIDGV, NameGV, cityGV, sizeGV, noGV, StatusGV);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                edit = 1;
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                plotID = Convert.ToInt64(row.Cells["plotIDGV"].Value.ToString());
                projectID = Convert.ToInt64(row.Cells["projectIDGV"].Value.ToString());
                projectTxt.Text = row.Cells["NameGV"].Value.ToString();
                cityTxt.Text = row.Cells["cityGV"].Value.ToString();
                sizeTxt.Text = row.Cells["sizeGV"].Value.ToString();
                noTxt.Text = row.Cells["noGV"].Value.ToString();
                projectDD.SelectedValue = row.Cells["projectIDGV"].Value.ToString();
                statusDD.SelectedItem = row.Cells["StatusGV"].Value.ToString();
                MainClass.disable(leftPanel);
            }
        }

        private void projectDD_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (projectDD.SelectedIndex != 0 || projectDD.SelectedIndex != -1)
            {
                projectTxt.Enabled = false;
                cityTxt.Enabled = false;
            }
            //else
            //{
            //    projectTxt.Enabled = true;
            //    cityTxt.Enabled = true;
            //}
        }
    }
}
