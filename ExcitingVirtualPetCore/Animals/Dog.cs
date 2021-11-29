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

            currentFood = 1;
            currentWater = 1;
            hunger = 5;
            affection = 0;
            thirst = 7;
            boredom = 8;
            startEating = 6;
            startDrinking = 6;
            sleepiness = 0;

            this.State = new Normal(this);
        }
    }

}
