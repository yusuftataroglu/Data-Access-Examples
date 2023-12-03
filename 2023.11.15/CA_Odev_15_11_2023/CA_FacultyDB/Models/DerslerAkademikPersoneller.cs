using System;
using System.Collections.Generic;

namespace CA_FacultyDB.Models;

public partial class DerslerAkademikPersoneller
{
    public int DersId { get; set; }

    public int AkademikPersonelId { get; set; }

    public virtual AkademikPersoneller AkademikPersonel { get; set; } = null!;

    public virtual Dersler Ders { get; set; } = null!;
}
