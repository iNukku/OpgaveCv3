using System;
using System.Collections.Generic;
using System.Text;

namespace OpgaveCv3
{
    public class DesertEagle : AbstractHandgun
    {
        public DesertEagle() : base("Desert Eagle", 48)
        {
            amountOfBullits = 35;
            amountOfBullitsInClip = 7;
            clipSize = 7;
        }
    }
}
