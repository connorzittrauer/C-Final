using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Diagnostics;
using System.Windows.Media.Effects;
using Microsoft.Win32;

namespace ExcitingVirtualPetCore
{
    public partial class MainWindow : Window
    {

        IPet CurrentPet = null;
        SaveFileDialog saveDialog;
        OpenFileDialog openDialog;
        Timer timer = new Timer();
        
        public MainWindow()
        {
            InitializeComponent();

            //set up initial stuff
            InitializeCat();
            timer.InitializeFrames();
            timer.initialize(MainLoopTimer_Tick);

            saveDialog = new SaveFileDialog();
            openDialog = new OpenFileDialog();


            saveDialog.Filter = "pet files |*.pet";
            openDialog.Filter = "pet files |*.pet";
            saveDialog.DefaultExt = "pet files |*.pet";
            openDialog.DefaultExt = "pet files |*.pet";
        }

        private void MainLoopTimer_Tick(object sender, EventArgs e)
        {
            //increase frame counters
            timer.increaseNeedCounters();

            //update cat needs
            timer.updateFrames(CurrentPet);

            //check game loss condition
            petDisatisfied();

            //update view
            UpdateView();

            checkSleep();
        }

        //Set up main data
        private void InitializeCat()
        {
            ISimpleFactory factory = new Factory();
            CurrentPet = factory.CreateAnimal();
            PetImage.Source = CurrentPet.currentImageState();
        }



        private void petDisatisfied()
        {
            //if you've really not taken care of your cat...
            if (CurrentPet.RanOff()) 
            { 
                PetImage.Source = CurrentPet.currentImageState();
                //stop main loop
                timer.stopTimer();
            }
            
        }

        private void checkSleep()
        {
            if (CurrentPet.IsSleeping()) 
            {
                MessageBox.Show("Pet Is Asleep, return back later...");
                timer.stopTimer();
            }
        }

        private void UpdateView()
        {
            HungerMeter.Value = CurrentPet.getHunger();
            ThirstMeter.Value = CurrentPet.getThirst();
            BoredomMeter.Value = CurrentPet.getBoredom();
            AffectionMeter.Value = CurrentPet.getAffection();
            WaterAmountBar.Value = CurrentPet.getWater();
            FoodAmountBar.Value = CurrentPet.getFood();
            SleepinessMeter.Value = CurrentPet.GetSleepiness();
        }

        private void PetFeedButton_Click(object sender, RoutedEventArgs e)
        {
            CurrentPet.feed();
        }

        private void PetWaterButton_Click(object sender, RoutedEventArgs e)
        {
            CurrentPet.water();
        }

        private void PetPlayButton_Click(object sender, RoutedEventArgs e)
        {
            CurrentPet.Play();

        }

        private void PetPatButton_Click(object sender, RoutedEventArgs e)
        {
            CurrentPet.pat();
        }

        private void Button_Load(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Save(object sender, RoutedEventArgs e)
        {

        }



        //private void MenuItem_Click(object sender, RoutedEventArgs e)
        //{

        //}

        //private void _Load(object sender, RoutedEventArgs e)
        //{
        //    MessageBox.Show("Loaded");
        //}
    }

}
