using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_FacultyDbCodeFirst.Entities
{
    public class Course
    {
        public int Id { get; set; }
        public string CourseName { get; set; }
        public short Credit { get; set; }
        public short Ects { get; set; }
        public int NumberOfStudent { get; set; }
        public int NumberOfAcademicStaff { get; set; }

        //Mapping
        public List<CourseAndAcademicStaff> CourseAndAcademicStaffs { get; set; }
        public List<CourseAndStudent> CourseAndStudents { get; set; }

    }
}
