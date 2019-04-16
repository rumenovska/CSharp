using System;

namespace ExercisesClass9Library
{
    public abstract class Animal
    {
        public string Name { get; set; }
        private int _age;
        public int Age
        {
            get
            {
                return this._age;
            }

            set
            {
                if ((value < 0) || (value >= 175))
                {
                    Console.WriteLine("Err");
                    return;
                }
                this._age = value;
            }
        }
        public Animal(string name, int age)
        {
            this.Name = name;
            this.Age = age;
            
        }
        public abstract void Print();
    }
}
