using System;
using System.Collections.Generic;
using System.Text;

namespace ShotgunSurgery
{
    public class MitigationItem
    {
        private readonly int _damageMitigation;

        public MitigationItem(int damageMitigation)
        {
            this._damageMitigation = damageMitigation;
        }

        public int CalculateDamageMitigcation(int damage)
        {
            return damage - _damageMitigation;
        }
    }
}
