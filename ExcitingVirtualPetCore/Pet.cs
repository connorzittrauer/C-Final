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
        //Constants
        protected int MAX_HUNGER;
        protected int MIN_HUNGER;
        protected int MAX_AFFECTION;
        protected int MIN_AFFECTION;
        protected int MAX_THIRST;
        protected int MIN_THIRST;
        protected int MAX_BOREDOM;
        protected int MIN_BOREDOM;
        protected int MAX_SLEEPINESS;


        //Resource Constants
        protected int MAX_FOOD;
        protected int MIN_FOOD;
        protected int MAX_WATER;
        protected int MIN_WATER;


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


        //protected bool currentlyEating = false;
        //protected bool currentlyDrinking = false;


        protected BitmapImage hereImage, leavingImage;

        protected bool currentlySleeping;

        //needs a state

        public IPetState state;

        public IPetState State

        {
            set { state = value; }
        }



        public Pet()
        {
            //currentlyEating = false;
            //currentlyDrinking = false;
            //currentlySleeping = false;
            //this.State = new Eating(this);
        }


        public void IncreaseHunger() {
            if (this.hunger < MAX_HUNGER) hunger++;
      

            //if (this.hunger > startEating)
            //{
            //    currentlyEating = true;
            //}
        }
        public void IncreaseThirst() 
        {
            if (this.thirst < MAX_THIRST) thirst++;

            //if (this.thirst > startDrinking) currentlyDrinking = true;
        }


        public void IncreaseBoredom()
        {
            if (this.boredom < MAX_BOREDOM) { boredom++; }
            
        }
        public void DecreaseAffection()
        {
            if (this.affection > MIN_AFFECTION) { affection--; }
            
        }

        public void TryToDrink()
        {
            //if (currentWater > MIN_WATER)
            //{
            //    currentWater--;
            //    thirst--;
            //}

            //if (thirst == MIN_THIRST || currentWater == MIN_WATER) currentlyDrinking = false;

            state.TryToDrink();

        }

        public void TryToEat()
        {

            //if (currentFood > MIN_FOOD)
            //{
            //    currentFood--;
            //    hunger--;
            //}

            //if (hunger == MIN_HUNGER || currentFood == MIN_FOOD) currentlyEating = false;

            state.TryToEat();

        }


        public void TryToSleep()
        {
            //if (sleepiness < MAX_SLEEPINESS)
            //{
            //    sleepiness++;
            //}
            //else { currentlySleeping = true; }

            state.TryToSleep();

        }


        public void Play()
        {
            //if (boredom > MIN_BOREDOM)
            //{
            //    boredom--;
            //}

            state.Play();

        }

        public bool RanOff() 
        {
            if (hunger == MAX_HUNGER && thirst == MAX_THIRST && boredom == MAX_BOREDOM && affection == MIN_AFFECTION)
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

        public int GET_MAX_HUNGER()
        {
            return MAX_HUNGER;
        }

        public int GET_MIN_HUNGER()
        {
            return MIN_HUNGER;
        }

        public int GET_MAX_AFFECTION()
        {
            return MAX_AFFECTION;
        }

        public int GET_MIN_AFFECTION()
        {
            return MIN_AFFECTION;
        }

        public int GET_MAX_SLEEPINESS()
        {
            return MAX_SLEEPINESS;
        }
        public int GET_MAX_THIRST()
        {
            return MAX_THIRST;
        }

        public int GET_MIN_THIRST()
        {
            return MIN_THIRST;
        }

        public int GET_MAX_BOREDOM()
        {
            return MAX_BOREDOM;
        }

        public int GET_MIN_BOREDOM()
        {
            return MIN_BOREDOM;
        }

        public int GET_MAX_FOOD()
        {
            return MAX_FOOD;
        }

        public int GET_MIN_FOOD()
        {
            return MIN_FOOD;
        }

        public int GET_MAX_WATER()
        {
            return MAX_WATER;
        }

        public int GET_MIN_WATER()
        {
            return MIN_WATER;
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
            if (currentFood < MAX_FOOD)
            {
                currentFood++;
            }

        }

        public void water()
        {
            if (currentWater < MAX_WATER)
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
            if (affection < MAX_AFFECTION)
            {
                affection++;
            }

        }

        public bool IsAwake()
        {
            return sleepiness < MAX_SLEEPINESS;
        }

        public bool IsSleeping()
        {
            return sleepiness >= MAX_SLEEPINESS;
        }

    }
}
