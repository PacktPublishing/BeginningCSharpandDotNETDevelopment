using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebCore5.Models
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public List<Person> GetList()
        {
            return new List<Person>() {
                new Person() { Name="Johnny", Age = 65 },
                new Person() { Name="Jeff", Age = 53}
            };
        }
    }

    public class Human
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public List<Person> GetList()
        {
            return new List<Person>() {
                new Person() { Name="Johnny", Age = 65 },
                new Person() { Name="Jeff", Age = 53}
            };
        }
    }

}
