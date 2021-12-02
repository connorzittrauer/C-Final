using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Media.Imaging;

namespace ExcitingVirtualPetCore
{
    public interface IPet
    {

        public event EventHandler HungerChanged;
        public event EventHandler ThirstChanged;
        public event EventHandler BoredomChanged;
        public event EventHandler AffectionChanged;
        public event EventHandler WaterChanged;
        public event EventHandler FoodChanged;
        public event EventHandler SleepinessChanged;
        #region
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
        







        bool IsAwake();
        bool IsSleeping();
        #endregion

        void OnHungerChanged();
        void OnThirstChanged();
        void OnBoredomChanged();
        void OnAffectionChanged();
        void OnWaterChanged();
        void OnFoodChanged();
        void OnSleepinessChanged();

        int Sleepiness
        {
            get;
            set;
        }
        int CurrentFood
        {
            get;
            set;
        }
        int CurrentWater
        {
            get;
            set;
        }
        int Hunger
        {
            get;
            set;
        }

        int Affection
        {
            get;
            set;
        }
        int Thirst
        {
            get;
            set;
        }
        int Boredom
        {
            get;
            set;
        }
        BitmapImage currentImageState();

    }
}
