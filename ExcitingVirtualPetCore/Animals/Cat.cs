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

            CurrentFood = 3;
            CurrentWater = 5;
            Hunger = 5;
            Affection = 0;
            Thirst = 7;
            Boredom = 5;
            StartEating = 6;
            StartDrinking = 6;
            Sleepiness = 9;
            this.State = new Normal(this);
        }

    }
}
