﻿using System;
using System.Collections.Generic;

namespace CA_ImdbDataDbFirst.Models;

public partial class Genre
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public virtual ICollection<Movie> Movies { get; set; } = new List<Movie>();
}
