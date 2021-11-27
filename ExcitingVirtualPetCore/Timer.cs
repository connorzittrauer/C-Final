using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Windows.Threading;

namespace ExcitingVirtualPetCore
{
    class Timer
    {
        DispatcherTimer mainLoopTimer;
        int hungerFrame;
        int thirstFrame;
        int boredomFrame;
        int affectionFrame;
        int eatFrame;
        int drinkFrame;
        int hungerCounter;
        int thirstCounter;
        int boredomCounter;
        int affectionCounter;
        int eatCounter;
        int drinkCounter;

        int sleepCounter;
        int sleepFrame;

        Random generator; 

        public Timer()
        {

        }

        public void initialize(EventHandler MainLoopTimer_Tick)
        {
            mainLoopTimer = new DispatcherTimer();
            mainLoopTimer.Interval = new TimeSpan(17); //runs every 60th of a second
            mainLoopTimer.Tick += MainLoopTimer_Tick; //run MainLoopTimer_Tick method every 60th of a second
            mainLoopTimer.Start(); //start the main loop
           
        }

        public void updateFrames(IPet CurrentPet)
        {
            //How Frame Counters Work
            //The frame counters "count" every tick of the main loop timer.
            //Once the counter reaches a frame (like hungerFrame), the cat
            //performs that action.  This way we can have 1 timer and multiple
            //actions that can be performed.  Once the count reaches the frame,
            //we also need to remember to reset the counter for the next time.

            if (hungerCounter >= hungerFrame)
            {
                //reset frame counter
                CurrentPet.IncreaseHunger();
                hungerCounter = 0;

            }
            if (thirstCounter >= thirstFrame)
            {
                CurrentPet.IncreaseThirst();
                thirstCounter = 0;

            }
            if (affectionCounter >= affectionFrame)
            {
                CurrentPet.DecreaseAffection();
                affectionCounter = 0;

            }

            if (boredomCounter >= boredomFrame)
            {
                CurrentPet.IncreaseBoredom();
                boredomCounter = 0;
            }
                
                drinkCounter++;
                sleepCounter++;
                eatCounter++;
                //boredomCounter++;
                
                if (eatCounter >= eatFrame)
                {
                    CurrentPet.TryToEat();
                    eatCounter = 0;

                }
                if (drinkCounter >= drinkFrame)
                {
                    CurrentPet.TryToDrink();
                    drinkCounter = 0;

                }

                if (sleepCounter >= sleepFrame)
                {
                    CurrentPet.TryToSleep();
                    sleepCounter = 0;
                }
            
            
        }

        public void InitializeFrames()
        {
            generator = new Random();
            //set these to somewhat random amounts so the cat gets hungry/thirsty at different rates
            hungerFrame = generator.Next(120, 600);
            thirstFrame = generator.Next(120, 600);
            boredomFrame = generator.Next(120, 600);
            affectionFrame = generator.Next(120, 600);
            sleepFrame = generator.Next(120, 600);



            //cat eats and drinks 1 unit per second
            eatFrame = 60;
            drinkFrame = 60;
            
            //higher value
            sleepFrame = 340;

            //initialize the starter counters to 0
            hungerCounter = 0;
            thirstCounter = 0;
            affectionCounter = 0;
            eatCounter = 0;
            drinkCounter = 0;
            sleepCounter = 0;
        }

        public void increaseNeedCounters()
        {
            hungerCounter++;
            thirstCounter++;
            affectionCounter++;
            boredomCounter++;
            sleepCounter++;
        }

        public void stopTimer()
        {
           mainLoopTimer.Stop();
        }
    }
}
