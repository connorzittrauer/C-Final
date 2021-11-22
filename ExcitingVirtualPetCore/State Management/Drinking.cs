using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace ExcitingVirtualPetCore
{
    class Drinking : IPetState
    {
        Pet pet;

        //You’ll want to eventually pull the logic that defines drinking out of the Pet class entirely to put into TryToDrink.
        //The TryToDrink in pet references values in the Pet class itself, so you’ll need to expose those either with methods or properties. 

        public Drinking(Pet pet)
        {
            this.pet = pet;
        }

        public void TryToDrink()
        {
            if (pet.getWater() > pet.GET_MIN_WATER())
            {
                pet.decrementWater();
                pet.decrementThirst();
            }

            if (pet.getThirst() == pet.GET_MIN_THIRST() || pet.getWater() == pet.GET_MIN_WATER()) pet.setDrinking(false);

            Debug.WriteLine("Currently drinking");
            pet.State = new Eating(this.pet);

        }

        public void TryToEat()
        {
            //Debug.WriteLine("Can't eat, I'm drinking right now.");
        }

        public void Play()
        {
            //Debug.WriteLine("Can't play, I'm drinking right now.");
        }

        public void TryToSleep()
        {
            //Debug.WriteLine("Can't sleep, I'm drinking.");
        }
    }
}
