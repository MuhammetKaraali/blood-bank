using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace UI3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = tbEmail.Text;
            string password = tbPassword.Text;

            if(email=="")
            {
                lblMessage.Text = "Please enter email.";
                lblMessage.ForeColor = Color.Red;
                tbEmail.Focus();
                return;
            }

            if(password==string.Empty)
            {
                lblMessage.Text = "Please enter password";
                lblMessage.ForeColor = Color.Red;
                tbPassword.Focus();
                return;
            }

            lblMessage.Text = "";

            Donors k = new Donors();
            int result =  k.Login(email, password);
            Staff m = new Staff();
            int result2 = m.Login(email, password);

            if (result==1)
            {
                DonorsHome dhome = new DonorsHome();
                dhome.Show();
                this.Hide();
            }
             if(result2==2)
            {
                StaffHome shome = new StaffHome();
                shome.Show();
                this.Hide();

            }
            else
            {
                lblMessage.Text = "Invalid email or passwrod";
                lblMessage.ForeColor = Color.Red;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
