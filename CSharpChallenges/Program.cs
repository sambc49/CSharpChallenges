using System;
using System.Collections.Generic;

namespace CSharpChallenges
{
    class Program
    {
        static void Main(string[] args)
        {
            var users = new List<User>
            {
                new User { FirstName = "Dave", Surname = "Thomas" },
                new User { FirstName = "Joe", Surname = "Bloggs" }
            };
            foreach (var user in users)
            {
                Console.WriteLine("Hello! My name is {0} {1}", user.FirstName, user.Surname);
            }


        }
    }
}
