﻿using System;
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
            if (pet.getBoredom() > 0)
            {
                pet.decrementBoredom();
            }

        }

        public void TryToDrink()
        {
            if (pet.getWater() > 0)
            {
                pet.State = new Drinking(this.pet);
            }

        }

        public void TryToEat()
        {
            if (pet.getFood() >0)
            {
                pet.State = new Eating(this.pet);
            }

        }

        public void TryToSleep()
        {
            if (pet.GetSleepiness() < 10)
            {
                pet.State = new Sleeping(this.pet);
            }
    
        }
    }
}
