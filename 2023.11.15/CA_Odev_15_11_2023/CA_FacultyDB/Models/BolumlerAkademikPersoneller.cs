using System;
using System.Collections.Generic;

namespace CA_FacultyDB.Models;

public partial class BolumlerAkademikPersoneller
{
    public int BölümId { get; set; }

    public int AkademikPersonelId { get; set; }

    public virtual AkademikPersoneller AkademikPersonel { get; set; } = null!;

    public virtual Bolumler Bölüm { get; set; } = null!;
}
