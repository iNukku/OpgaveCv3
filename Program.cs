﻿using System;

namespace OpgaveCv3
{
    class Program
    {
        static void Main(string[] args)
        {

            //Create prototype of Marine using Builder
            UnitBuilder builder = new MarineBuilder();
            UnitDirector director = new MarineUnitDirector();
            IUnit theUnit = director.Build(builder);



            Console.ReadKey();
        }
    }
}
