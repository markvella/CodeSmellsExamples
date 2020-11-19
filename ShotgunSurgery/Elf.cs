using System;
using System.Collections.Generic;
using System.Text;

namespace ShotgunSurgery
{
    public class Elf
    {
        int _health = 100;
        void ReceiveDamage(int damage)
        {
            _health -= damage;
        }
    }
}
