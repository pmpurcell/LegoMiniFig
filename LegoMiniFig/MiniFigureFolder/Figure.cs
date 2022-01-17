using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegoMiniFig.MiniFigureFolder
{
    internal class Figure
    {
        // Constructor
        public Figure(string name, string head, string torso, string legs, string accessories)
        {
            Name = name;    
            Head = head;
            Torso = torso;
            Legs = legs;
            Accessories = accessories;
        }
        //Hair or Hat, Head, Torso, Legs, Accessories
        // Properties

        public string Name { get; set; }
        public string Head { get; set; }
        public string Torso { get; set; }
        public string Legs { get; set; }
        public string Accessories { get; set; }

        // Method

        public void printDetails()
        {
            var output = ($@"
Name: {Name}
Head: {Head}
Torso: {Torso}
Legs: {Legs}
Accessories: {Accessories}");

            Console.WriteLine($"{output}");
        }
    }
}
