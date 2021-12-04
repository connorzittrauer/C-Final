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

            CurrentFood = 1;
            CurrentWater = 2;
            Hunger = 8;
            Affection = 4;
            Thirst = 7;
            Boredom = 8;
            StartEating = 6;
            StartDrinking = 6;
            Sleepiness = 1;

            this.State = new Normal(this);
        }
    }

}
