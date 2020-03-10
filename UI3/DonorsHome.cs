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
    public partial class DonorsHome : Form
    {
        Deletedonr2 dd = null;
        Adddonor ad = null;
        Updtdonr2 ud = null;
        Addadrs ar = null;
        Deleteadrs dr = null;
        Updateadrs ur = null;
        Addblodbnk kk = null;
        Updatebloodbnk ka = null;
        Deleteblodbnk kc = null;
        Adddnt kd = null;
        Updatednt ke = null;
        Deletednt kg = null;
        Addmdclcond kf = null;
        Updatemdccondt km = null;
        Deletemdclcond kn = null;
        Addmdct ko = null;
        Updatemdct kp = null;
        Deletemdct kz = null;
            
            



        public DonorsHome()
        {
            
            InitializeComponent();
            
        }

        private void LISTToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (dd == null)
            {
                dd = new Deletedonr2();
                dd.Show();
            }

        }

        private void LISTToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                BindGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void BindGridView()
        {
            try
            {
                Donors s = new Donors();
                dgvDonors.DataSource = s.ListDonors();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }




        private void DONORSToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void DonorsHome_Load(object sender, EventArgs e)
        {

        }

        private void TextBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void MEDICALCONDITIONSToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                int donorId = int.Parse(tb1.Text.ToString());
                int nationalmedNumber = int.Parse(tb2.Text.ToString());
                int telephoneNumber = int.Parse(tb3.Text.ToString());
                string bloodType= tb4.Text;
                int adressId= int.Parse(tb5.Text.ToString());
                int bloodBankId= int.Parse(tb6.Text.ToString());
                string gender= tb7.Text;
                string birthDate= tb8.Text;
                string name= tb9.Text;
                string email= tb10.Text;
                string password= tb11.Text;


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

                Donors d = new Donors();


                d.DonorId = donorId;
                d.NationalmedNumber = nationalmedNumber;
                d.TelephoneNumber = telephoneNumber;
                d.BloodType = bloodType;
                d.AdressId = adressId;

                d.BloodBankId = bloodBankId;
                d.Gender = gender;
                d.BirthDate = birthDate;
                d.Name = name;
                d.Email = email;
                d.Password = password;





                int result = d.AddDonor(d);
                if (result > 0)
                {
                    lblMessg.Text = "Student Added";
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
                    tb11.Text = "";
                 

                }
                else
                {
                    lblMessg.Text = "Student Not Added";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void uPDATEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ud == null)
            {
                ud = new Updtdonr2();
                ud.Show();
            }


        }

        private void aDDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ad == null)
            {
                ad = new Adddonor();
                ad.Show();
            }

        }

        private void DgvDonors_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDonors.SelectedRows.Count > 0)
            {
                int id = int.Parse(dgvDonors.SelectedRows[0].Cells[0].Value.ToString());
                Updatedonor se = new Updatedonor(id, this);
                se.ShowDialog();
            }




        }

        private void LISTToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            try
            {
                Addresses m = new Addresses();
                dgvDonors.DataSource = m.ListAddresses();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void ADDToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (ar == null)
            {
                ar = new Addadrs();
                ar.Show();
            }
        }

        private void DELETEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dr == null)
            {
                dr = new Deleteadrs();
                dr.Show();
            }
        }

        private void LISTToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            try
            {
                Bloodbanks n = new Bloodbanks();
                dgvDonors.DataSource = n.ListBloodbanks();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LISTToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            try
            {
                Donations p = new Donations();
                dgvDonors.DataSource = p.ListDonations();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LISTToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            try
            {
                Medicalcondition z = new Medicalcondition();
                dgvDonors.DataSource = z.ListMedicalconditions();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LISTToolStripMenuItem6_Click(object sender, EventArgs e)
        {
            try
            {
                Medications r = new Medications();
                dgvDonors.DataSource = r.ListMedications();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void ADDToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (kk == null)
            {
                kk = new Addblodbnk();
                kk.Show();
            }
        }

        private void UPDATEToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (ur == null)
            {
                ur = new Updateadrs();
                ur.Show();
            }
        }

        private void UPDATEToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (ka == null)
            {
                ka = new Updatebloodbnk();
                ka.Show();
            }
        }

        private void DELETEToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (kc == null)
            {
                kc = new Deleteblodbnk();
                kc.Show();
            }
        }

        private void ADDToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            if (kd == null)
            {
                kd = new Adddnt();
                kd.Show();
            }
        }

        private void UPDATEToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            if (ke == null)
            {
                ke = new Updatednt();
                ke.Show();
            }
        }

        private void DELETEToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (kg == null)
            {
                kg = new Deletednt();
                kg.Show();
            }
        }

        private void ADDToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            if (kf == null)
            {
                kf = new Addmdclcond();
                kf.Show();
            }
        }

        private void UPDATEToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            if (km == null)
            {
                km = new Updatemdccondt();
                km.Show();
            }
        }

        private void DELETEToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            if (kn == null)
            {
                kn = new Deletemdclcond();
                kn.Show();
            }
        }

        private void ADDToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            if (ko == null)
            {
                ko = new Addmdct();
                ko.Show();
            }
        }

        private void UPDATEToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            if (kp == null)
            {
                kp = new Updatemdct();
                kp.Show();
            }
        }

        private void DELETEToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            if (kz == null)
            {
                kz = new Deletemdct();
                kz.Show();
            }
        }

        private void MEDİCATIONSToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }
    }
}
