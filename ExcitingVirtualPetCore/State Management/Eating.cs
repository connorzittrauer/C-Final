using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace ExcitingVirtualPetCore
{
    class Eating : IPetState
    {
        private Pet pet;

        public Eating(Pet pet)
        {
            this.pet = pet;
        }

        public void TryToDrink()
        {

        }

        public void TryToEat()
        {
            pet.CurrentFood--;
            pet.Hunger--;

            if (pet.Hunger == 0 || pet.CurrentFood == 0)
            {
                pet.State = new Normal(this.pet);
            }

        }

        public void Play()
        {

        }

        public void TryToSleep()
        {

        }
    }
}