This project was an exercise in integrating multiple design patterns within a project. 

<h1>State Pattern<h2>

The State pattern is a behavioral design pattern in Object-Oriented Programming (OOP) that allows an object to change its behavior when its internal state changes. This pattern involves creating objects that represent different states and a context object whose behavior varies as its state object changes. This pattern allows for encapsulation of state-specific logic and helps to eliminate complex if/else conditions that can become difficult to maintain as the number of states grows. In this case, there were four states the "pet" could exist in: eating, drinking, normal, and sleeping. Here is an example of the Drinking state: 

```namespace ExcitingVirtualPetCore
{
    class Drinking : IPetState
    {
        private Pet pet;

        public Drinking(Pet pet)
        {
            this.pet = pet;
        }

        public void TryToDrink()
        {
            pet.CurrentWater--;
            pet.Thirst--;

            if (pet.Thirst == 0 || pet.CurrentWater == 0)
            {
                pet.State = new Normal(this.pet);
            }
        }

        public void TryToEat()
        {

        }

        public void Play()
        {

        }

        public void TryToSleep()
        {

        }
    }
}
```
There are more classes, but it drastically simplifies what would have been a very complex set of if/else statements. 
