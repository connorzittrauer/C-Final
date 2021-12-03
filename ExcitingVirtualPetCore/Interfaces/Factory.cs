using System;
using System.Collections.Generic;
using System.Text;

namespace ExcitingVirtualPetCore
{
    class Factory : ISimpleFactory
    {
        private List<IPet> PetFactory = new List<IPet>();
        private IPet pet = null;

        public override IPet CreateAnimal(int value)
        {
            switch (value)
            {
                case 1:
                    pet = new Cat();
                    PetFactory.Add(pet);
                    break;
                case 2:
                    pet = new Dog();
                    PetFactory.Add(pet);
                    break;
                case 3:
                    pet = new Bird();
                    PetFactory.Add(pet);
                    break;
                default:
                    pet = new Cat();
                    PetFactory.Add(pet);
                    break;
                       
            }
            return pet;


        }
    }
}
