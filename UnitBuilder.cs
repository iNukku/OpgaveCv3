using System;
using System.Collections.Generic;
using System.Text;

namespace OpgaveCv3
{
    public abstract class UnitBuilder
    {
        protected IArmor armor;
        protected SniperRifle sniper;
        protected AbstractShootingWeapon shooter;
        protected AbstractHandgun gun;
        protected AbstractKnife knife;
        protected AbstractGrenade g1;
        protected AbstractGrenade g2;
        protected AbstractGrenade g3;
        protected AbstractGrenade g4;
        protected int health;
        protected MarineUnit unit;

        public virtual void BuildArmor() { }
        public virtual void BuildGuns() { }
        public virtual void BuildThrown() { }
        public virtual void BuildKnife() { }
        public virtual void BuildStats() { }
        public virtual void BuildUnit() { }
        public abstract IUnit Unit { get; }
    }
}
