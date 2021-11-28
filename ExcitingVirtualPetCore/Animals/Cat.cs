using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Media.Imaging;

namespace ExcitingVirtualPetCore
{
    class Cat : Pet
    {
        public Cat() : base()
        {
            hereImage = new BitmapImage(new Uri("Resources/basic_cat.jpg", UriKind.Relative));
            leavingImage = new BitmapImage(new Uri("Resources/cat_leaving.jpg", UriKind.Relative));

            currentFood = 1;
            currentWater = 1;
            hunger = 5;
            affection = 0;
            thirst = 7;
            boredom = 5;
            startEating = 6;
            startDrinking = 6;

            sleepiness = 9;
            this.State = new Normal(this);
        }

    }
}
