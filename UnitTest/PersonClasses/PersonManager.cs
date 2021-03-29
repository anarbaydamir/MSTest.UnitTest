using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest.PersonClasses
{
    public class PersonManager
    {
        public Person CreatePerson(string firstName,string lastName,bool isSupervisor)
        {
            Person person = null;

            if (!string.IsNullOrEmpty(firstName))
            {
                if (isSupervisor)
                    person = new Supervisor();
                else
                    person = new Employee();

                person.FirstName = firstName;
                person.LastName = lastName;
            }
            return person;
        }

        public List<Person> GetPeople()
        {
            List<Person> people = new List<Person>();

            people.Add(new Person() { FirstName = "Anar", LastName = "Baydamirov" });
            people.Add(new Person() { FirstName = "Elmir", LastName = "Misha" });
            people.Add(new Person() { FirstName = "John", LastName = "Doe" });

            return people;
        }

        public List<Person> GetSupervisors()
        {
            List<Person> people = new List<Person>();

            people.Add(CreatePerson("Anar", "Baydamirov", true));
            people.Add(CreatePerson("Elmir", "Misha", true));

            return people;
        }

        public List<Person> GetEmployees()
        {
            List<Person> people = new List<Person>();

            people.Add(CreatePerson("John", "Doe", false));
            people.Add(CreatePerson("Chris", "Paul", false));
            people.Add(CreatePerson("Blake", "Griffin", false));

            return people;
        }

        public List<Person> GetSupervisorsAndEmployees()
        {
            List<Person> people = new List<Person>();

            people.AddRange(GetEmployees());
            people.AddRange(GetSupervisors());

            return people;
        }
    }
}
