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
    public partial class Addadrs : Form
    {
        public Addadrs()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                int adressId= int.Parse(tb1.Text.ToString());
                string city = tb2.Text;
                int zippostcode = int.Parse(tb3.Text.ToString());
                string country = tb4.Text;
                string streetname = tb5.Text;



                
                Addresses d = new Addresses();

                d.AdressId = adressId;
                d.City = city;
                d.Zippostcode = zippostcode;
                d.Country = country;
                d.Streetname = streetname;




                

               




                int result = d.AddAddress(d);
                if (result > 0)
                {
                    lblMessg.Text = "Adresses Added";
                    tb1.Text = "";
                    tb2.Text = "";
                    tb3.Text = "";
                    tb4.Text = "";
                    tb5.Text = "";
                    

                }
                else
                {
                    lblMessg.Text = "Adresses Not Added";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
