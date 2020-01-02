using System;
using System.Collections.Generic;
using System.Text;

namespace OpgaveCv3
{
    public abstract class UnitDirector
    {
        public abstract IUnit Build(UnitBuilder builder);
    }
}
