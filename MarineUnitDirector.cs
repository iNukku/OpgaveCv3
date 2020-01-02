using System;
using System.Collections.Generic;
using System.Text;

namespace OpgaveCv3
{
    class MarineUnitDirector : UnitDirector
    {
        public override IUnit Build(UnitBuilder builder)
        {

            builder.BuildArmor();
            builder.BuildGuns();
            builder.BuildKnife();
            builder.BuildThrown();
            builder.BuildStats();
            builder.BuildUnit();
            
            return builder.Unit;
        }
    }
}
