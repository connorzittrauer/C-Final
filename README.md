This project was an exercise in integrating multiple design patterns within a project. 

<h1>State Pattern</h1>

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

<h2>Factory Pattern</h2>
The Factory pattern is a creational design pattern  that provides a way to create objects without specifying the exact class of the object that will be created. The factory pattern involves creating a factory class that has a method for creating objects. This method is used to instantiate objects of different classes, depending on the data provided to the factory. The factory pattern provides a way to decouple object creation from the client code and can be useful when a class cannot anticipate the type of objects it must create, or when a class wants to delegate the responsibility of object creation to its subclasses. This pattern allows for greater flexibility and maintainability in the code and can improve the overall structure of the codebase. Here, the factory pattern was used to instantiate different types of pets from an abstract pet class:

```
{
    class Factory : ISimpleFactory
    {
        private List<IPet> PetFactory = new List<IPet>();
        private IPet pet = null;

        public override IPet CreateAnimal(int value)
        {
            switch (value)
            {
                case 1:
                    pet = new Cat();
                    PetFactory.Add(pet);
                    break;
                case 2:
                    pet = new Dog();
                    PetFactory.Add(pet);
                    break;
                case 3:
                    pet = new Bird();
                    PetFactory.Add(pet);
                    break;
                default:
                    pet = new Cat();
                    PetFactory.Add(pet);
                    break;
                       
            }
            return pet;


        }
    }
```
As we can see, this is an exciting pattern as we don't have to pre-instantiate objects, we can create them as needed, like a factory!
