using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_FacultyDbCodeFirst.Entities
{
    public class AcademicStaff
    {
        public int Id { get; set; }
        public string TrNo { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Title { get; set; }
        public string Field { get; set; }
        public string StaffNo { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string PlaceOfBirth { get; set; }
        public string PhoneNumber { get; set; }
        public string Adress { get; set; }
        
        //Mapping
        public List<DepartmentAndAcademicStaff> DepartmentAndAcademicStaffs { get; set; }
        public List<CourseAndAcademicStaff> CourseAndAcademicStaffs { get; set; }
    }
}
