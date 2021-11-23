using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Media.Imaging;

namespace ExcitingVirtualPetCore
{
    class Dog : Pet
    {
        public Dog() : base()
        {
            hereImage = new BitmapImage(new Uri("Resources/dog.jpg", UriKind.Relative));
            leavingImage = new BitmapImage(new Uri("Resources/dog_leaving.png", UriKind.Relative));

            MAX_HUNGER = 10;
            MIN_HUNGER = 0;
            MAX_AFFECTION = 10;
            MIN_AFFECTION = 0;
            MAX_THIRST = 10;
            MIN_THIRST = 0;
            MAX_BOREDOM = 10;
            MIN_BOREDOM = 0;
            MAX_FOOD = 10;
            MIN_FOOD = 0;
            MAX_WATER = 10;
            MIN_WATER = 0;
            MAX_SLEEPINESS = 10;

            currentFood = 1;
            currentWater = 1;
            hunger = 5;
            affection = 0;
            thirst = 7;
            boredom = 5;
            startEating = 6;
            startDrinking = 6;
            sleepiness = 2;

            this.State = new Normal(this);
        }
    }

}
