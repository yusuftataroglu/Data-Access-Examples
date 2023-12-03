using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_FacultyDbCodeFirst.Entities
{
    public class AdministrativeStaff
    {
        public int Id { get; set; }
        public string TrNo { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Title { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string PlaceOfBirth { get; set; }
        public string PhoneNumber { get; set; }
        public string Adress { get; set; }

        //Mapping
        public int DepartmentId { get; set; }
        public Department Department { get; set; }

    }
}
