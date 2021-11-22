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
            if (pet.getWater() > pet.GET_MIN_WATER())
            {
                pet.decrementWater();
                pet.decrementThirst();
            }

            if (pet.getThirst() == pet.GET_MIN_THIRST() || pet.getWater() == pet.GET_MIN_WATER())
            {
                pet.State = new Normal(this.pet);
            }



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
