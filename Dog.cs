using System;

namespace OopDemo
{
    /// <summary>
    /// Represents a Dog — a concrete implementation of Animal.
    /// Dogs cannot fly.
    /// </summary>
    public class Dog : Animal
    {
        /// <summary>
        /// Dogs bark — overrides the abstract MakeSound from Animal.
        /// </summary>
        public override void MakeSound()
        {
            Console.WriteLine($"{Name} says: Woof!");
        }
    }
}
