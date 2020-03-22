using System.Collections;
using System.Collections.Generic;
using tut_apdb3.Models;

namespace tut_apdb3.DAL
{
    public interface IDbService
    {
        public IEnumerable<Student> GetStudents();
    }
}