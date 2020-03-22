using System.Collections.Generic;
using tut_apdb3.Models;

namespace tut_apdb3.DAL
{
    public class MockDbService : IDbService
    {
        private static  List<Student> _students;

        static MockDbService()
        {
            _students = new List<Student>
            {
                new Student {IdStudent = 1, FirstName = "Jan", LastName = "Kowalski"},
                new Student {IdStudent = 2, FirstName = "Pan", LastName = "fas"},
                new Student {IdStudent = 3, FirstName = "an", LastName = "fjkasd"}
            };
        }

        public IEnumerable<Student> GetStudents()
        {
            return _students;
        }
    }
}