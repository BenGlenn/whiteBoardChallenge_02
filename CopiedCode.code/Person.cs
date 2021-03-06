﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetHub.code
{
    class Person
    { // Properties: First Name, Last Name, Full Name, Date Of Birth, Age
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName
        {
            get
            {
                string fullName = $"{FirstName} {LastName}";
                return fullName;
            }
        }

        public DateTime DateOfBirth { get; set; }
        public int Age
        {
            get
            {
                // Take the DateOfBirth and figure how long it's been since then
                TimeSpan ageSpan = DateTime.Now - DateOfBirth;
                // Calculate our age based off the TimeSpan
                double totalAgeInYears = ageSpan.TotalDays / 365.25;
                // Convert our double years into an int
                int yearsOfAge = Convert.ToInt32(Math.Floor(totalAgeInYears));
                return yearsOfAge;
            }
        }

        public Vehicle Transport { get; set; }



        // 1. Access Modifier => public, internal, private for example
        // 2. Return Type => The output from the method
        // 3. Method signature => Name and parameters (input)
        // 4. Body of the code => Logic/Code that gets executed when the method runs
        //1     //2     //3
        public void SayHello()
        {
            Console.WriteLine($"Hello, my name is {FirstName}.");
        }

        public void SayHello(string name)
        {
            Console.WriteLine($"Hello {name}, my name is {FirstName}.");
        }

        public void SayHello(Person person)
        {
            Console.WriteLine($"Hello {person.FullName}, my name is {FirstName}.");
        }
    }
}
