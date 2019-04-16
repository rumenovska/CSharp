using System;
using System.Collections.Generic;
using System.Text;

namespace ExercisesClass9Library
{
    public class Dog: Animal
    {
        public string Race { get; set; }


        public Dog(string name, int age, string race)
            : base(name,age)
        {
            this.Race= race;
        }

        public override void Print()
        {
            Console.WriteLine($"Name: {Name} Age: {Age} Race: {Race}");
        }

        public void Bark()
        {
            Console.WriteLine("BARK BARK!");
        }
    }
}
