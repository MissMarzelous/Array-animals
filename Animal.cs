using System;

namespace OopDemo
{
    /// <summary>
    /// Abstract base class representing a generic animal.
    /// All animals have a Name and must implement MakeSound().
    /// </summary>
    public abstract class Animal
    {
        /// <summary>Gets or sets the animal's name.</summary>
        public string Name { get; set; }

        /// <summary>
        /// Abstract method — every derived class must provide
        /// its own sound implementation.
        /// </summary>
        public abstract void MakeSound();

        /// <summary>
        /// Displays a summary of the animal using polymorphism.
        /// </summary>
        public virtual void Describe()
        {
            Console.WriteLine($"Animal: {Name} ({GetType().Name})");
        }
    }
}
