using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalLibrary
{
    public abstract class Animal
    {
        public abstract bool  Feathers { get; set; }

        public virtual string Info()
        {
            return "Basic info about animal";
        }
        public abstract string HasFeatures();
        public abstract bool HasFeathers();
        
        

    }
}
