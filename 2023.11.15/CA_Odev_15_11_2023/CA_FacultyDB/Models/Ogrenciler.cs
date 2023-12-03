using System;
using System.Collections.Generic;

namespace CA_FacultyDB.Models;

public partial class Ogrenciler
{
    public int Id { get; set; }

    public string? TcNo { get; set; }

    public string İsim { get; set; } = null!;

    public string Soyisim { get; set; } = null!;

    public string? ÖğrenciNo { get; set; }

    public DateTime? DoğumTarihi { get; set; }

    public string? DoğumYeri { get; set; }

    public string? TelNo { get; set; }

    public string? İkametgahAdresi { get; set; }
}
