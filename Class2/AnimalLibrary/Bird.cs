using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalLibrary
{
    public class Bird: Animal
    {
        public override bool Feathers { get; set; } = true;
        public override string Info()
        {
            return "This is about Bird";
        }
        public override string HasFeatures()
        {
            return "Can fly";
        }
        public override bool HasFeathers()
        {
            return Feathers;
        }
    }
}
