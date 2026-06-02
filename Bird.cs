using System;

namespace OopDemo
{
    /// <summary>
    /// Represents a Bird — extends Animal and implements IFlyable.
    /// Demonstrates multiple interface implementation.
    /// </summary>
    public class Bird : Animal, IFlyable
    {
        /// <summary>
        /// Birds tweet — overrides the abstract MakeSound from Animal.
        /// </summary>
        public override void MakeSound()
        {
            Console.WriteLine($"{Name} says: Tweet!");
        }

        /// <summary>
        /// Birds can fly — fulfills the IFlyable contract.
        /// </summary>
        public void Fly()
        {
            Console.WriteLine($"{Name} is soaring through the sky!");
        }
    }
}
