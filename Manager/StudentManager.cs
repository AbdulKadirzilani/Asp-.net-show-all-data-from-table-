using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tuto7.Gateway;
using Tuto7.Models;

namespace Tuto7.Manager
{
    public class StudentManager
    {

        StudentGateway studentGateway = new StudentGateway();

        public List<Student>GetStudents()
        {

            return studentGateway.GetStudents();
        }


    }
}
