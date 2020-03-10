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
    public partial class Updatemdct : Form
    {
        public Updatemdct()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                Medications s = new Medications();
                s.DonorId = int.Parse(textBox1.Text.ToString());
                s.MedicationCode = textBox2.Text.Trim();
                s.MedicationName = textBox3.Text.Trim();
                s.MedicationDescription = textBox4.Text.Trim();












                int result = s.UpdateMedication(s);
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
    }
}
