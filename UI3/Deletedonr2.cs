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
    public partial class Deletedonr2 : Form
    {
        
       

        public Deletedonr2()
        {
            InitializeComponent();
        }

        private void Deletedonor_Load(object sender, EventArgs e)
        {





        }

        private void Button1_Click(object sender, EventArgs e)
        {

            try
            {
                int donorId = int.Parse(textBox1.Text.ToString());


                Donors k = new Donors();







                int result = k.DeleteDonor(donorId);
                if (result > 0)
                {
                    label2.Text = "Donor deleted";



                }
                else
                {
                    label2.Text = "Donor Not deleted";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
