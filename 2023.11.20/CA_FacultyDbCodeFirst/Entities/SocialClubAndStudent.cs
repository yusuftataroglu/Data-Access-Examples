using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_FacultyDbCodeFirst.Entities
{
    public class SocialClubAndStudent
    {
        public int SocialClubId { get; set; }
        public int StudentId { get; set; }

        public SocialClub SocialClub { get; set; }
        public Student Student { get; set; }

    }
}
