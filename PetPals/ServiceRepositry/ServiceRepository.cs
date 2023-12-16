using PetPals.Dao;
using PetPals.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetPals.ServiceRepositry
{
    internal class ServiceRepository : IServiceRepository
    {
        public void addPet()
        {
            try
            {
                Pet pets = new Pet();
                PetShelter ps = new PetShelter();
                Console.WriteLine("Enter name of the pet");
                string petName = Console.ReadLine();
                pets.Name = petName;
                Console.WriteLine("Enter the age of pet");
                int age = Convert.ToInt32(Console.ReadLine());
                pets.Age = age;
                Console.WriteLine("Enter breed of pet");
                string breed = Console.ReadLine();
                pets.Breed = breed;
                Console.WriteLine("Enter type of pet (Cat or Dog)");
                string typeOfPet = Console.ReadLine();
                pets.Type = typeOfPet;
                Console.WriteLine("Enter 1 if available for adoption else 0");
                int availableForAdoption = Convert.ToInt32(Console.ReadLine());
                pets.AvailableForAdoption = availableForAdoption;
                ps.AddPet(pets);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void displayList()
        {
            try
            {
                List<Pet> pet = new List<Pet>();
                PetShelter petShelter = new PetShelter();
                pet = petShelter.ListAvailablePets();
                foreach (var pe in pet)
                {
                    Console.WriteLine(pe);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void recordDonation()
        {
            try
            {
                ItemDonation donation = new ItemDonation();
                CashDonation cashDonation = new CashDonation();
                Console.WriteLine("Enter Donor Name:");
                string name = Console.ReadLine();
                donation.DonorName = name;
                Console.WriteLine("Enter donation type 'cash' or 'item' Donation:");
                string type = Console.ReadLine();
                donation.DonationType = type;
                if (type == "cash")
                {
                    Console.WriteLine("Enter amount");
                    decimal amount = Convert.ToDecimal(Console.ReadLine());
                    donation.DonationAmount = amount;
                    cashDonation.RecordDonation(donation);
                }
                else
                {
                    Console.WriteLine("Enter Donation Item");
                    string item = Console.ReadLine();
                    donation.DonationItem = item;
                    donation.RecordDonation(donation);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void registerForAdoptionEvent()
        {
            try
            {
                AdoptionEvent events = new AdoptionEvent();
                Participants participant = new Participants();
                Console.WriteLine("Enter your name:");
                string participantName = Console.ReadLine();
                participant.ParticipantName = participantName;
                Console.WriteLine("Participant Type (Adopter or Shelter):");
                string participantType = Console.ReadLine();
                participant.ParticipantType = participantType;
                Console.WriteLine("Enter event id");
                int eventId = Convert.ToInt32(Console.ReadLine());
                participant.EventID = eventId;
                events.RegisterParticipant(participant);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void removePet()
        {
            try
            {
                Pet p = new Pet();
                PetShelter pshelter = new PetShelter();
                Console.WriteLine("Enter petId to remove pet:");
                int petId = Convert.ToInt32(Console.ReadLine());
                p.PetId = petId;
                pshelter.RemovePet(p);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
