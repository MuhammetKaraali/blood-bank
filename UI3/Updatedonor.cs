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
    public partial class Updatedonor : Form
    {
        int donorId;
        DonorsHome home = null;
        public Updatedonor(int id, DonorsHome h = null)
        {
            InitializeComponent();

            donorId = id;
            home = h;
        }

        private void Updatedonor_Load(object sender, EventArgs e)
        {
            try
            {
                Donors s = new Donors();
                s = s.SearchDonorByID(donorId);

                textBox1.Text = s.DonorId.ToString();
                textBox2.Text = s.NationalmedNumber.ToString();
                textBox3.Text = s.TelephoneNumber.ToString();
                textBox4.Text = s.BloodType;
                textBox5.Text = s.AdressId.ToString();
                textBox6.Text = s.BloodBankId.ToString();
                textBox7.Text = s.Gender;
                textBox8.Text = s.BirthDate;
                textBox9.Text = s.Name;
                textBox10.Text = s.Email;
                textBox11.Text = s.Password;



            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }







        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button1_Click(object sender, EventArgs e)
        {

            try
            {
                Donors s = new Donors();
                s.DonorId = donorId;
                s.NationalmedNumber = int.Parse(textBox2.Text.ToString());
                s.TelephoneNumber = int.Parse(textBox3.Text.ToString());
                s.BloodType = textBox4.Text.Trim();
                s.AdressId = int.Parse(textBox5.Text.ToString());
                s.BloodBankId = int.Parse(textBox6.Text.ToString());
                s.Gender = textBox7.Text.Trim();
                s.BirthDate = textBox8.Text.Trim();
                s.Name = textBox9.Text.Trim();
                s.Email = textBox10.Text.Trim();
                s.Password = textBox11.Text.Trim();









                int result = s.UpdateDonor(s);
                if (result > 0)
                {
                    if (home != null)
                    {
                        home.BindGridView();
                    }
                    MessageBox.Show("Update successsfully.");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
