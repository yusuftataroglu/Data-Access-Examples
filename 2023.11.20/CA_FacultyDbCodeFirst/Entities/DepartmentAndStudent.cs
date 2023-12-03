using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_FacultyDbCodeFirst.Entities
{
    public class DepartmentAndStudent
    {
        public int DeparmantId { get; set; }
        public int StudentId { get; set; }

        public Department Department { get; set; }
        public Student Student { get; set; }

    }
}
