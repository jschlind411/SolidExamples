using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static SolidExamples.OpenClose;

namespace SolidExamples.Principles
{
    public class Liskovs
    {
        public List<Ketchup> KetchupTypes;

        public Liskovs()
        {
            KetchupTypes = new List<Ketchup>()
            {
                new Ketchup(),
                new SpicyKetchup(),
                new SugarFreeKetchup()
            };
        }

        public void DisplayKetchupInfo()
        {
            foreach(var type in KetchupTypes)
            {
                Console.WriteLine(type.ToString());

                foreach (var ingredient in type.ReturnIngredients())
                {
                    Console.WriteLine(ingredient);
                }

                Console.WriteLine("---------------------------------------------");
            }
        }

    }
}
