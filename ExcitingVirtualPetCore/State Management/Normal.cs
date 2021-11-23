using System;
using System.Collections.Generic;
using System.Text;

namespace ExcitingVirtualPetCore
{
    class Normal : IPetState
    {
        Pet pet;

        public Normal(Pet pet)
        {
            this.pet = pet;
        }
        public void Play()
        {
            //these conditionals are the thresholds   
            if (pet.getBoredom() > pet.GET_MIN_BOREDOM())
            {
                pet.decrementBoredom();
            }

        }

        public void TryToDrink()
        {
            if (pet.getWater() > pet.GET_MIN_WATER())
            {
                pet.State = new Drinking(this.pet);
            }

        }

        public void TryToEat()
        {
            if (pet.getFood() > pet.GET_MIN_FOOD())
            {
                pet.State = new Eating(this.pet);
            }

        }

        public void TryToSleep()
        {
            if (pet.GetSleepiness() < pet.GET_MAX_SLEEPINESS())
            {
                pet.State = new Sleeping(this.pet);
            }
    
        }
    }
}
