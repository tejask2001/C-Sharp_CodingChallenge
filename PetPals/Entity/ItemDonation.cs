using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetPals.Entity
{
    internal class ItemDonation:Donation
    {
        string itemtype;

        public string connectionString;
        SqlCommand cmd = null;
        
        public ItemDonation()
        {
            connectionString = "Server=TEJAS;Database=PetPals;Trusted_Connection=True";
            cmd = new SqlCommand();
        }

        public ItemDonation(int donationID, string donorName, string donationType, decimal donationAmount,
            string donationItem, DateTime donationDate)
            : base(donationID, donorName, donationType, donationAmount, donationItem, donationDate)
        {
        }

        public override void RecordDonation(Donation donation)
        {
            using(SqlConnection sqlConnection=new SqlConnection(connectionString))
            {
                cmd.CommandText = "insert into Donations values(@donorName,@donationType,@donationAmount,@donationItem," +
                    " @donationDate)";
                cmd.Parameters.AddWithValue("@donorName",donation.DonorName);
                cmd.Parameters.AddWithValue("@donationType", donation.DonationType);
                cmd.Parameters.AddWithValue("@donationAmount", DBNull.Value);
                cmd.Parameters.AddWithValue("@donationItem", donation.DonationItem);
                string formattedDateTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff");
                cmd.Parameters.AddWithValue("@donationDate", formattedDateTime);
                cmd.Connection=sqlConnection;
                sqlConnection.Open();
                int rowsAffected=cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    Console.WriteLine("Donation recorded successfully.......");
                }
            }
        }
    }
}
