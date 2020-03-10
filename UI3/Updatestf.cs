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
    public partial class Updatestf : Form
    {
        public Updatestf()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                Staff k = new Staff();
                k.StaffId = int.Parse(tb1.Text.ToString());
                k.StaffCategory = tb2.Text.Trim();
                k.WorkPhonenumber = int.Parse(tb3.Text.ToString());
                
                k.AdressId = int.Parse(tb4.Text.ToString());
                k.BloodBankId = int.Parse(tb5.Text.ToString());
                k.Gender = tb6.Text.Trim();
                k.BirthDate = tb7.Text.Trim();
                k.Name = tb8.Text.Trim();
                k.Email = tb9.Text.Trim();
                k.Password = tb10.Text.Trim();









                int result = k.UpdateStaff(k);
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
