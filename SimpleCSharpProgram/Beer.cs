using System;
using System.Collections.Generic;
using System.Text;


namespace SimpleCSharpProgram
{

    class Beer : Drink // Inheriting from Drink base class
    {
        //Private fields to use for Descritpion value
        private string CarbonatedString;
        private double AlcoholByVol;

        public Beer(string name, bool carbonation, double alcoholByVolume)
        {
            // Setting fields inheritated from the Drink Class
            Name = name;
            Carbonated = carbonation;
            AlcoholByVol = alcoholByVolume;
            
        }

        //Description Property override for specified class requirements
        public override string Description
        {
            get // if else to set the string based on the bool value of carbonation
            {
                if (Carbonated)
                {
                    CarbonatedString = "Carbonated";
                }
                else
                {
                    CarbonatedString = "Not Carbonated";
                }

                // String vars for ease of formating and concatonation 
                String ABVString = (String.Format("{0:P2}", AlcoholByVol).Replace(" %", "%") + " ABV");
                String ReturnString = CarbonatedString + ", " + ABVString;

                return (ReturnString);
            }
            set
            {
                Description = value;
            }
        }
    }
}