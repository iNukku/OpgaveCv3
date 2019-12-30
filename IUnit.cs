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
        AbstractGrenade ThrownSlotOne { get; }
        AbstractGrenade ThrownSlotTwo { get; }
        AbstractGrenade ThrownSlotThree { get; }
        AbstractGrenade ThrownSlotFour { get; }

        int Health { get; }
        double DamageAmplifier { get; }
        bool IsAlive { get; }

        void TakeDamage(int incommingDmg);
        int Attack();
        void switchWeapon(IWeapon nextWeapon);

    }
}
