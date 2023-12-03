using System;
using System.Collections.Generic;

namespace CA_FacultyDB.Models;

public partial class OgrencilerDersler
{
    public int ÖğrenciId { get; set; }

    public int DersId { get; set; }

    public virtual Dersler Ders { get; set; } = null!;

    public virtual Ogrenciler Öğrenci { get; set; } = null!;
}
