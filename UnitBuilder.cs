using System;
using System.Collections.Generic;
using System.Text;

namespace OpgaveCv3
{
    public abstract class UnitBuilder
    {
        public virtual void BuildArmor() { }
        public virtual void BuildGuns() { }
        public virtual void BuildGrenades() { }
        public virtual void BuildKnife() { }
        public virtual void BuildStats() { }
        public abstract IUnit Unit { get; }
    }
}
