using System;
using System.Collections.Generic;
using System.Text;

namespace ExcitingVirtualPetCore
{
    class Factory : ISimpleFactory
    {
        List<IPet> PetFactory = new List<IPet>();
        IPet pet = null;

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

        public override Pet LoadPet()
        {
            Pet PetData = new Pet();
            PetData.Hunger = PetData.Hunger;
            PetData.Sleepiness = PetData.Sleepiness;
            PetData.CurrentFood = PetData.CurrentFood;
            PetData.CurrentWater = PetData.CurrentWater;
            PetData.Affection = PetData.Affection;
            PetData.Thirst = PetData.Thirst;
            PetData.Boredom = PetData.Boredom;
            PetData.StartEating = PetData.StartEating;
            PetData.StartDrinking = PetData.StartDrinking;
            return PetData;
        }
    }
}
