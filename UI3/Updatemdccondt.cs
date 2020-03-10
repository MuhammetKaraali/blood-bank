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
    public partial class Updatemdccondt : Form
    {
        public Updatemdccondt()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                Medicalcondition s = new Medicalcondition();
                s.DonorId = int.Parse(textBox1.Text.ToString());
                s.ConditionCode = textBox2.Text.Trim();
                s.ConditionName = textBox3.Text.Trim();
                s.ConditionDescription = textBox4.Text.Trim();












                int result = s.UpdateMedicalcondition(s);
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
