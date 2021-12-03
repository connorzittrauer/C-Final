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

            CurrentFood = 1;
            CurrentWater = 1;
            Hunger = 3;
            Affection = 0;
            Thirst = 6;
            Boredom = 8;
            StartEating = 6;
            StartDrinking = 6;
            Sleepiness = 0;
            this.State = new Normal(this);
        }
    }
}
