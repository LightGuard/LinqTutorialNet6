using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercises
{
    public static class All
    {
        //Coding Exercise 1
        //Use LINQ to implement the AreAllNumbersDivisibleBy10 method,
        //which checks if all numbers in the collection are divisible by 10.
        public static bool AreAllNumbersDivisibleBy10(int[] numbers)
        {
            return numbers.All(number => number % 10 == 0);
        }

        //Coding Exercise 2
        //Using LINQ, implement the AreAllPetsOfTheSameType method that checks
        //if all Pets in the collection are of the same PetType.
        public static bool AreAllPetsOfTheSameType(IEnumerable<Pet> pets)
        {
            // Check if all the pet types are the same
            // This is done by getting all the possible pet types and checking
            // if all the pets that are passed in are of that type.
            // If any of them are not a false will be returned
            var petTypes = Enum.GetValues(typeof(PetType)).Cast<PetType>();
            return petTypes.Any(type => pets.All(pet => pet.PetType == type));
        }

        //Refactoring challenge
        public static bool AreAllWordsOfTheSameLength_Refactored(List<string> words)
        {
            return words.All(word => word.Length == words.First().Length);
        }

        //do not modify this method
        public static bool AreAllWordsOfTheSameLength(List<string> words)
        {
            if (words.Count == 0 || words.Count == 1)
            {
                return true;
            }
            var length0 = words[0].Length;
            for (int i = 1; i < words.Count; ++i)
            {
                if (words[i].Length != length0)
                {
                    return false;
                }
            }
            return true;
        }

        public enum PetType
        {
            Cat,
            Dog,
            Fish
        }

        public class Pet
        {
            public int Id { get; }
            public string Name { get; }
            public PetType PetType { get; }
            public float Weight { get; }

            public Pet(int id, string name, PetType petType, float weight)
            {
                Id = id;
                Name = name;
                PetType = petType;
                Weight = weight;
            }

            public override string ToString()
            {
                return $"Id: {Id}, Name: {Name}, Type: {PetType}, Weight: {Weight}";
            }
        }
    }
}
