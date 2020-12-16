using System;
using System.Collections.Generic;
using System.Text;

namespace MoneyTracker
{
    class Person
    {
        public Person(string firstname, string lastname)
        {
            Firstname = firstname;
            Lastname = lastname;
        }
        public string Firstname { get; }
        public string Lastname { get; }
    }
}
