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
    public partial class Updtdonr2 : Form
    {
        
        public Updtdonr2()
        {
            InitializeComponent();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            try
            {

                int donorId = int.Parse(textBox1.Text.ToString());
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
                s.DonorId = int.Parse(textBox1.Text.ToString());
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
                    
                    MessageBox.Show("Update successsfully.");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label11_Click(object sender, EventArgs e)
        {

        }

        private void Label10_Click(object sender, EventArgs e)
        {

        }

        private void Label9_Click(object sender, EventArgs e)
        {

        }

        private void Label8_Click(object sender, EventArgs e)
        {

        }

        private void Label7_Click(object sender, EventArgs e)
        {

        }

        private void Label6_Click(object sender, EventArgs e)
        {

        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void TextBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
