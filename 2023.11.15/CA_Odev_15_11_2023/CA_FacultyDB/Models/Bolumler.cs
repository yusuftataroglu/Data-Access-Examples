using System;
using System.Collections.Generic;

namespace CA_FacultyDB.Models;

public partial class Bolumler
{
    public int Id { get; set; }

    public string Bölümİsmi { get; set; } = null!;

    public int ÖğrenciSayısı { get; set; }

    public int AkademikPersonelSayısı { get; set; }

    public short Süre { get; set; }

    public virtual ICollection<IdariPersoneller> IdariPersonellers { get; set; } = new List<IdariPersoneller>();
}
