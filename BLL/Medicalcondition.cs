using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;

namespace BLL
{
    public class Medicalcondition
    {
        int donorId;
        string conditionCode;
        string conditionName;
        string conditionDescription;
        public Medicalcondition()
        {

        }

        public Medicalcondition(int donorId, string conditionCode, string conditionName, string conditionDescription)
        {
            this.donorId = donorId;
            this.conditionCode = conditionCode;
            this.conditionName = conditionName;
            this.conditionDescription = conditionDescription;
        }

        public int DonorId { get => donorId; set => donorId = value; }
        public string ConditionCode { get => conditionCode; set => conditionCode = value; }
        public string ConditionName { get => conditionName; set => conditionName = value; }
        public string ConditionDescription { get => conditionDescription; set => conditionDescription = value; }



        public DataTable ListMedicalconditions()
        {
            try
            {
                string query = "select * from medicalcondition2";
                DataAcess da = new DataAcess();
                return da.ExecuteQuery(query);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public int AddMedicalcondition(Medicalcondition s)
        {
            try
            {
                string query = string.Format("INSERT INTO medicalcondition2(DonorId,ConditionCode,ConditionName,ConditionDescription) " +
                    "VALUES('{0}','{1}','{2}','{3}')", s.DonorId,s.ConditionCode,s.ConditionName,s.ConditionDescription);
                DataAcess da = new DataAcess();
                return da.ExecuteNonQuery(query);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public int UpdateMedicalcondition(Medicalcondition s)
        {
            try
            {
                string query = string.Format("UPDATE medicalcondition2 set ConditionCode = '{0}',ConditionName = '{1}',ConditionDescription = '{2}' " +
                    " WHERE DonorId = {3}",  s.ConditionCode, s.ConditionName, s.ConditionDescription, s.DonorId);
                DataAcess da = new DataAcess();
                return da.ExecuteNonQuery(query);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        public int DeleteMedicalcondition(int DonorId)
        {
            try
            {
                string query = string.Format("DELETE FROM  medicalcondition2 " +
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

