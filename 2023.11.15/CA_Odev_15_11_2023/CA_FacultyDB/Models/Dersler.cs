using System;
using System.Collections.Generic;

namespace CA_FacultyDB.Models;

public partial class Dersler
{
    public int Id { get; set; }

    public string Dersİsmi { get; set; } = null!;

    public short Kredi { get; set; }

    public short Akts { get; set; }

    public short DersiAlanÖğrenciSayısı { get; set; }

    public short DersiVerenAkademikPersonelSayısı { get; set; }
}
