using System;
using System.Collections.Generic;
using System.Text;

namespace ShotgunSurgery
{
    public class Orc
    {
        int _health = 100;
        void ReceiveDamage(int damage)
        {
            _health -= damage;
        }
    }
}
