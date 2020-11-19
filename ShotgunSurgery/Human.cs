using System;

namespace ShotgunSurgery
{
    public class Human
    {
        int _health = 100;
        void ReceiveDamage(int damage)
        {
            _health -= damage;
        }
    }
}
