using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCShop.Classes
{
    public class Module
    {
        public string Name { get; set; }
        public List<Part> PartsList { get; set; }

        public Module()
        {
            this.PartsList = new List<Part>();
        }

        public Module(string name)
        {
            this.Name = name;
            this.PartsList = new List<Part>();
        }

        public void AddPartToModule(Part part, int numOfPart)
        {
            try
            {
                for (int i = 0; i < numOfPart; i++)
                {
                    PartsList.Add(part);
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

    }
}
