using System;
using System.Collections.Generic;
using System.Text;

namespace ExcitingVirtualPetCore.State_Management
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
            throw new NotImplementedException();
        }

        public void TryToDrink()
        {
            throw new NotImplementedException();
        }

        public void TryToEat()
        {
            throw new NotImplementedException();
        }

        public void TryToSleep()
        {
            throw new NotImplementedException();
        }
    }
}
