using System;

namespace OpgaveCv3
{
    class Program
    {
        static void Main(string[] args)
        {

            UnitBuilder builder = new MarineBuilder();
            UnitDirector director = new MarineUnitDirector();
            IUnit theUnit = director.Build(builder);

            theUnit.switchWeapon();
            theUnit.Attack();

            Console.ReadKey();
        }
    }
}
