using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace ExcitingVirtualPetCore
{
    class Eating : IPetState
    {
        Pet pet;

        public Eating(Pet pet)
        {
            this.pet = pet;
        }

        public void TryToDrink()
        {

        }

        public void TryToEat()
        {

            pet.decrementFood();
            pet.decrementHunger();


            if (pet.getHunger() == pet.GET_MIN_HUNGER() || pet.getFood() == pet.GET_MIN_FOOD())
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
