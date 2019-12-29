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
        IAutomaticWeapon AutoGunSlot { get; }
        AbstractHandgun HandgunSlot { get; }
        AbstractKnife KnifeSlot { get; }

        int Health { get; }
        int DamageAmplifier { get; }
        bool IsAlive { get; }

        void TakeDamage(int incommingDmg);
        int Attack();
        void switchWeapon(IWeapon nextWeapon);

    }
}
