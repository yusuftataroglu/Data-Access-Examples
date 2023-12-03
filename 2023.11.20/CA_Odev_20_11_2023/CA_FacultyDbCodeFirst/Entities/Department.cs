using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace CA_FacultyDbCodeFirst.Entities
{
    public class Department
    {
        public int Id { get; set; }
        public string DepartmentName { get; set; }
        public int NumberOfStudent { get; set; }
        public int NumberOfAcademicStaff { get; set; }
        public short Year { get; set; }

        //Mapping
        public List<DepartmentAndAcademicStaff> DepartmentAndAcademicStaffs { get; set; }
        public List<DepartmentAndStudent> DepartmentAndStudents { get; set; }
        public List<AdministrativeStaff> AdministrativeStaffs { get; set; }


    }
}
