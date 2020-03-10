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
    public partial class Deleteblodbnk : Form
    {
        public Deleteblodbnk()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
               int bloodbankId = int.Parse(textBox1.Text.ToString());


                Bloodbanks k = new Bloodbanks();







                int result = k.DeleteBloodbank(bloodbankId);
                if (result > 0)
                {
                    label2.Text = "Bloodbank deleted";



                }
                else
                {
                    label2.Text = "Bloodbank Not deleted";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
