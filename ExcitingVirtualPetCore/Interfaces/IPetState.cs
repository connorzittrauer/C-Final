using System;
using System.Collections.Generic;
using System.Text;

namespace ExcitingVirtualPetCore
{
    public interface IPetState
    {
        void TryToDrink();
        void TryToEat();
        void Play();
        void TryToSleep();

    }
}
