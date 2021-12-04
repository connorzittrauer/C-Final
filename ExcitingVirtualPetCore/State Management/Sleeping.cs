using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace ExcitingVirtualPetCore
{
    class Sleeping : IPetState
    {
        private Pet pet;

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
            pet.Sleepiness++;
            pet.State = new Normal(this.pet);

            if (pet.Sleepiness == 10)
            {
                pet.setSleepState(true);
            }

        }
    }
}