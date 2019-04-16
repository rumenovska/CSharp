using System;
using System.Collections.Generic;
using System.Text;

namespace ExercisesClass9Library
{
    public class Cat:Animal
    {
        public bool IsLazy { get; set; }

        public Cat(string name, int age, bool isLazy)
            : base(name, age)
        {
            this.IsLazy = isLazy;
        }

        public override void Print()
        {
            Console.WriteLine($"Name: {Name} Age: {Age} Is lazy: {IsLazy}");
        }

        public void Meow()
        {
            Console.WriteLine("MEOW MEOW!");
        }
    }
}
