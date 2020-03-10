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
    public partial class Addblodbnk : Form
    {
        public Addblodbnk()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                int bloodbankId = int.Parse(tb1.Text.ToString());
                int addressId = int.Parse(tb2.Text.ToString());
                string name = tb3.Text;
                int bankTelnumber = int.Parse(tb4.Text.ToString());





                Bloodbanks d = new Bloodbanks();


                d.BloodbankId = bloodbankId;
                d.AddressId = addressId;
                d.Name = name;
                d.BankTelnumber = bankTelnumber;

                
                











                int result = d.AddBloodbank(d);
                if (result > 0)
                {
                    lblMessg.Text = "Bloodbank Added";
                    tb1.Text = "";
                    tb2.Text = "";
                    tb3.Text = "";
                    tb4.Text = "";
                   


                }
                else
                {
                    lblMessg.Text = "Blood bank Not Added";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
