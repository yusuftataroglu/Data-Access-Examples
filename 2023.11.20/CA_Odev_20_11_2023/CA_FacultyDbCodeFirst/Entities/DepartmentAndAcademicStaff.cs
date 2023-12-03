using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_FacultyDbCodeFirst.Entities
{
    public class DepartmentAndAcademicStaff
    {
        public int AcademicStaffId { get; set; }
        public int DepartmentId { get; set; }

        //Mapping
        public AcademicStaff AcademicStaff { get; set; }
        public Department Department { get; set; }
    }
}
