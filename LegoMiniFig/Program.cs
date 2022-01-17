using System;
using LegoMiniFig.MiniFigureFolder;

namespace LegoMiniFig
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var Spaceman = new Figure("Spaceman","Space Helmet", "Spacesuit", "Space Pants", "Jetpack");

            Spaceman.printDetails();

            var Ninja = new Figure("Ninja", "Headband", "Jacket", "Trousers", "Katana");

            Ninja.printDetails();
        }
    }
}
