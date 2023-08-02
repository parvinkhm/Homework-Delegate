using Homeworkk.Models;
using Homeworkk.Service;
using Homeworkk.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homeworkk
{
    internal class PersonController
    {
        private readonly IPersonService _personService;

        public PersonController()
        {
            _personService = new PersonService();
        }


        public void GetAll()
        {
            var persons = _personService.GetAll();
            foreach (var person in persons)
            {
                string result = $"{person.Id}  -  {person.Name} - {person.Surname} - {person.Address} - {person.Salary}";
                Console.WriteLine(result);
            }
        }


        public void FilterByPrice()
        {
            decimal first = 1000;

            List<Person> persons = _personService.GetAll();

            var filteredPersons = _personService.FilterBySalary(first,  persons);
            {
                foreach (var person in filteredPersons)
                {
                    string result = $"{person.Id}  -  {person.Name} - {person.Surname} - {person.Address}";
                    Console.WriteLine(result);
                }
            }

        }
    }
}
