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
    public partial class Adddonor : Form
    {
        public Adddonor()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {

            try
            {
                int donorId = int.Parse(tb1.Text.ToString());
                int nationalmedNumber = int.Parse(tb2.Text.ToString());
                int telephoneNumber = int.Parse(tb3.Text.ToString());
                string bloodType = tb4.Text;
                int adressId = int.Parse(tb5.Text.ToString());
                int bloodBankId = int.Parse(tb6.Text.ToString());
                string gender = tb7.Text;
                string birthDate = tb8.Text;
                string name = tb9.Text;
                string email = tb10.Text;
                string password = tb11.Text;


                if (name == string.Empty)
                {
                    MessageBox.Show("Please enter your name");
                    return;
                }

                if (email == string.Empty)
                {
                    MessageBox.Show("Please enter your email");
                    return;
                }

                if (password == string.Empty)
                {
                    MessageBox.Show("Please enter your password");
                    return;
                }

                Donors d = new Donors();


                d.DonorId = donorId;
                d.NationalmedNumber = nationalmedNumber;
                d.TelephoneNumber = telephoneNumber;
                d.BloodType = bloodType;
                d.AdressId = adressId;

                d.BloodBankId = bloodBankId;
                d.Gender = gender;
                d.BirthDate = birthDate;
                d.Name = name;
                d.Email = email;
                d.Password = password;





                int result = d.AddDonor(d);
                if (result > 0)
                {
                    lblMessg.Text = "Student Added";
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
                    tb11.Text = "";


                }
                else
                {
                    lblMessg.Text = "Student Not Added";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
