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
            //Debug.WriteLine("Can't drink, I'm currently eating");


        }

        public void TryToEat()
        {

            if (pet.getFood() > pet.GET_MIN_FOOD())
            {
                pet.decrementFood();

                pet.decrementHunger();


            }

            if (pet.getHunger() == pet.GET_MIN_HUNGER() || pet.getFood() == pet.GET_MIN_FOOD())
            {
                pet.State = new Normal(this.pet);
            }


        }

        public void Play()
        {
            //Debug.WriteLine("Can't play, I'm eating right now.");
        }

        public void TryToSleep()
        {
            //Debug.WriteLine("Can't sleep, I'm eating.");

        }
    }
}
