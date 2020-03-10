using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;

namespace BLL
{
    public class Staff:Person2
    {
        int staffId;
        string staffCategory;
        int workPhonenumber;
        public Staff()
        {

        }

        public Staff(int staffId,string staffCategory, int workPhonenumber, int adressId, int bloodBankId, string gender, string birthDate, string name, string email, string password)
            :base(adressId, bloodBankId, gender, birthDate, name, email, password)
        {
            this.staffId = staffId;
            this.staffCategory = staffCategory;
            this.workPhonenumber = workPhonenumber;
        }

        public string StaffCategory { get => staffCategory; set => staffCategory = value; }
        public int WorkPhonenumber { get => workPhonenumber; set => workPhonenumber = value; }
        public int StaffId { get => staffId; set => staffId = value; }

        public override int Login(string email, string password)
        {
            string query = string.Format("SELECT * FROM staff2 WHERE " +
                "EMAIL = '{0}' AND PASSWORD = '{1}'", email, password);

            DataAcess da = new DataAcess();
            DataTable dt = da.ExecuteQuery(query);

            if (dt.Rows.Count > 0)
            {
                return 2;
            }
            else
            {
                return 0;
            }
        }

        public DataTable ListStaffs()
        {
            try
            {
                string query = "select * from staff2";
                DataAcess da = new DataAcess();
                return da.ExecuteQuery(query);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public int AddStaff(Staff k)
        {
            try
            {
                string query = string.Format("INSERT INTO staff2(StaffID,StaffCategory,WorkPhonenumber,AdressID,BloodBankID,Gender,BirthDate,Name,Email,Password) " +
                    "VALUES('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}')", k.StaffId, k.StaffCategory, k.WorkPhonenumber, k.AdressId, k.BloodBankId, k.Gender, k.BirthDate, k.Name, k.Email, k.Password);
                DataAcess da = new DataAcess();
                return da.ExecuteNonQuery(query);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public int UpdateStaff(Staff k)
        {
            try
            {
                string query = string.Format("UPDATE staff2 set StaffCategory = '{0}',WorkPhonenumber = '{1}',AdressID = '{2}',BloodBankID = '{3}',Gender = '{4}',BirthDate = '{5}',Name = '{6}',Email = '{7}',Password = '{8}' " +
                    " WHERE StaffID = {9}", k.StaffCategory, k.WorkPhonenumber, k.AdressId, k.BloodBankId, k.Gender, k.BirthDate, k.Name, k.Email, k.Password, k.StaffId);
                DataAcess da = new DataAcess();
                return da.ExecuteNonQuery(query);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        public int DeleteStaff(int StaffId)
        {
            try
            {
                string query = string.Format("DELETE FROM  staff2 " +
                    " WHERE StaffID = {0}", StaffId);
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
