using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;

namespace BLL
{ 

    public class Addresses
    {
        int adressId;
        string city;
        int zippostcode;
        string country;
        string streetname;
        public Addresses()
        {

        }

        public Addresses(int adressId, string city, int zippostcode, string country, string streetname)
        {
            this.adressId = adressId;
            this.city = city;
            this.zippostcode = zippostcode;
            this.country = country;
            this.streetname = streetname;
        }

        public int AdressId { get => adressId; set => adressId = value; }
        public string City { get => city; set => city = value; }
        public int Zippostcode { get => zippostcode; set => zippostcode = value; }
        public string Country { get => country; set => country = value; }
        public string Streetname { get => streetname; set => streetname = value; }

        public DataTable ListAddresses()
        {
            try
            {
                string query = "select * from addresses2";
                DataAcess da = new DataAcess();
                return da.ExecuteQuery(query);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public int AddAddress(Addresses s)
        {
            try
            {
                string query = string.Format("INSERT INTO addresses2(AdressId,City,Zippostcode,Country,Streetname) " +
                    "VALUES('{0}','{1}','{2}','{3}','{4}')", s.AdressId, s.City, s.Zippostcode, s.Country, s.Streetname);
                DataAcess da = new DataAcess();
                return da.ExecuteNonQuery(query);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public int UpdateAddress(Addresses s)
        {
            try
            {
                string query = string.Format("UPDATE addresses2 set City = '{0}',Zippostcode = '{1}',Country = '{2}',Streetname = '{3}' " +
                    " WHERE AdressId = {4}", s.City, s.Zippostcode, s.Country, s.Streetname, s.AdressId);
                DataAcess da = new DataAcess();
                return da.ExecuteNonQuery(query);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        public int DeleteDonor(int AdressId)
        {
            try
            {
                string query = string.Format("DELETE FROM  addresses2 " +
                    " WHERE AdressId = {0}", AdressId);
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

