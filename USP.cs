using System;
using System.Collections.Generic;
using System.Text;

namespace OpgaveCv3
{
    public class USP : AbstractHandgun
    {
        public USP() : base("USP-gun", 33)
        {
            amountOfBullits = 30;
            amountOfBullitsInClip = 13;
            clipSize = 7;
        }
    }
}
