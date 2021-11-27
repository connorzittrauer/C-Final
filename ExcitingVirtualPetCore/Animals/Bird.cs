using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Media.Imaging;

namespace ExcitingVirtualPetCore
{
    class Bird : Pet
    {

        public Bird() : base()
        {
            hereImage = new BitmapImage(new Uri("Resources/bird.jpg", UriKind.Relative));
            leavingImage = new BitmapImage(new Uri("Resources/bird_leaving.jpg", UriKind.Relative));

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
