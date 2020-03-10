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
    public partial class Deletednt : Form
    {
        public Deletednt()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                int donationId = int.Parse(textBox1.Text.ToString());


                Donations k = new Donations();







                int result = k.DeleteDonation(donationId);
                if (result > 0)
                {
                    label2.Text = "Donation deleted";



                }
                else
                {
                    label2.Text = "Donation Not deleted";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
