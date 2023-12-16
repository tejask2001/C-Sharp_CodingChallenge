// See https://aka.ms/new-console-template for more information
using PetPals.Dao;
using PetPals.Entity;
using System.Threading.Channels;


int choice = 0;
int i = 1;

do
{
    
    Console.WriteLine("Press 1 : Display List of Pets\n" +
        "Press 2 : Record Donation\n" +
        "Press 3 : Register for adoption event");

    choice=Convert.ToInt32(Console.ReadLine());
    switch (choice)
    {
        case 1:
            List<Pet> pet = new List<Pet>();
            PetShelter petShelter = new PetShelter();
            pet=petShelter.ListAvailablePets();
            foreach(var p in pet)
            {
                Console.WriteLine(p);
            }
            break;
        case 2:
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
            break;
        case 3:
            AdoptionEvent events = new AdoptionEvent();
            Participants participant=new Participants();
            Console.WriteLine("Enter your name:");
            string participantName= Console.ReadLine();
            participant.ParticipantName = participantName;
            Console.WriteLine("Participant Type (event or shelter):");
            string participantType= Console.ReadLine();
            participant.ParticipantType = participantType;
            Console.WriteLine("Enter event id");
            int eventId = Convert.ToInt32(Console.ReadLine());
            participant.ParticipantID=eventId;
            events.RegisterParticipant(participant);
            break;
        default:
            Console.WriteLine("Invalid input received");
            break;
    }
    Console.WriteLine("Press 0 to exit or any key to continue");
    i = Convert.ToInt32(Console.ReadLine());
} while (i != 0);
