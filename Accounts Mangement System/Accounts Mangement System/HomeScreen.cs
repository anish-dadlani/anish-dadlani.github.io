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
    public partial class HomeScreen : Sample
    {
        public HomeScreen()
        {
            InitializeComponent();
        }

        private void usersBtn_Click(object sender, EventArgs e)
        {
            Users u = new Users();
            MainClass.show_window(u, this, Form1.ActiveForm);
        }

        private void HomeScreen_Load(object sender, EventArgs e)
        {
            userLabel.Text = reterival.EMP_NAME;
            this.KeyPreview = true;
        }

        private void HomeScreen_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control == true && e.KeyCode == Keys.U)
            {
                Users u = new Users();
                MainClass.show_window(u, this, Form1.ActiveForm);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Users u = new Users();
            MainClass.show_window(u, this, Form1.ActiveForm);
        }

        private void incomeBtn_Click(object sender, EventArgs e)
        {
            Projects p = new Projects();
            MainClass.show_window(p, this, Form1.ActiveForm);
        }

        private void expenditureBtn_Click(object sender, EventArgs e)
        {
            Plots p = new Plots();
            MainClass.show_window(p, this, Form1.ActiveForm);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Installment_Plans ip = new Installment_Plans();
            MainClass.show_window(ip, this, Form1.ActiveForm);
        }

        private void clientsBtn_Click(object sender, EventArgs e)
        {
            client c = new client();
            MainClass.show_window(c, this, Form1.ActiveForm);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Sales s = new Sales();
            MainClass.show_window(s, this, Form1.ActiveForm);
        }
    }
}
