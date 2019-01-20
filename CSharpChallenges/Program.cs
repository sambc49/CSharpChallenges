using System;
using System.Collections.Generic;

namespace CSharpChallenges
{
    class Program
    {
        static void Main(string[] args)
        {
            var names = new List<string>()
            {
                "Sam",
                "Dave",
                "Bob",
                "Robert",
                "James"
            };
            foreach (var name in names)
            {
                Console.WriteLine("My name is {0}", name);
            }

        }
    }
}
