// See https://aka.ms/new-console-template for more information
using PetPals.Dao;
using PetPals.Entity;
using PetPals.ServiceRepositry;
using System.Threading.Channels;


IServiceRepository repository = new ServiceRepository();
int choice = 0;
int i = 1;

do
{
    
    Console.WriteLine(".....Welcome to PetPals.....\n" +
        "\nPress 1 : Display List of Pets\n" +
        "Press 2 : Record Donation\n" +
        "Press 3 : Register for adoption event\n" +
        "Press 4 : Add Pet\n" +
        "Press 5 : Remove Pet\n" +
        "Press 0 : Exit\n");

    choice=Convert.ToInt32(Console.ReadLine());
    switch (choice)
    {
        case 1:
            repository.displayList();
            break;
        case 2:
            repository.recordDonation();
            break;
        case 3:
            repository.registerForAdoptionEvent();
            break;
        case 4:
            repository.addPet();
            break;
        case 5:
            repository.removePet();
            break;
        default:
            Console.WriteLine("Invalid input received");
            break;
    }
    Console.WriteLine("Press 0 to exit or any key to continue");
    i = Convert.ToInt32(Console.ReadLine());
} while (i != 0);
