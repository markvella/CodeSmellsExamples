using System;

namespace SwitchStatements.Bad
{
    public enum AnimalType
    {
        Bear,
        Cat,
        Dog
    }
    public class AnimalLogic
    {
        public void Attack(AnimalType type)
        {
            switch (type)
            {
                case AnimalType.Bear:
                    new Bear().Attack();
                    break;
                case AnimalType.Cat:
                    new Cat().Attack();
                    break;
                case AnimalType.Dog:
                    new Dog().Attack();
                    break;
            }
        }

        public void Run(AnimalType type)
        {
            switch (type)
            {
                case AnimalType.Bear:
                    new Bear().Run();
                    break;
                case AnimalType.Cat:
                    new Cat().Run();
                    break;
                case AnimalType.Dog:
                    new Dog().Run();
                    break;
            }

        }
    }
}
