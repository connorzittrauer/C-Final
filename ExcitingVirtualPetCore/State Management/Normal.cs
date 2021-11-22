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
            pet.State = new Eating(this.pet);
            pet.State = new Sleeping(this.pet);
            pet.State = new Drinking(this.pet);

        }
        public void Play()
        {
            
            if (pet.getBoredom() > pet.GET_MIN_BOREDOM())
            {
                pet.decrementBoredom();
            }

        }

        public void TryToDrink()
        {
            
        }

        public void TryToEat()
        {

        }

        public void TryToSleep()
        {
         
        }
    }
}
