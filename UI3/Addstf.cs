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
    public partial class Addstf : Form
    {
        public Addstf()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                int staffId = int.Parse(tb1.Text.ToString());
                string staffCategory = tb2.Text;
                int workPhonenumber = int.Parse(tb3.Text.ToString());

                int adressId = int.Parse(tb4.Text.ToString());
                int bloodBankId = int.Parse(tb5.Text.ToString());
                string gender = tb6.Text;
                string birthDate = tb7.Text;
                string name = tb8.Text;
                string email = tb9.Text;
                string password = tb10.Text;


               

                Staff d = new Staff();


                d.StaffId = staffId;
                d.StaffCategory = staffCategory;
                d.WorkPhonenumber = workPhonenumber;
                d.AdressId = adressId;

                d.BloodBankId = bloodBankId;
                d.Gender = gender;
                d.BirthDate = birthDate;
                d.Name = name;
                d.Email = email;
                d.Password = password;





                int result = d.AddStaff(d);
                if (result > 0)
                {
                    lblMessg.Text = "Staff Added";
                    tb1.Text = "";
                    tb2.Text = "";
                    tb3.Text = "";
                    tb4.Text = "";
                    tb5.Text = "";
                    tb6.Text = "";
                    tb7.Text = "";
                    tb8.Text = "";
                    tb9.Text = "";
                    tb10.Text = "";



                }
                else
                {
                    lblMessg.Text = "Staff Not Added";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
