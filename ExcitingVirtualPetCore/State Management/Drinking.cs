using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace ExcitingVirtualPetCore
{
    class Drinking : IPetState
    {
        Pet pet;


        public Drinking(Pet pet)
        {
            this.pet = pet;
        }

        public void TryToDrink()
        {
            pet.decrementWater();
            pet.decrementThirst();

            if (pet.getThirst() == pet.GET_MIN_THIRST() || pet.getWater() == pet.GET_MIN_WATER())
            {
                pet.State = new Normal(this.pet);
            }

        }

        public void TryToEat()
        {

        }

        public void Play()
        {

        }

        public void TryToSleep()
        {

        }
    }
}
