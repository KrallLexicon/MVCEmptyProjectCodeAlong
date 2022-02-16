using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVCEmptyProject.Models
{
    public class Person
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Display(Name ="First name")]
        public string FirstName { get; set; }
        [Required]
        [Display(Name = "Last name")]
        public string LastName { get; set; }
        [Required]
        public string City { get; set; }
        public int Age { get; set; }

        public List<CarOwner> CarOwners { get; set; }




        //public static List<Person> listOfPeople = new List<Person>();
        //public static int nextId { get; set; }
        //public static void GeneratePeople()
        //{
        //    listOfPeople = new List<Person> { new Person { Id = 1, FirstName = "Jonathan", LastName = "Krall", City = "Stenstorp" },
        //new Person { Id = 2, FirstName = "Anders", LastName = "Andersson", City = "Anderstorp" },
        //new Person { Id = 3, FirstName = "Anne", LastName = "Andersson", City = "Annelund" },
        //new Person { Id = 4, FirstName = "Kim", LastName = "Kimsson", City = "Kimstad" } };
        //    nextId = listOfPeople.Count + 1;
        //}
    }


}
