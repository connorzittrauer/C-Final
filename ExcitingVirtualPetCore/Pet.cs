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



        public IPetState state;

        public IPetState State

        {
            set { state = value; }
        }

        public int Sleepiness
        {
            get { return sleepiness; }
            set { sleepiness = value; }
        }


        public int CurrentFood
        {
            get { return currentFood; }
            set { currentFood = value; }
        }
        public int CurrentWater
        {
            get { return currentWater; }
            set { currentWater = value; }
        }
        public int Hunger
        {
            get { return hunger; }
            set { hunger = value; }
        }
        public int Affection
        {
            get { return affection; }
            set { affection = value; }
        }
        public int Thirst
        {
            get { return thirst; }
            set { thirst = value; }
        }
        public int Boredom
        {
            get { return boredom; }
            set { boredom = value; }
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


        public Pet()
        {
            currentlySleeping = false;
        }


        public void IncreaseHunger() {
            if (this.hunger < 10) hunger++;

        }
        public void IncreaseThirst() 
        {
            if (this.thirst < 10) thirst++;

        }


        public void IncreaseBoredom()
        {
            if (this.boredom < 10) { boredom++; }
            
        }
        public void DecreaseAffection()
        {
            if (this.affection > 0) { affection--; }
            
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
            if (hunger == 10 && thirst == 10 && boredom == 10 && affection == 0)
            {
                //returns true so the mainLoopTimer has a trigger to halt
                return true;
            }
            else { return false; }
        }



        //accessors
        public int getHunger() 
        {
            return hunger;
        }
        public int getAffection()
        {
            return affection;
        }
        public int getThirst()
        {
            return thirst;
        }
        public int getBoredom()
        {
            return boredom;
        }
        public int getFood()
        {
            return currentFood;
        }
        public int getWater()
        {
            return currentWater;
        }

        public int GetSleepiness()
        {
            return sleepiness;
        }
        public int getStartEating()
        {
            return startEating;
        }
        public int getStartDrinking()
        {
            return startDrinking;
        }

        public BitmapImage currentImageState()
        {
            if (RanOff()) { return leavingImage; }
            else { return hereImage; }
        }
        public void incrementHunger()
        {
            hunger++;
        }

        public void decrementBoredom()
        {
            boredom--;
        }

        public void incrementSleepiness()
        {
            sleepiness++;
        }

        public void setSleepState(bool value)
        {
            currentlySleeping = value;
        }


        public void feed()
        {
            if (currentFood < 10)
            {
                currentFood++;
            }

        }

        public void water()
        {
            if (currentWater < 10)
            {
                currentWater++;
            }
        }
        
        public void decrementFood()
        {
            currentFood--;
        }

        public void decrementHunger()
        {
            hunger--;
        }
        public void decrementWater()
        {
            currentWater--;
        }

        public void decrementThirst()
        {
            thirst--;
        }

        public void pat()
        {
            if (affection < 10)
            {
                affection++;
            }

        }

        public bool IsAwake()
        {
            return sleepiness < 10;
        }

        public bool IsSleeping()
        {
            return sleepiness >= 10;
        }

    }
}
