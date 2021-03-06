﻿using System;
using System.Collections.Generic;
using System.Text;

namespace OpgaveCv3
{
    public abstract class AbstractWeapon : IWeapon
    {
        #region fields and properties
        private string weaponName;
        private int damage;
        public string WeaponName { get { return weaponName; } }
        public int Damage { get { return damage; } }
        #endregion

        #region public methods
        public abstract int DoDamage();
        public override string ToString()
        {
            string returnString = $"Your Weapon is a {weaponName} and its basedamage is {damage}";
            return returnString;
        }
        #endregion
        #region constructors
        public AbstractWeapon(string name, int damage)
        {
            this.weaponName = name;
            this.damage = damage;
        }
        #endregion
    }
}
