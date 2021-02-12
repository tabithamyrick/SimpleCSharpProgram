using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleCSharpProgram
{
    class Drink // Drink Base Class Model
    {
        public string Name { get; set; }
        public bool Carbonated { get; set; }
        public virtual string Description { get; set; }

    }
}
