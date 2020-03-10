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
    public partial class Addmdct : Form
    {
        public Addmdct()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                int donorId = int.Parse(tb1.Text.ToString());
                string medicationCode = tb2.Text;
                string medicationName = tb3.Text;
                string medicationDescription = tb4.Text;





                Medications d = new Medications();


                d.DonorId = donorId;
                d.MedicationCode = medicationCode;
                d.MedicationName = medicationName;
                d.MedicationDescription = medicationDescription;
                


















                int result = d.AddMedication(d);
                if (result > 0)
                {
                    lblMessg.Text = "Medication Added";
                    tb1.Text = "";
                    tb2.Text = "";
                    tb3.Text = "";
                    tb4.Text = "";



                }
                else
                {
                    lblMessg.Text = "Medication Not Added";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
