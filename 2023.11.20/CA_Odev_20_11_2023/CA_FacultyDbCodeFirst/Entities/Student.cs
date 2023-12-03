using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_FacultyDbCodeFirst.Entities
{
    public class Student
    {
        public int Id { get; set; }
        public string TrNo { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string StudentNo { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string PlaceOfBirth { get; set; }
        public string PhoneNumber { get; set; }
        public string Adress { get; set; }

        //Mapping
        public List<CourseAndStudent> CourseAndStudents { get; set; }
        public List<DepartmentAndStudent> DepartmentAndStudents { get; set; }
        public List<SocialClubAndStudent> SocialClubAndStudents { get; set; }

    }
}
