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
    public partial class Deletestf : Form
    {
        public Deletestf()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                int staffId = int.Parse(textBox1.Text.ToString());


                Staff k = new Staff();







                int result = k.DeleteStaff(staffId);
                if (result > 0)
                {
                    label2.Text = "Staff deleted";



                }
                else
                {
                    label2.Text = "Staff Not deleted";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
