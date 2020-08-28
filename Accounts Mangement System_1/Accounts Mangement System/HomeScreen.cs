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

        private void clientsBtn_Click(object sender, EventArgs e)
        {
            Clients c = new Clients();
            MainClass.show_window(c, this, Form1.ActiveForm);
        }

        private void incomeBtn_Click(object sender, EventArgs e)
        {
            Income i = new Income();
            MainClass.show_window(i, this, Form1.ActiveForm);
        }

        private void expenditureBtn_Click(object sender, EventArgs e)
        {
            Expenditure exp = new Expenditure();
            MainClass.show_window(exp, this, Form1.ActiveForm);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ledger led = new Ledger();
            MainClass.show_window(led, this, Form1.ActiveForm);
        }

        private void HomeScreen_Load(object sender, EventArgs e)
        {
            userLabel.Text = reterival.EMP_NAME;
            this.KeyPreview = true;
        }

        private void clientBtn_Click(object sender, EventArgs e)
        {
            Clients_Accounts ca = new Clients_Accounts();
            MainClass.show_window(ca, this, Form1.ActiveForm);
        }

        private void HomeScreen_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control == true && e.KeyCode == Keys.U)
            {
                Users u = new Users();
                MainClass.show_window(u, this, Form1.ActiveForm);
            }
        }

        private void surmailBtn_Click(object sender, EventArgs e)
        {
            Surmail sur = new Surmail();
            MainClass.show_window(sur, this, Form1.ActiveForm);
        }
    }
}
