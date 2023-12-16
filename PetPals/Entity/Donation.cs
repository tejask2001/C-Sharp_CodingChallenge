using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetPals.Entity
{
    internal abstract class Donation
    {
        private int donationID;
        private string donorName;
        private string donationType;
        private decimal donationAmount;
        private string donationItem;
        private DateTime donationDate;

        public Donation() { }
        public Donation(int donationID, string donorName, string donationType, decimal donationAmount, 
            string donationItem, DateTime donationDate)
        {
            this.donationID = donationID;
            this.donorName = donorName;
            this.donationType = donationType;
            this.donationAmount = donationAmount;
            this.donationItem = donationItem;
            this.donationDate = donationDate;
        }
        public int DonationID
        {
            get { return donationID; }
            set { donationID = value; }
        }

        public string DonorName
        {
            get { return donorName; }
            set { donorName = value; }
        }

        public string DonationType
        {
            get { return donationType; }
            set { donationType = value; }
        }

        public decimal DonationAmount
        {
            get { return donationAmount; }
            set { donationAmount = value; }
        }

        public string DonationItem
        {
            get { return donationItem; }
            set { donationItem = value; }
        }

        public DateTime DonationDate
        {
            get { return donationDate; }
            set { donationDate = value; }
        }
        public override string ToString()
        {
            return $"DonationID: {DonationID}, DonorName: {DonorName}, DonationType: {DonationType}, " +
                   $"DonationAmount: {DonationAmount}, DonationItem: {DonationItem}, DonationDate: {DonationDate}";
        }

        public abstract void RecordDonation(Donation donation);
    }
}
