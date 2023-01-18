using System;

namespace Properties_livingston_stephen
{
    class Program // Assigns class type.
    {
        static void Main(string[] args) // Main Method.
        {
            Car car = new Car(); // Creates new Object.
            car.Make = "Ford";  // Assigns Car Object Make.
            car.Model = "Mustang"; // Assigns Car Object Model.

            Console.WriteLine($"Make: {car.Make}, Model: {car.Model}"); // Prints the Make and Model to the console.

            Car car2 = new Car(); // Creates new Object.
            car2.Make = "Chevy"; // Assigns car2 object Make.
            car2.Model = "Camero"; // Assigns car2 obeject Model.
            Console.WriteLine($"Make: {car2.Make}, Model: {car2.Model}"); // Prints car2 Make and Model to the console.

            


        }
    }
}
