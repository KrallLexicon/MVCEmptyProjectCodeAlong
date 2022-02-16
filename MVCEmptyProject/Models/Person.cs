using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCEmptyProject.Models
{
    public class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }

        public static List<Person> listOfPeople = new List<Person>();
        public static int nextId { get; set; }
        public static void GeneratePeople()
        {
            listOfPeople = new List<Person> { new Person { Id = 1, FirstName = "Jonathan", LastName = "Krall", City = "Stenstorp" },
        new Person { Id = 2, FirstName = "Anders", LastName = "Andersson", City = "Anderstorp" },
        new Person { Id = 3, FirstName = "Anne", LastName = "Andersson", City = "Annelund" },
        new Person { Id = 4, FirstName = "Kim", LastName = "Kimsson", City = "Kimstad" } };
            nextId = listOfPeople.Count + 1;
        }
    }


}
