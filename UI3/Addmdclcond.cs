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
    public partial class Addmdclcond : Form
    {
        public Addmdclcond()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                int donorId = int.Parse(tb1.Text.ToString());
                string conditionCode = tb2.Text;
                string conditionName = tb3.Text;
                string conditionDescription = tb4.Text;





                Medicalcondition d = new Medicalcondition();

                d.DonorId = donorId;
                d.ConditionCode = conditionCode;
                d.ConditionName = conditionName;
                d.ConditionDescription = conditionDescription;

                
















                int result = d.AddMedicalcondition(d);
                if (result > 0)
                {
                    lblMessg.Text = "Medicalcondition Added";
                    tb1.Text = "";
                    tb2.Text = "";
                    tb3.Text = "";
                    tb4.Text = "";



                }
                else
                {
                    lblMessg.Text = "Medicalcondition Not Added";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
