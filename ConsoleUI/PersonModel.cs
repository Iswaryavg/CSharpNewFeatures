using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    class PersonModel
    {
        public int Id { get; init; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public PersonModel()
        {

        }
        public PersonModel(int id, string firstName, string lastName)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;

        }
    }
}
