using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_FacultyDbCodeFirst.Entities
{
    public class SocialClub
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime FoundationDate { get; set; }
        public short NumberOfMember { get; set; }
        public string Description { get; set; }

        //Mapping
        public List<SocialClubAndStudent> SocialClubAndStudents { get; set; }

    }
}
