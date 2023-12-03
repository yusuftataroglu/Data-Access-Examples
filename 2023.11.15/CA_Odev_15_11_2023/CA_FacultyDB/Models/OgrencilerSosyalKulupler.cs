using System;
using System.Collections.Generic;

namespace CA_FacultyDB.Models;

public partial class OgrencilerSosyalKulupler
{
    public int ÖğrenciId { get; set; }

    public int SosyalKulüpId { get; set; }

    public virtual SosyalKulupler SosyalKulüp { get; set; } = null!;

    public virtual Ogrenciler Öğrenci { get; set; } = null!;
}
