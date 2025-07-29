using Library_Management_System.back.classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System.back.Files
{
    public class PersonManagement
    {
        private static BindingList<Person> Persons;

        static PersonManagement()
        {
            Persons = FileUtils.LoadpersonsFromFile();
        }

        public static BindingList<Person> GetPersons()
        {
            return Persons;
        }

        public static void RemovePerson(Person p)
        {
            Persons.Remove(p);
        }

        public static void AddPerson(Person p)
        {
            Persons.Add(p);
        }
        public static BindingList<T> GetPersonByType<T>() where T : Person
        {
            BindingList<T> requestedPerson = new BindingList<T>();
            foreach (var person in Persons)
            {
                if (person is T)
                {
                    requestedPerson.Add(person as T);
                }
            }
            return requestedPerson;
        }

        public static void SavePersons()
        {
            FileUtils.SavepersonsToFile(Persons);
        }
    }
}
