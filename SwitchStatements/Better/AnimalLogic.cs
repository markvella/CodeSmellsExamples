using System;

namespace SwitchStatements.Better
{
    public enum AnimalType
    {
        Bear,
        Cat,
        Dog
    }
    public class AnimalLogic
    {
        private AnimalFactory _animalFactory;

        public AnimalLogic(AnimalFactory animalFactory)
        {
            _animalFactory = animalFactory;
        }
        public void Attack(AnimalType type)
        {
            var animal = _animalFactory.Create(type);
            animal.Attack();
        }

        public void Run(AnimalType type)
        {
            var animal = _animalFactory.Create(type);
            animal.Run();
        }
    }
}
