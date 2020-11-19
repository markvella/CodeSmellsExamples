using System;
using System.Collections.Generic;
using System.Text;

namespace SwitchStatements.Better
{
    public class AnimalFactory
    {
        public IAnimal Create(AnimalType type)
        {
            switch (type)
            {
                case AnimalType.Bear:
                    return new Bear();
                case AnimalType.Cat:
                    return new Cat();
                case AnimalType.Dog:
                    return new Dog();
                default:
                    throw new NotImplementedException();
            }
        }
    }
}