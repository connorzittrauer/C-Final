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

        //mutators
        void incrementHunger();
        void decrementFood();
        void decrementHunger();
        void setEating(bool value);

        //accessors
        int GET_MAX_HUNGER();
        int GET_MIN_HUNGER();
        int GET_MAX_AFFECTION();
        int GET_MIN_AFFECTION();
        int GET_MAX_THIRST();
        int GET_MIN_THIRST();
        int GET_MAX_BOREDOM();
        int GET_MIN_BOREDOM();

        //Resource Constants
        int GET_MAX_FOOD();
        int GET_MIN_FOOD();
        int GET_MAX_WATER();
        int GET_MIN_WATER();

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
