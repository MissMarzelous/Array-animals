using System;
using System.Collections.Generic;

namespace OopDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== OOP Demo: Polymorphism, Abstract Classes & Interfaces ===\n");

            // Polymorphism: store different types in a base class collection
            List<Animal> animals = new List<Animal>
            {
                new Dog { Name = "Rex"    },
                new Bird { Name = "Tweety" },
                new Dog { Name = "Buddy"  },
                new Bird { Name = "Polly" }
            };

            foreach (Animal animal in animals)
            {
                // Polymorphic calls — the correct override is invoked at runtime
                animal.Describe();
                animal.MakeSound();

                // Interface check — only IFlyable objects can fly
                if (animal is IFlyable flyingAnimal)
                {
                    flyingAnimal.Fly();
                }
                else
                {
                    Console.WriteLine($"{animal.Name} cannot fly.");
                }

                Console.WriteLine();
            }
        }
    }
}
