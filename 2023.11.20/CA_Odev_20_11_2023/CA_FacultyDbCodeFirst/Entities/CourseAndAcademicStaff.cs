using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_FacultyDbCodeFirst.Entities
{
    public class CourseAndAcademicStaff
    {
        public int CourseId { get; set; }
        public int AcademicStaffId { get; set; }

        public Course Course { get; set; }
        public AcademicStaff AcademicStaff { get; set; }
    }
}
