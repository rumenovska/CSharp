using PCShop.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCShop.Classes
{
    public class Configuration
    {
        public string Name { get; set; }
        public Dictionary<Part, int> Parts;
        public Dictionary<Module, int> Modules;
        public Colors BoxColor { get; set; }
        public Configuration()
        {
            this.Parts = new Dictionary<Part, int>();
            this.Modules = new Dictionary<Module, int>();
        }
        public Configuration(Colors colors)
        {
            this.BoxColor = colors;
            this.Parts = new Dictionary<Part, int>();
            this.Modules = new Dictionary<Module, int>();

        }
        public void AddPartToProduct(Part part, int numOfPart)
        {
            Parts.Add(part, numOfPart);

        }

        public void AddModuleToProduct(Module module, int numOfModules)
        {
            Modules.Add(module, numOfModules);

        }

    }
}
