using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetPals.Entity
{
    internal class Pet
    {
        int petId;
        string name;
        int age;
        string breed;
        string type;
        int availableForAdoption;

        public Pet()
        {
        }

        public Pet(int petId,string name, int age, string breed, string type, int availableForAdoption)
        {
            this.petId = petId;
            this.name = name;
            this.age = age;
            this.breed = breed;
            this.type = type;
            this.availableForAdoption = availableForAdoption;
        }

        public int PetId
        {
            get { return petId; }
            set { petId = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        public string Breed
        {
            get { return breed; }
            set { breed = value; }
        }
        public string Type
        {
            get { return type; }
            set { type = value; }
        }
        public int AvailableForAdoption
        {
            get { return availableForAdoption; }
            set { availableForAdoption = value; }
        }

        public override string ToString()
        {
            return $"Name : {Name}, Age : {Age}, Breed : {Breed}, Type : {Type}, AvailableForAdoption : {AvailableForAdoption}";
        }
    }
}
