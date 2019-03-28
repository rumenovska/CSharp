using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalLibrary
{
    public class Dog: Animal
    {
        public override bool Feathers { get; set; } = false;
        public override string Info()
        {
            return "This is about Dog";
        }
        public override string HasFeatures()
        {
            return "Can bark";
        }
        public override bool HasFeathers()
        {
            return Feathers;
        }
    }
}
