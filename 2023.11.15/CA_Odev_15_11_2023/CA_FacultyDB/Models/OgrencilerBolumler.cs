using System;
using System.Collections.Generic;

namespace CA_FacultyDB.Models;

public partial class OgrencilerBolumler
{
    public int? ÖğrenciId { get; set; }

    public int? BölümId { get; set; }

    public virtual Bolumler? Bölüm { get; set; }

    public virtual Ogrenciler? Öğrenci { get; set; }
}
