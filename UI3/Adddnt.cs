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
    public partial class Adddnt : Form
    {
        public Adddnt()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                int donationId = int.Parse(tb1.Text.ToString());
                int donorId = int.Parse(tb2.Text.ToString());
                int donationDate = int.Parse(tb3.Text.ToString());
                int totalDonation = int.Parse(tb4.Text.ToString());





                Donations d = new Donations();


                d.DonationId = donationId;
                d.DonorId = donorId;
                d.DonationDate = donationDate;
                d.TotalDonation = totalDonation;


                














                int result = d.AddDonation(d);
                if (result > 0)
                {
                    lblMessg.Text = "Donation Added";
                    tb1.Text = "";
                    tb2.Text = "";
                    tb3.Text = "";
                    tb4.Text = "";



                }
                else
                {
                    lblMessg.Text = "Donation Not Added";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
