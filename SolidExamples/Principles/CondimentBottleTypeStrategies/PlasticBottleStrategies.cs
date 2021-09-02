using System;

namespace SolidExamples.Principles.CondimentBottleTypeStrategies
{
    public class PlasticBottleStrategies
    {
        public static void OpenNormalPlasticBottle(string condimentName)
        {
            Console.WriteLine("You flip the cap off the " + condimentName);
        }

        public static void CloseNormalPlasticBottle(string condimentName)
        {
            Console.WriteLine("You flip the lid of the plastic bottle closed.");
        }

        public static void SqueezeNormalPlasticBottle(string baseCondimentName)
        {
            Console.WriteLine("You squeeze out an ample portion of " + baseCondimentName);
        }

        public static void SqueezeUnShakenPlasticBottle(string baseCondimentName)
        {
            Console.WriteLine("You go to squeeze out the " + baseCondimentName);
            Console.WriteLine("A depressing amount of liquid comes out instead of " + baseCondimentName);
            Console.WriteLine("You shake the bottle, and pour out a healthy dab of " + baseCondimentName);
        }
    }
}
