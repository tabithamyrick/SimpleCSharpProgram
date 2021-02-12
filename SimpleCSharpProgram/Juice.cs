using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleCSharpProgram
{
    class Juice : Drink// Inheriting from Drink base class
    {
        //Private fields to use for Descritpion value
        private string CarbonatedString;
        public Juice(string name, bool carbonation)
        {
           Name = name + " Juice";
           Carbonated = carbonation;
            madeFrom = name + "s";
            
        }
        
        private string madeFrom { get; set; }
        //Description Property override for specified class requirements
        public override string Description
        {
            get // if else to set the string based on the bool value of carbonation
            {
                if (Carbonated)
                {
                    CarbonatedString = "Carbinated";
                }
                else
                {
                    CarbonatedString = "Not Carbinated";
                }

                String ReturnString = CarbonatedString + ", Made from " + madeFrom;

                return (ReturnString);
            }
            set
            {
                Description = value;
            }
        }
    }
}

