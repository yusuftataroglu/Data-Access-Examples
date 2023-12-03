using System;
using System.Collections.Generic;

namespace CA_FacultyDB.Models;

public partial class IdariPersoneller
{
    public int Id { get; set; }

    public int BölümId { get; set; }

    public string TcNo { get; set; } = null!;

    public string İsim { get; set; } = null!;

    public string Soyisim { get; set; } = null!;

    public string Pozisyon { get; set; } = null!;

    public DateTime? DoğumTarihi { get; set; }

    public string? DoğumYeri { get; set; }

    public string? TelNo { get; set; }

    public string? İkametgahAdresi { get; set; }

    public virtual Bolumler Bölüm { get; set; } = null!;
}
