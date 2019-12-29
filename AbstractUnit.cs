using System;
using System.Collections.Generic;
using System.Text;

namespace OpgaveCv3
{
    public abstract class AbstractUnit : IUnit
    {
        private int health;
        private int damageAmplifier;
        private IWeapon equippedWeapon;
        private IArmor unitArmor;
        private SniperRifle sniperSlot;
        private IAutomaticWeapon autoGunSlot;
        private AbstractHandgun handgunSlot;
        private AbstractKnife knifeSlot;
        private bool isAlive;

        public int Health { get { return health; } }
        public IWeapon EquippedWeapon { get { return equippedWeapon; } }
        public IArmor UnitArmor { get { return unitArmor; } }
        public SniperRifle SniperSlot { get { return sniperSlot; } }
        public IAutomaticWeapon AutoGunSlot { get { return autoGunSlot; } }
        public AbstractHandgun HandgunSlot { get { return handgunSlot; } }
        public AbstractKnife KnifeSlot { get { return knifeSlot; } }
        public int DamageAmplifier { get { return damageAmplifier; } }
        public bool IsAlive {get { return isAlive; }}

        public int Attack()
        {
            int x = equippedWeapon.DoDamage();
            return x;
        }

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
    }
}
