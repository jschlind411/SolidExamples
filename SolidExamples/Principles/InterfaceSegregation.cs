using SolidExamples.Principles.CondimentBottleTypeStrategies;
using System;
using System.Collections.Generic;

namespace SolidExamples.Principles
{
    public interface Condiment
    {
        void Spread();

        List<string> ReturnIngredients();
    }

    public interface Lid
    {
        void OpenLid();
        void CloseLid();
    }

    public interface PlasticContainer : Lid
    {
        void Squeeze();
    }

    public interface GlassContainer : Lid
    {
        void Scoop();
        void Pour();
    }

    public class InterfaceSegregation
    {
        public class Mustard : Condiment
        {
            public void Spread()
            {
                throw new NotImplementedException();
            }

            public List<string> ReturnIngredients()
            {
                return new List<string>()
                {
                    "Water",
                    "Mustard Seed Powder",                    
                };
            }

            public override string ToString()
            {
                return "Mustard";
            }
        }

        public class GlassBottleOfMustard : Mustard, GlassContainer
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
                return "Glass Bottle Mustard";
            }
        }

        public class PlasticBottleOfMustard : Mustard, PlasticContainer
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
                return "Plastic Bottle Mustard";
            }
        }
    }
}
