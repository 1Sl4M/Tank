using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeModule7
{
    public class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person
            {
                FirstName = "John",
                LastName = "Doe",
                Age = 30
            };

            Person person2 = new Person
            {
                FirstName = "Jane",
                LastName = "Doe",
                Age = 28
            };

            bool areEqual = person1 == person2;
            bool areNotEqual = person1 != person2;

            Console.WriteLine("Are persons equal: " + areEqual);
            Console.WriteLine("Are persons not equal: " + areNotEqual);

            bool areEqualWithEquals = person1.Equals(person2);
            Console.WriteLine("Are persons equal using Equals method: " + areEqualWithEquals);
            
            Console.ReadLine();
        }
    }
    
}

public class Person
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }

    public override bool Equals(object obj)
    {
        if (obj == null || GetType() != obj.GetType())
            return false;

        Person other = (Person)obj;
        return FirstName == other.FirstName && LastName == other.LastName && Age == other.Age;
    }

    public override int GetHashCode()
    {
        unchecked
        {
            int hash = 17;
            hash = hash * 23 + (FirstName?.GetHashCode() ?? 0);
            hash = hash * 23 + (LastName?.GetHashCode() ?? 0);
            hash = hash * 23 + Age.GetHashCode();
            return hash;
        }
    }

    public static bool operator ==(Person person1, Person person2)
    {
        if (ReferenceEquals(person1, null))
            return ReferenceEquals(person2, null);
        return person1.Equals(person2);
    }

    public static bool operator !=(Person person1, Person person2)
    {
        return !(person1 == person2);
    }
}