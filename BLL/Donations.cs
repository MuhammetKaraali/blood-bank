using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;

namespace BLL
{
    public class Donations
    {
        int donationId;
        int donorId;
        int donationDate;
        int totalDonation;
        public Donations()
        {

        }

        public Donations(int donationId, int donorId, int donationDate, int totalDonation)
        {
            this.donationId = donationId;
            this.donorId = donorId;
            this.donationDate = donationDate;
            this.totalDonation = totalDonation;
        }

        public int DonationId { get => donationId; set => donationId = value; }
        public int DonorId { get => donorId; set => donorId = value; }
        public int DonationDate { get => donationDate; set => donationDate = value; }
        public int TotalDonation { get => totalDonation; set => totalDonation = value; }

        public DataTable ListDonations()
        {
            try
            {
                string query = "select * from donations2";
                DataAcess da = new DataAcess();
                return da.ExecuteQuery(query);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public int AddDonation(Donations s)
        {
            try
            {
                string query = string.Format("INSERT INTO donations2(DonationId,DonorId,DonationDate,TotalDonation) " +
                    "VALUES('{0}','{1}','{2}','{3}')", s.DonationId,s.DonorId,s.DonationDate,s.TotalDonation);
                DataAcess da = new DataAcess();
                return da.ExecuteNonQuery(query);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public int UpdateDonation(Donations s)
        {
            try
            {
                string query = string.Format("UPDATE donations2 set DonorId = '{0}',DonationDate = '{1}',TotalDonation = '{2}' " +
                    " WHERE DonationId = {3}",  s.DonorId, s.DonationDate, s.TotalDonation, s.DonationId);
                DataAcess da = new DataAcess();
                return da.ExecuteNonQuery(query);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        public int DeleteDonation(int DonationId)
        {
            try
            {
                string query = string.Format("DELETE FROM  donations2 " +
                    " WHERE DonationId = {0}", DonationId);
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
