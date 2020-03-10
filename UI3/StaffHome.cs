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
    public partial class StaffHome : Form
    {

        Addstf zb = null;
        Deletestf zc = null;
        Updatestf ze = null;
        Addadrs sd = null;
        Updateadrs se = null;
        Deleteadrs sf = null;
        Addblodbnk sg = null;
        Updatebloodbnk sm = null;
        Deleteblodbnk sn = null;









        public StaffHome()
        {
            InitializeComponent();
        }

        private void DgvDonors_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void StaffHome_Load(object sender, EventArgs e)
        {

        }

        private void LISTToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                Staff m = new Staff();
                dgvStaff.DataSource = m.ListStaffs();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                int staffId = int.Parse(tb1.Text.ToString());
                string staffCategory = tb2.Text;
                int workPhonenumber = int.Parse(tb3.Text.ToString());
                
                int adressId = int.Parse(tb4.Text.ToString());
                int bloodBankId = int.Parse(tb5.Text.ToString());
                string gender = tb6.Text;
                string birthDate = tb7.Text;
                string name = tb8.Text;
                string email = tb9.Text;
                string password = tb10.Text;


                if (name == string.Empty)
                {
                    MessageBox.Show("Please enter your name");
                    return;
                }

                if (email == string.Empty)
                {
                    MessageBox.Show("Please enter your email");
                    return;
                }

                if (password == string.Empty)
                {
                    MessageBox.Show("Please enter your password");
                    return;
                }

                Staff d = new Staff();


                d.StaffId = staffId;
                d.StaffCategory = staffCategory;
                d.WorkPhonenumber = workPhonenumber;
                d.AdressId = adressId;

                d.BloodBankId = bloodBankId;
                d.Gender = gender;
                d.BirthDate = birthDate;
                d.Name = name;
                d.Email = email;
                d.Password = password;





                int result = d.AddStaff(d);
                if (result > 0)
                {
                    lblMessg.Text = "Staff Added";
                    tb1.Text = "";
                    tb2.Text = "";
                    tb3.Text = "";
                    tb4.Text = "";
                    tb5.Text = "";
                    tb6.Text = "";
                    tb7.Text = "";
                    tb8.Text = "";
                    tb9.Text = "";
                    tb10.Text = "";
                    


                }
                else
                {
                    lblMessg.Text = "Staff Not Added";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ADDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (zb == null)
            {
                zb = new Addstf();
                zb.Show();
            }
        }

        private void LISTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (zc == null)
            {
                zc = new Deletestf();
                zc.Show();
            }
        }

        private void UPDATEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ze == null)
            {
                ze = new Updatestf();
                ze.Show();
            }
        }

        private void ADDToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (sd == null)
            {
                sd = new Addadrs();
                sd.Show();
            }
        }

        private void UPDATEToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (se == null)
            {
                se = new Updateadrs();
                se.Show();
            }
        }

        private void DELETEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (sf == null)
            {
                sf = new Deleteadrs();
                sf.Show();
            }
        }

        private void ADDToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (sg == null)
            {
                sg = new Addblodbnk();
                sg.Show();
            }
        }

        private void UPDATEToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (sm == null)
            {
                sm = new Updatebloodbnk();
                sm.Show();
            }
        }

        private void DELETEToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (sn == null)
            {
                sn = new Deleteblodbnk();
                sn.Show();
            }
        }

        private void LISTToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            try
            {
                Addresses p = new Addresses();
                dgvStaff.DataSource = p.ListAddresses();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void LISTToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            try
            {
                Bloodbanks n = new Bloodbanks();
                dgvStaff.DataSource = n.ListBloodbanks();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
