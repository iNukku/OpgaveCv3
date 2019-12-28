using System;
using System.Collections.Generic;
using System.Text;

namespace OpgaveCv3
{
    public abstract class AbstractUnit : IUnit
    {
        private IWeapon equippedWeapon;
        private IArmor unitArmor;
        private SniperRifle sniperrifleSlot;
        private int health;

        public IWeapon EquippedWeapon { get; }
        public IArmor UnitArmor { get; }
        public SniperRifle SniperSlot { get; }
        public int Health { get; }

        public int Attack()
        {
            throw new NotImplementedException();
        }

        public void TakeDamage(int incommingDmg)
        {
            throw new NotImplementedException();
        }
    }
}
