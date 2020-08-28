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
    public partial class Projects : Sample2
    {
        int edit = 0; //this 0 is an indication for save operation and 1 is an indication for update operation
        Int64 projectID;
        reterival r = new reterival();
        updation u = new updation();

        public Projects()
        {
            InitializeComponent();
        }

        private void Projects_Load(object sender, EventArgs e)
        {
            MainClass.disable_reset(leftPanel);
            r.show_projects(dataGridView1, projectIDGV, ProjectNameGV, ProjectCityGV);
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

            if (cityTxt.Text == "")
                cityError.Visible = true;
            else
                cityError.Visible = false;

            if (nameError.Visible || cityError.Visible)
            {
                MainClass.show_msg("Fields with * are mandatory", "Stop", "Error"); //Error is the type of msg
            }
            else
            {
                if (edit == 0) // code for save operation
                {
                    insertion i = new insertion();
                    i.insertProjects(nameTxt.Text, cityTxt.Text);
                    r.show_projects(dataGridView1, projectIDGV, ProjectNameGV, ProjectCityGV);
                    MainClass.disable_reset(leftPanel);

                }
                else if (edit == 1) // code for update operation
                {
                    DialogResult dr = MessageBox.Show("Are you sure, you want to update record?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        u.updateProjects(projectID, nameTxt.Text, cityTxt.Text);
                        r.show_projects(dataGridView1, projectIDGV, ProjectNameGV, ProjectCityGV);
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
                    d.delete(projectID, "st_deleteUser", "@id");
                    r.show_projects(dataGridView1, projectIDGV, ProjectNameGV, ProjectCityGV);
                    MainClass.disable_reset(leftPanel);
                }
            }
        }

        public override void viewBtn_Click(object sender, EventArgs e)
        {
            r.show_projects(dataGridView1, projectIDGV, ProjectNameGV, ProjectCityGV);
        }

        public override void searchTxt_TextChanged(object sender, EventArgs e)
        {
            if (searchTxt.Text != "")
            {
                r.show_projects(dataGridView1, projectIDGV, ProjectNameGV, ProjectCityGV, searchTxt.Text);
            }
            else
            {
                r.show_projects(dataGridView1, projectIDGV, ProjectNameGV, ProjectCityGV);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                edit = 1;
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                projectID = Convert.ToInt64(row.Cells["projectIDGV"].Value.ToString());
                nameTxt.Text = row.Cells["ProjectNameGV"].Value.ToString();
                cityTxt.Text = row.Cells["ProjectCityGV"].Value.ToString();
                MainClass.disable(leftPanel);
            }
        }
    }
}
