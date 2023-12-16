using PetPals.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetPals.Dao
{
    internal interface IAdoptable
    {
        public void Adopt();
        public void HostEvent(Event events);

        public void RegisterParticipant(Participants participants);
    }
}
