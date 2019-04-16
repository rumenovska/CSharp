using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExercisesClass9Library;

namespace ExercisesClass9
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog d1 = new Dog("Lui", 20, "Meche");
            Dog d2 = new Dog("Sharko", 120, "Shupche");
            Dog d3 = new Dog("Lusi", 80, "Pudlica");

            Cat c1 = new Cat("Lea", 5, true);
            Cat c2 = new Cat("Dino", 68, false);
            Cat c3 = new Cat("Pina", 102, true);

            Bird b1 = new Bird("Papagal", 2, true);
            Bird b2 = new Bird("Chavka", 100, true);
            Bird b3 = new Bird("Gulab", 24, false);

            List<Dog> dogs = new List<Dog>() {d1, d2, d3 };
            List<Cat> cats = new List<Cat>() {c1, c2,c3 };
            List<Bird> birds = new List<Bird>() {b1,b2,b3 };

            var mecheRace = dogs
                .Where(x => x.Race == "Meche")
                .ToList();
            
            foreach(var m in mecheRace)
            {
                m.Print();
            }
            Console.WriteLine("----------------------------------------");
            var lastLazyCat = cats
                .LastOrDefault(x => x.IsLazy);
            if(lastLazyCat != null)
            {
                lastLazyCat.Print();
            }
            Console.WriteLine("----------------------------------------");
            var wildBirds = birds
                .Where(x => x.IsWild && x.Age > 3)
                .OrderBy(x => x.Name)
                .ToList();

            foreach (var b in wildBirds)
            {
                b.Print();
            }
            Console.WriteLine("----------------------------------------");
            string n = "Neshto";
            Console.WriteLine(n.GetFirstLetter());
            Console.WriteLine(n.LastLetter());
            int num1 = 11;
            Console.WriteLine(num1.IsEven());
            Console.WriteLine("----------------------------------------");
            var newList = dogs.GetNfromList(2);
            foreach(var d in newList)
            {
                d.Print();
            }
            List<int> nums = new List<int>() {1,2,3,4,5,6,7 };
            List<bool> bools = new List<bool>() { true, false, true, false, false };
            PrintList(nums);
            PrintList(bools);



           

            Console.ReadLine();


        }



        public static void PrintList<T>( List<T> list)
        {
            foreach (var item in list)
            {
                Console.WriteLine($"{item} ");
            }
        }

        public static void PrintAnimals<T> (List<T> animals) where T : Animal
        {
            foreach(var animal in animals)
            {
                animal.Print();
            }
        }

    }
}
