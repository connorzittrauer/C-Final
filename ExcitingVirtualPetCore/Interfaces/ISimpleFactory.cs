using System;
using System.Collections.Generic;
using System.Text;

namespace ExcitingVirtualPetCore
{
    abstract class ISimpleFactory
    {
        public abstract IPet CreateAnimal(int value);
        public abstract Pet LoadPet();
    }
}
