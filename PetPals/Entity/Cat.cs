using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetPals.Entity
{
    internal class Cat:Pet
    {
        string catColor;

        public Cat(int petId, string name, int age, string breed, string type, int availableForAdoption,string catColor)
            : base(petId, name, age, breed, type, availableForAdoption)
        {
            this.catColor = catColor;
        }

        public string CatColor
        {
            get { return catColor; }
            set { catColor = value; }
        }

    }
}
