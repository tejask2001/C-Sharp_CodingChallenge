using PetPals.UserException;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetPals.Entity
{
    internal class CashDonation:Donation
    {
        DateTime donationDate;

        public string connectionString;
        SqlCommand cmd = null;

        public CashDonation()
        {
            connectionString = "Server=TEJAS;Database=PetPals;Trusted_Connection=True";
            cmd = new SqlCommand();
        }

        public CashDonation(int donationID, string donorName, string donationType, decimal donationAmount, 
            string donationItem, DateTime donationDate) 
            : base(donationID, donorName, donationType, donationAmount, donationItem, donationDate)
        {
        }

        public override void RecordDonation(Donation donation)
        {
            decimal amount = donation.DonationAmount;
            bool checkAmount=checkDonation(amount);
            if(checkAmount)
            {
                try
                {
                    using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                    {
                        cmd.CommandText = "insert into Donations values(@donorName,@donationType,@donationAmount,@donationItem," +
                            " @donationDate)";
                        cmd.Parameters.AddWithValue("@donorName", donation.DonorName);
                        cmd.Parameters.AddWithValue("@donationType", donation.DonationType);
                        cmd.Parameters.AddWithValue("@donationAmount", donation.DonationAmount);
                        cmd.Parameters.AddWithValue("@donationItem", DBNull.Value);
                        string formattedDateTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff");
                        cmd.Parameters.AddWithValue("@donationDate", formattedDateTime);
                        cmd.Connection = sqlConnection;
                        sqlConnection.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            Console.WriteLine("Donation recorded successfully.......");
                        }
                    }
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                
            }
            
        }

        public bool checkDonation(decimal amount)
        {
            if (amount < 10)
                throw new InsufficientFundException($"Please Enter fund above $10.");
            else
                return true;
        }
        
    }
}
