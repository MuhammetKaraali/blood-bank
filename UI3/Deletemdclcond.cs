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
    public partial class Deletemdclcond : Form
    {
        public Deletemdclcond()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                int donorId = int.Parse(textBox1.Text.ToString());


                Medicalcondition k = new Medicalcondition();







                int result = k.DeleteMedicalcondition(donorId);
                if (result > 0)
                {
                    label2.Text = "Medicalcondition deleted";



                }
                else
                {
                    label2.Text = "Medicalcondition Not deleted";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
