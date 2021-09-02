using SolidExamples.Principles;
using System;
using System.Collections.Generic;
using static SolidExamples.OpenClose;
using static SolidExamples.Principles.InterfaceSegregation;

namespace SolidExamples
{
    public class Program
    {
        public static List<Condiment> condiments;

        public static List<GlassContainer> containers; 

        static void Main(string[] args)
        {
            containers = new List<GlassContainer>()
            {
                new GlassBottle(new Ketchup()),
                new GlassBottle(new SpicyKetchup()),
                new GlassBottle(new SugarFreeKetchup())
            };

            foreach(var bottle in containers)
            {
                bottle.OpenLid();
                bottle.CloseLid();
            }

            condiments = GetAllCondiments();

            var SRP = new SingleResponsibility();
            SRP.Greeting();

            StoryBeginning();
        }

        private static void StoryBeginning()
        {
            Console.WriteLine("You are at your favorite burger joint. You just got a hot and juicy bacon burger.");
            Console.WriteLine("You look at the table and see several condiments before you:");

            DisplayTableCondiments();

            Console.WriteLine("You reach for which item?");
            var condiment = condiments[int.Parse(Console.ReadLine()) - 1];

            Console.WriteLine("You pick up the bottle and read the list of ingredients");
            
            foreach(var item in condiment.ReturnIngredients())
            {
                Console.WriteLine(item);
            }

            if(condiment is PlasticContainer)
            {
                var plasticContainer = (PlasticContainer)condiment;
                plasticContainer.OpenLid();
                plasticContainer.Squeeze();
                Console.WriteLine("Your burger is looking mighty tasty");
                plasticContainer.CloseLid();
            }
            else if(condiment is GlassContainer)
            {
                var glassContainer = (GlassContainer)condiment;
            }
        }

        private static void DisplayTableCondiments()
        {           
            int index = 0;

            foreach (var condiment in condiments)
            {
                Console.WriteLine($"- {index + 1} A " + condiment.ToString());
                index++;
            }
        }

        private static List<Condiment> GetAllCondiments()
        {
            var condiments = new List<Condiment>();

            condiments.AddRange(GetAllKetchups());
            condiments.AddRange(GetAllMustards());

            return condiments;
        }

        private static List<Ketchup> GetAllKetchups()
        {
            return new List<Ketchup>()
            {
                new GlassBottleOfKetchup(),
                new PlasticBottleOfKetchup(),
                new GlassBottleOfSpicyKetchup(),
                new PlasticBottleOfSpicyKetchup(),
                new GlassBottleOfSugarFreeKetchup(),
                new PlasticBottleOfSugarFreeKetchup(),
            };
        }

        private static List<Mustard> GetAllMustards()
        {
            return new List<Mustard>()
            {
                new GlassBottleOfMustard(),
                new PlasticBottleOfMustard()
            };
        }
    }
}
