using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;

namespace BLL
{
    public class Bloodbanks
    {
        int bloodbankId;
        int addressId;
        string name;
        int bankTelnumber;
        public Bloodbanks()
        {

        }

        public Bloodbanks(int bloodbankId, int addressId, string name, int bankTelnumber)
        {
            this.bloodbankId = bloodbankId;
            this.addressId = addressId;
            this.name = name;
            this.bankTelnumber = bankTelnumber;
        }

        public int BloodbankId { get => bloodbankId; set => bloodbankId = value; }
        public int AddressId { get => addressId; set => addressId = value; }
        public string Name { get => name; set => name = value; }
        public int BankTelnumber { get => bankTelnumber; set => bankTelnumber = value; }

        public DataTable ListBloodbanks()
        {
            try
            {
                string query = "select * from bloodbanks2";
                DataAcess da = new DataAcess();
                return da.ExecuteQuery(query);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public int AddBloodbank(Bloodbanks s)
        {
            try
            {
                string query = string.Format("INSERT INTO bloodbanks2(BloodbankId,AddressId,Name,BankTelnumber) " +
                    "VALUES('{0}','{1}','{2}','{3}')", s.BloodbankId,s.AddressId,s.Name,s.BankTelnumber);
                DataAcess da = new DataAcess();
                return da.ExecuteNonQuery(query);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public int UpdateBloodbank(Bloodbanks s)
        {
            try
            {
                string query = string.Format("UPDATE bloodbanks2 set AddressId = '{0}',Name = '{1}',BankTelnumber = '{2}' " +
                    " WHERE BloodbankId = {3}", s.AddressId,s.Name,s.BankTelnumber,s.BloodbankId);
                DataAcess da = new DataAcess();
                return da.ExecuteNonQuery(query);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        public int DeleteBloodbank(int BloodbankId)
        {
            try
            {
                string query = string.Format("DELETE FROM  bloodbanks2 " +
                    " WHERE BloodbankId = {0}", BloodbankId);
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
