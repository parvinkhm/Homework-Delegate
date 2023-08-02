using Homeworkk.Models;
using Homeworkk.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homeworkk.Service
{
    internal class PersonService : IPersonService
    {
        
        public List<Person> GetAll()
        {
            List<Person> list = new List<Person>();

            list.Add(new Person { Id = 1, Name = "Azer", Surname = "Ismayilov", Address = "Genclik", Salary = 700 });
            list.Add(new Person { Id = 2, Name = "Ruslan", Surname = "Memmedov", Address = "Xalqlar",Salary = 900 });
            list.Add(new Person { Id = 3, Name = "Ilkin", Surname = "Agayev", Address = "Nerimanov", Salary = 1500 });
            list.Add(new Person { Id = 4, Name = "Cavid", Surname = "Isgenderov", Address = "Bayil", Salary = 1200 });

            return list;
                
        }

        public List<Person> FilterBySalary(decimal firstSalary,  List<Person> persons)
        {
            return persons.FindAll(m => m.Salary > firstSalary);
        }

       
    }
}
