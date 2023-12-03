using System;
using System.Collections.Generic;

namespace CA_FacultyDB.Models;

public partial class SosyalKulupler
{
    public int Id { get; set; }

    public string İsmi { get; set; } = null!;

    public DateTime? KuruluşTarihi { get; set; }

    public short ÜyeSayısı { get; set; }

    public string? Açıklama { get; set; }
}
