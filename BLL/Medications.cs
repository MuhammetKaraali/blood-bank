using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;

namespace BLL
{
    public class Medications
    {
        int donorId;
        string medicationCode;
        string medicationName;
        string medicationDescription;
        public Medications()
        {

        }

        public Medications(int donorId, string medicationCode, string medicationName, string medicationDescription)
        {
            this.donorId = donorId;
            this.medicationCode = medicationCode;
            this.medicationName = medicationName;
            this.medicationDescription = medicationDescription;
        }

        public int DonorId { get => donorId; set => donorId = value; }
        public string MedicationCode { get => medicationCode; set => medicationCode = value; }
        public string MedicationName { get => medicationName; set => medicationName = value; }
        public string MedicationDescription { get => medicationDescription; set => medicationDescription = value; }


        public DataTable ListMedications()
        {
            try
            {
                string query = "select * from medications2";
                DataAcess da = new DataAcess();
                return da.ExecuteQuery(query);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public int AddMedication(Medications s)
        {
            try
            {
                string query = string.Format("INSERT INTO medications2(DonorId,MedicationCode,MedicationName,MedicationDescription) " +
                    "VALUES('{0}','{1}','{2}','{3}')", s.DonorId,s.MedicationCode,s.MedicationName,s.MedicationDescription);
                DataAcess da = new DataAcess();
                return da.ExecuteNonQuery(query);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public int UpdateMedication(Medications s)
        {
            try
            {
                string query = string.Format("UPDATE medications2 set MedicationCode = '{0}',MedicationName = '{1}',MedicationDescription = '{2}' " +
                    " WHERE DonorId = {3}",  s.MedicationCode, s.MedicationName, s.MedicationDescription, s.DonorId);
                DataAcess da = new DataAcess();
                return da.ExecuteNonQuery(query);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        public int DeleteMedication(int DonorId)
        {
            try
            {
                string query = string.Format("DELETE FROM  medications2 " +
                    " WHERE DonorId = {0}", DonorId);
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
