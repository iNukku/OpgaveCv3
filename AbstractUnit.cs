using System;
using System.Collections.Generic;
using System.Text;

namespace OpgaveCv3
{
    public abstract class AbstractUnit : IUnit
    {
        private bool isAlive;
        private int health;
        private double damageAmplifier;
        private IWeapon equippedWeapon;
        private IArmor unitArmor;
        private SniperRifle sniperSlot;
        private AbstractShootingWeapon autoGunSlot;
        private AbstractHandgun handgunSlot;
        private AbstractKnife knifeSlot;
        private AbstractGrenade thrownSlotOne;
        private AbstractGrenade thrownSlotTwo;
        private AbstractGrenade thrownSlotThree;
        private AbstractGrenade thrownSlotFour;


        public int Health { get { return health; } }
        public IWeapon EquippedWeapon { get { return equippedWeapon; } }
        public IArmor UnitArmor { get { return unitArmor; } }
        public SniperRifle SniperSlot { get { return sniperSlot; } }
        public AbstractShootingWeapon AutoGunSlot { get { return autoGunSlot; } }
        public AbstractHandgun HandgunSlot { get { return handgunSlot; } }
        public AbstractKnife KnifeSlot { get { return knifeSlot; } }
        public AbstractGrenade ThrownSlotOne { get { return thrownSlotOne; } }
        public AbstractGrenade ThrownSlotTwo { get { return thrownSlotTwo; } }
        public AbstractGrenade ThrownSlotThree { get { return thrownSlotThree; } }
        public AbstractGrenade ThrownSlotFour { get { return thrownSlotFour; } }
        public double DamageAmplifier { get { return damageAmplifier; } }
        public bool IsAlive {get { return isAlive; }}

        public int Attack()
        {
            double x = equippedWeapon.DoDamage() * damageAmplifier;
            Console.WriteLine($"You deal {x} damage to your target");
            try
            {
                IThrown theweapon = EquippedWeapon as IThrown;
                Console.WriteLine($"Extra effect: {theweapon.DoEffect()}");
            }
            catch (Exception)
            {
                Console.WriteLine("No other effect");
            }
            return (int)Math.Floor(x);
        }

        //TODO : Tjek for null + roter igennem våben
        public void switchWeapon(IWeapon nextWeapon)
        {
            throw new NotImplementedException();
        }

        public void TakeDamage(int incommingDmg)
        {
            if (this.unitArmor.Value <= 0)
            {
                unitArmor.ReduceArmor(incommingDmg);
            }
            else if (this.health > 0)
            {
                this.health -= incommingDmg;
                if (this.health <= 0)
                {
                    Console.WriteLine("You are dead");
                    this.isAlive = false;
                }
            }else
            {
                Console.WriteLine("You are already dead!!!");
            }
        }

        public void ReloadWeapon()
        {
            try
            {
                AbstractShootingWeapon myshootingweapon = EquippedWeapon as AbstractShootingWeapon;
                Console.WriteLine($"Amount of bullits in clip: {myshootingweapon.AmountOfBullitsInClip}");
                myshootingweapon.Reload();
            }
            catch (Exception)
            {
                Console.WriteLine("You can not reload this weapon");
            }
        }

        public AbstractUnit(double dmgamp, IArmor armor, SniperRifle rifle, AbstractShootingWeapon autoweapon, AbstractHandgun gun, AbstractKnife knife, AbstractGrenade grenadeone, AbstractGrenade grenadetwo, AbstractGrenade grenadethree, AbstractGrenade grenadefour) {
            this.isAlive = true;
            this.health = 100;
            this.damageAmplifier = dmgamp;
            this.unitArmor = armor;
            this.sniperSlot = rifle;
            this.autoGunSlot = autoweapon;
            this.handgunSlot = gun;
            this.knifeSlot = knife;
            this.thrownSlotOne = grenadeone;
            this.thrownSlotTwo = grenadetwo;
            this.thrownSlotThree = grenadethree;
            this.thrownSlotFour = grenadefour;
            this.equippedWeapon = thrownSlotOne;
        }
    }
}
