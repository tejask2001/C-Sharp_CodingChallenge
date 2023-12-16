using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetPals.Entity
{
    internal class Dog:Pet
    {
        string dogBreed;

        public Dog(int petId,string name, int age, string breed,string dogBreed, string type, int availableForAdoption) 
            : base(petId,name, age, breed,type,availableForAdoption)
        {
            this.dogBreed = dogBreed;
        }

        public string DogBreed
        {
            get { return this.dogBreed;}
            set { this.dogBreed = value;}
        }

    }
}
