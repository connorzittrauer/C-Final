using System;
using System.Collections.Generic;
using System.Text;

namespace ExcitingVirtualPetCore
{
    class Factory : ISimpleFactory
    {
        List<IPet> PetFactory = new List<IPet>();
        IPet pet = null;

        public override IPet CreateAnimal()
        {
            pet = new Cat();
            PetFactory.Add(pet);
            return pet;
        }
    }
}
