This project was an exercise in integrating multiple design patterns within a project. 

<h1>State Pattern<h2>
<h3></h3>

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
