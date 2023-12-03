using System;
using System.Collections.Generic;

namespace CA_BarbutBankaDbFirst.Models;

public partial class User
{
    public int Id { get; set; }

    public string Firstname { get; set; } = null!;

    public string Lastname { get; set; } = null!;

    public string Username { get; set; } = null!;

    public string Password { get; set; } = null!;

    public decimal Balance { get; set; }

    public virtual ICollection<PlayedGame> PlayedGames { get; set; } = new List<PlayedGame>();
}
