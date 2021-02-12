using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleCSharpProgram
{
    class Soda : Drink // Inheriting from Drink base class
    {
        //Private field to use for Descritpion value
        private string CarbonatedString;
        public Soda(string name, bool carbonation)
        {
            Name = name;
            Carbonated = carbonation;
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

                return (CarbonatedString);
            }
            set
            {
                Description = value;
            }
        }
    }
}
