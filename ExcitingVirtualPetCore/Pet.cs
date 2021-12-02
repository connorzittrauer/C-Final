using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace ExcitingVirtualPetCore
{
    //represents methods universal to all pets

    public class Pet : IPet

    {
        protected int hunger;
        protected int affection;
        protected int thirst;
        protected int boredom;
        protected int currentFood;
        protected int currentWater;
        protected int startEating;
        protected int startDrinking;
        protected int sleepiness;
        protected bool type;
        protected BitmapImage hereImage, leavingImage;
        protected bool currentlySleeping;

        //event handlers
        public event EventHandler HungerChanged;
        public event EventHandler ThirstChanged;
        public event EventHandler BoredomChanged;
        public event EventHandler AffectionChanged;
        public event EventHandler WaterChanged;
        public event EventHandler FoodChanged;
        public event EventHandler SleepinessChanged;


        public IPetState state;

        public IPetState State

        {
            set { state = value; }
        }


        public int Sleepiness
        {
            get { return sleepiness; }
            set
            { 
                sleepiness = value;
                OnSleepinessChanged();            
            }
        }


        public int CurrentFood
        {
            get { return currentFood; }
            set 
            { 
                currentFood = value;
                OnFoodChanged();
            }
        }
        public int CurrentWater
        {
            get { return currentWater; }
            set 
            { 
                currentWater = value;
                OnWaterChanged();
            }
        }

        public int Hunger
        {
            get { return hunger; }
            set
            {
                hunger = value;
                OnHungerChanged();

            }
        }  
        
        public int Affection
        {
            get { return affection; }
            set 
            { 
                affection = value;
                OnAffectionChanged();
            }
        }
        public int Thirst
        {
            get { return thirst; }
            set 
            { 
                thirst = value;
                OnThirstChanged();
            }
        }
        public int Boredom
        {
            get { return boredom; }
            set 
            {
                boredom = value;
                OnBoredomChanged();
            }
        }


        public int StartEating
        {
            get { return startEating; }
            set { startEating = value; }
        }
        public int StartDrinking
        {
            get { return startDrinking; }
            set { startDrinking = value; }
        }
        public bool CurrentlySleeping
        {
            get { return currentlySleeping; }
            set { currentlySleeping = value; }
        }

        #region
        public Pet()
        {
            currentlySleeping = false;
        }


        public void IncreaseHunger()
        {
            if (this.Hunger < 10) Hunger++;

        }
        public void IncreaseThirst()
        {
            if (this.Thirst < 10) Thirst++;

        }


        public void IncreaseBoredom()
        {
            if (this.Boredom < 10) { Boredom++; }

        }
        public void DecreaseAffection()
        {
            if (this.Affection > 0) { Affection--; }

        }

        public void TryToDrink()
        {
            state.TryToDrink();

        }

        public void TryToEat()
        {
            state.TryToEat();
        }


        public void TryToSleep()
        {
            state.TryToSleep();
        }


        public void Play()
        {
            state.Play();
        }

        public bool RanOff()
        {
            if (Hunger == 10 && Thirst == 10 && Boredom == 10 && Affection == 0)
            {
                //returns true so the mainLoopTimer has a trigger to halt
                return true;
            }
            else { return false; }
        }

        public BitmapImage currentImageState()
        {
            if (RanOff()) { return leavingImage; }
            else { return hereImage; }
        }


        public void setSleepState(bool value)
        {
            CurrentlySleeping = value;
        }


        public void feed()
        {
            if (CurrentFood < 10)
            {
                CurrentFood++;
            }

        }

        public void water()
        {
            if (CurrentWater < 10)
            {
                CurrentWater++;
            }
        }







        public void pat()
        {
            if (Affection < 10)
            {
                Affection++;
            }

        }

        public bool IsAwake()
        {
            return Sleepiness < 10;
        }

        public bool IsSleeping()
        {
            return Sleepiness >= 10;
        }
        #endregion


        //event methods
        public void OnHungerChanged()
        {
            if (HungerChanged != null)
            {
                HungerChanged(this, null);
            }
        }
        public void OnThirstChanged()
        {
            if (ThirstChanged != null)
            {
                ThirstChanged(this, null);
            }
        }

        public void OnBoredomChanged()
        {
            if (BoredomChanged != null)
            {
                BoredomChanged(this, null);
            }
        }
        public void OnAffectionChanged()
        {
            if (AffectionChanged != null)
            {
                AffectionChanged(this, null);
            }
        }
        public void OnWaterChanged()
        {
            if (WaterChanged != null) 
            {
                WaterChanged(this, null);
            }
        }

        public void OnFoodChanged()
        {
            if (FoodChanged != null)
            {
                FoodChanged(this, null);
            }
        }

        public void OnSleepinessChanged()
        {
            if (SleepinessChanged != null)
            {
                SleepinessChanged(this, null);
            }
        }
    }


}
