using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCEmptyProject.Models
{
    public class PersonModel
    {
        public static string Check(string name, int age)
        {         

            if (age >= 18)
                return name + " is " + age + " years old and thus allowed to vote!";
            else
               return name + " is " + age + " years old and thus NOT allowed to vote!";           
        }

        public string Name { get; set; }
        public int Age { get; set; }
    }
}
