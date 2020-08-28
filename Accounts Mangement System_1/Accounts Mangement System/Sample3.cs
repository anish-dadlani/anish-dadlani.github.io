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
    public partial class Sample3 : Sample
    {
        public Sample3()
        {
            InitializeComponent();
        }

        public virtual void backBtn_Click(object sender, EventArgs e)
        {
            HomeScreen obj = new HomeScreen();
            MainClass.show_window(obj, this, Form1.ActiveForm);
        }

        public virtual void searchTxt_TextChanged(object sender, EventArgs e)
        {

        }

        public virtual void searchboxTXT_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
