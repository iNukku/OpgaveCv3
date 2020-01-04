using System;

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
            
            bool rungame = true;

            Console.WriteLine("A unit has been created - press q to quit, s to switch weapon, a to attack, r to reload");

            while (rungame == true)
            {

                string input = Console.ReadLine();
                if (input.ToLower() == "q")
                {
                    rungame = false;
                }
                else if (input.ToLower() == "s")
                {
                    theUnit.switchWeapon();
                }
                else if (input.ToLower() == "a")
                {
                    theUnit.Attack();
                }
                else if (input.ToLower() == "r")
                {
                    theUnit.ReloadWeapon();
                }
                else
                {
                    Console.WriteLine("Woops - something went wrong - try again");
                }
            }

            Console.WriteLine("Game ended");
            Console.ReadKey();
        }
    }
}
