using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp10FundamentalsExercises
{
    internal class Person
    {
        private string name;
        private int age;
        private string address;

        // Constructor
        public Person(string initialName, int initialAge, string initialAddress)
        {
            name = initialName;
            age = initialAge;
            address = initialAddress;
        }

        // Public methods for getting and setting name
        public string GetName()
        {
            return name;
        }

        public void SetName(string newName)
        {
            name = newName;
        }

        // Public methods for getting and setting age
        public int GetAge()
        {
            return age;
        }

        public void SetAge(int newAge)
        {
            age = newAge;
        }

        // Public methods for getting and setting address
        public string GetAddress()
        {
            return address;
        }

        public void SetAddress(string newAddress)
        {
            address = newAddress;
        }
    }
}
