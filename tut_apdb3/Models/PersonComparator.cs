using System;
using System.Collections.Generic;

namespace tut_apdb3.Models
{
    public class PersonComparator: IEqualityComparer<Student>
    {
        public bool Equals(Student x, Student y)
        {
            return StringComparer
                .InvariantCultureIgnoreCase
                .Equals($"{x.IdStudent}",
                    $"{y.IdStudent}");
        }

        public int GetHashCode(Student obj)
        {
            return StringComparer.CurrentCultureIgnoreCase
                .GetHashCode($"{obj.IdStudent}");
        }
    }
}
