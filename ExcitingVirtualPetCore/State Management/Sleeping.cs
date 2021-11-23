using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace ExcitingVirtualPetCore
{
    class Sleeping : IPetState
    { 
        Pet pet;

        public Sleeping(Pet pet)
        {
            this.pet = pet;
        }
        public void Play()
        {
           
        }

        public void TryToDrink()
        {
           
        }

        public void TryToEat()
        {
            
        }

        public void TryToSleep()
        {
            pet.incrementSleepiness();
            pet.State = new Normal(this.pet);

            if (pet.GetSleepiness() == pet.GET_MAX_SLEEPINESS())
            {
                pet.setSleepState(true);
            }

        }
    }
}
