using System;
using System.Collections.Generic;
using System.Text;

namespace ExercisesClass9Library
{
    public class Bird: Animal
    {
        public bool IsWild { get; set; }

        public Bird(string name, int age, bool isWild)
           : base(name, age)
        {
            this.IsWild = isWild;
        }

        public override void Print()
        {
            Console.WriteLine($"Name: {Name} Age: {Age} Is wild: {IsWild}");
        }

        public void FlySouth()
        {
            if(!IsWild)
            {
                
                Console.WriteLine("It's domesticated bird");
                
            }
            else
            {
                Console.WriteLine("Flying South");
            }
                 
            
        }
    }
}
