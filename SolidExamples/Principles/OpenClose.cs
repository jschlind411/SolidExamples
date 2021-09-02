using SolidExamples.Principles;
using SolidExamples.Principles.CondimentBottleTypeStrategies;
using System;
using System.Collections.Generic;

namespace SolidExamples
{
    public class OpenClose
    {
        public class Ketchup : Condiment
        {
            public void Spread()
            {
                throw new NotImplementedException();
            }

            public virtual List<string> ReturnIngredients()
            {
                List<string> Ingredients = new List<string>()
                {
                    "Tomatoes",
                    "Salt",
                    "Sugar"
                };

                return Ingredients;
            }

            public override string ToString()
            {
                return "Ketchup!";
            }
        }

        public class GlassBottle : GlassContainer
        {
            private Condiment Contents { get; set; }

            public GlassBottle(Condiment content)
            {
                Contents = content;
            }

            public void CloseLid()
            {
                Console.WriteLine("You close this lid on the glass jar of " + Contents.ToString());
            }

            public void OpenLid()
            {
                Console.WriteLine("You take the lid off the glass jar of " + Contents.ToString());
            }

            public void Pour()
            {
                throw new NotImplementedException();
            }

            public void Scoop()
            {
                throw new NotImplementedException();
            }
        }

        public class GlassBottleOfKetchup : Ketchup, GlassContainer
        {
            public void CloseLid()
            {
                throw new NotImplementedException();
            }

            public void OpenLid()
            {
                throw new NotImplementedException();
            }

            public void Pour()
            {
                throw new NotImplementedException();
            }

            public void Scoop()
            {
                throw new NotImplementedException();
            }

            public override string ToString()
            {
                return "Glass Bottle of Ketchup";
            }
        }

        public class PlasticBottleOfKetchup : Ketchup, PlasticContainer
        {
            public void CloseLid()
            {
                throw new NotImplementedException();
            }

            public void OpenLid()
            {
                throw new NotImplementedException();
            }

            public void Squeeze()
            {
                throw new NotImplementedException();
            }

            public override string ToString()
            {
                return "Plastic Bottle of Ketchup";
            }
        }

        public class SpicyKetchup : Ketchup 
        {
            public override List<string> ReturnIngredients()
            {
                var list = base.ReturnIngredients();
                list.Add("Chili Powder");
                return list;
            }

            public override string ToString()
            {
                return "Spicy Ketchup";
            }
        }

        public class GlassBottleOfSpicyKetchup : SpicyKetchup, GlassContainer
        {
            public void CloseLid()
            {
                throw new NotImplementedException();
            }

            public void OpenLid()
            {
                throw new NotImplementedException();
            }

            public void Pour()
            {
                throw new NotImplementedException();
            }

            public void Scoop()
            {
                throw new NotImplementedException();
            }

            public override string ToString()
            {
                return "Glass Bottle of " + base.ToString();
            }
        }

        public class PlasticBottleOfSpicyKetchup : SpicyKetchup, PlasticContainer
        {
            public void CloseLid()
            {
                PlasticBottleStrategies.CloseNormalPlasticBottle(ToString());
            }

            public void OpenLid()
            {
                PlasticBottleStrategies.OpenNormalPlasticBottle(ToString());
            }

            public void Squeeze()
            {
                PlasticBottleStrategies.SqueezeNormalPlasticBottle(base.ToString());
            }

            public override string ToString()
            {
                return "Plastic Bottle of " + base.ToString();
            }
        }

        public class SugarFreeKetchup : Ketchup
        {
            public override List<string> ReturnIngredients()
            {
                var list = base.ReturnIngredients();
                list.Remove("Sugar");
                return list;
            }

            public override string ToString()
            {
                return "SugarFree Ketchup";
            }
        }

        public class GlassBottleOfSugarFreeKetchup : SugarFreeKetchup, GlassContainer
        {
            public void CloseLid()
            {
                throw new NotImplementedException();
            }

            public void OpenLid()
            {
                throw new NotImplementedException();
            }

            public void Pour()
            {
                throw new NotImplementedException();
            }

            public void Scoop()
            {
                throw new NotImplementedException();
            }

            public override string ToString()
            {
                return "Glass Bottle of " + base.ToString();
            }
        }

        public class PlasticBottleOfSugarFreeKetchup : SugarFreeKetchup, PlasticContainer
        {
            public void CloseLid()
            {
                PlasticBottleStrategies.CloseNormalPlasticBottle(ToString());
            }

            public void OpenLid()
            {
                PlasticBottleStrategies.OpenNormalPlasticBottle(ToString());
            }

            public void Squeeze()
            {
                PlasticBottleStrategies.SqueezeUnShakenPlasticBottle(base.ToString());
            }

            public override string ToString()
            {
                return "Plastic Bottle of " + base.ToString();
            }
        }
    }
}
