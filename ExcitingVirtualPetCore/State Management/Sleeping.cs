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

        public void TryToDrink()
        {
            //Debug.WriteLine("Cant't drink, I'm sleeping");
        }

        public void TryToEat()
        {
            //Debug.WriteLine("Can't eat, I'm sleeping.");
        }

        public void Play()
        {
            //Debug.WriteLine("Can't play, I'm sleeping.");
        }

        public void TryToSleep()
        {
            if (pet.GetSleepiness() < pet.GET_MAX_SLEEPINESS())
            {
                pet.incrementSleepiness();
            }
            else { pet.setSleepState(true);}
            pet.State = new Playing(this.pet);
        }
    }
}
