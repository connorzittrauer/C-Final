using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace ExcitingVirtualPetCore
{
    class Playing : IPetState
    {
        Pet pet;

        public Playing(Pet pet)
        {
            this.pet = pet;
        }

        public void TryToDrink()
        {
            //Debug.WriteLine("Can't drink, I'm currently playing");
            
        }

        public void TryToEat()
        {
            //Debug.WriteLine("Can't eat, I'm playing");

        }

        public void Play()
        {
            if (pet.getBoredom() > pet.GET_MIN_BOREDOM())
            {
                pet.decrementBoredom();
            }

           // Debug.WriteLine("I'm playing right now");
            pet.State = new Drinking(this.pet);

        }

        public void TryToSleep()
        {
            //Debug.WriteLine("Can't sleep, I'm playing.");
        }
    }
}
