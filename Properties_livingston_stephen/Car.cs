using System;
using System.Collections.Generic;
using System.Text;

namespace Properties_livingston_stephen
{
    class Car // Assigns class type.
    {
        private string model; // Declares varaible as private.

        public string Model { get { return model; } set { model = value; } } // Sets model Property and Field.

        public string Make { get; set; } // Returns the variable and sets a value in a public string.
    }
}
