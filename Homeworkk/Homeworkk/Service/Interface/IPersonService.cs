using Homeworkk.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homeworkk.Service.Interface
{
    internal interface IPersonService
    {

        List<Person> GetAll();
        List<Person> FilterBySalary(decimal firstSalary, List<Person> persons);
    }
}
