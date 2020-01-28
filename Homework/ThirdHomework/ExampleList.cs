using System;
using System.Collections.Generic;

namespace ThirdHomework
{
    class ExampleList
    {
        public void CreatingAndAdding()
        {
            List<Person> people = new List<Person>()
            { new Person { Name = "Bob", Age = 18, PhoneNumbers = new[] { "123","321" } },
              new Person { Name = "John", Age = 19, PhoneNumbers = new[] { "213","231" } },
              new Person { Name = "David", Age = 20, PhoneNumbers = new[] { "321","312" } },
              new Person { Name = "Volodymyr", Age = 34, PhoneNumbers = new[] { "1234","3210" } },
              new Person { Name = "Slavko", Age = 8, PhoneNumbers = new[] { "0123","4321" } }
            };
            foreach (var i in people)
                Console.WriteLine(i.Name + "  " + i.Age);
            people.AddRange(new Person[] {
                new Person { Name = "Roman", Age = 31, PhoneNumbers = new[] { "999","888" } },
              new Person { Name = "Max", Age = 12, PhoneNumbers = new[] { "666","667" } }});
            foreach (var i in people)
            {
                foreach (var j in i.PhoneNumbers)
                    Console.Write(j + " ");
                Console.WriteLine();
            }
        }
    }
}
