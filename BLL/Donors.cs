using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;

namespace BLL
{
    public class Donors:Person2
    {
        int donorId;
        int nationalmedNumber;
        int telephoneNumber;
        string bloodType;

        public Donors()
        {

        }

        public Donors(int donorId, int nationalmedNumber, int telephoneNumber,string bloodType,int adressId, int bloodBankId, string gender, string birthDate, string name, string email, string password)
            : base(adressId,bloodBankId,gender,birthDate,name,email,password)
        {
            this.bloodType = bloodType;
            this.donorId = donorId;
            this.nationalmedNumber = nationalmedNumber;
            this.telephoneNumber = telephoneNumber;
        }

        public int DonorId { get => donorId; set => donorId = value; }
        public int NationalmedNumber { get => nationalmedNumber; set => nationalmedNumber = value; }
        public int TelephoneNumber { get => telephoneNumber; set => telephoneNumber = value; }
        public string BloodType { get => bloodType; set => bloodType = value; }

        public override int Login(string email, string password)
        {
            string query = string.Format("SELECT * FROM donors2 WHERE " +
                "EMAIL = '{0}' AND PASSWORD = '{1}'", email, password);

            DataAcess da = new DataAcess();
            DataTable dt = da.ExecuteQuery(query);

            if (dt.Rows.Count > 0)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }




        public Donors SearchDonorByID(int DonorId)
        {
            try
            {
                Donors s = new Donors();
                string query = string.Format("select * from donors2 where DonorID = {0}", DonorId);
                DataAcess da = new DataAcess();
                DataTable dt = da.ExecuteQuery(query);
                if (dt.Rows.Count > 0)
                {
                    s.DonorId = int.Parse(dt.Rows[0]["DonorID"].ToString());
                    s.NationalmedNumber = int.Parse(dt.Rows[0]["NationalmedNumber"].ToString());
                    s.TelephoneNumber = int.Parse(dt.Rows[0]["TelephoneNumber"].ToString());
                    s.AdressId = int.Parse(dt.Rows[0]["AdressID"].ToString());
                    s.BloodBankId = int.Parse(dt.Rows[0]["BloodBankID"].ToString());
                    s.Gender = dt.Rows[0]["Gender"].ToString();
                    s.BirthDate = dt.Rows[0]["BirthDate"].ToString();
                    s.Name = dt.Rows[0]["Name"].ToString();
                    s.Email = dt.Rows[0]["Email"].ToString();
                    s.Password = dt.Rows[0]["Password"].ToString();
                    s.BloodType = dt.Rows[0]["BloodType"].ToString();
                }
                return s;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DataTable ListDonors()
        {
            try
            {
                string query = "select * from donors2";
                DataAcess da = new DataAcess();
                return da.ExecuteQuery(query);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public int AddDonor(Donors s)
        {
            try
            {
                string query = string.Format("INSERT INTO donors2(DonorID,NationalmedNumber,TelephoneNumber,AdressID,BloodBankID,Gender,BirthDate,Name,Email,Password,BloodType) " +
                    "VALUES('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}')", s.DonorId, s.NationalmedNumber, s.TelephoneNumber, s.AdressId, s.BloodBankId, s.Gender, s.BirthDate, s.Name, s.Email, s.Password, s.BloodType);
                DataAcess da = new DataAcess();
                return da.ExecuteNonQuery(query);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public int UpdateDonor(Donors s)
        {
            try
            {
                string query = string.Format("UPDATE donors2 set NationalmedNumber = '{0}',TelephoneNumber = '{1}',BloodType = '{2}',AdressID = '{3}',BloodBankID = '{4}',Gender = '{5}',BirthDate = '{6}',Name = '{7}',Email = '{8}',Password = '{9}' " +
                    " WHERE DonorID = {10}", s.NationalmedNumber, s.TelephoneNumber, s.BloodType, s.AdressId, s.BloodBankId, s.Gender, s.BirthDate, s.Name, s.Email, s.Password, s.DonorId);
                DataAcess da = new DataAcess();
                return da.ExecuteNonQuery(query);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        public int DeleteDonor(int DonorId)
        {
            try
            {
                string query = string.Format("DELETE FROM  donors2 " +
                    " WHERE DonorID = {0}", DonorId);
                DataAcess da = new DataAcess();
                return da.ExecuteNonQuery(query);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


    }



}
