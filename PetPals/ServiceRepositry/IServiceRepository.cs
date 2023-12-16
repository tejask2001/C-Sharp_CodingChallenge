using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetPals.ServiceRepositry
{
    internal interface IServiceRepository
    {
        public void displayList();
        public void recordDonation();
        public void registerForAdoptionEvent();
        public void addPet();
        public void removePet();

    }
}
