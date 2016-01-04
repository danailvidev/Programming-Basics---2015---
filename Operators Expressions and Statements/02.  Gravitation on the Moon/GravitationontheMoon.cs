using System;

namespace _02.Gravitation_on_the_Moon
{
    class GravitationontheMoon
    {
        //The gravitational field of the Moon is approximately 17% of that on the Earth.Write a program that calculates theweight of a man on the moon 
         //   by a given weight on the Earth.
        static void Main()
        {
            Console.WriteLine("{0:F3}", MoonWeight(120));
        }
        public static double MoonWeight (double value)
        {
            return value * 17 / 100;
        }
    }
}
