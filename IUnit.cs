using System;
using System.Collections.Generic;
using System.Text;

namespace OpgaveCv3
{
    public interface IUnit
    {
        IWeapon EquippedWeapon { get; }
        IArmor UnitArmor { get; }
        SniperRifle SniperSlot { get; }
        int Health { get; }

        void TakeDamage(int incommingDmg);
        int Attack();

    }
}
