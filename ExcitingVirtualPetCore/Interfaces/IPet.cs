using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Media.Imaging;

namespace ExcitingVirtualPetCore
{
    public interface IPet
    {
        //actions
        void IncreaseHunger();

        void IncreaseThirst();
        void IncreaseBoredom();
        void DecreaseAffection();
        void TryToDrink();
        void TryToEat();

        void TryToSleep();
        bool RanOff();
        void feed();
        void water();
        void Play();
        void pat();

        void incrementHunger();
        void decrementFood();
        void decrementHunger();
        int getHunger();
        int getAffection();
        int getThirst();
        int getBoredom();
        int getFood();
        int GetSleepiness();
        int getWater();
        int getStartEating();
        int getStartDrinking();


        bool IsAwake();
        bool IsSleeping();


        BitmapImage currentImageState();

    }
}
