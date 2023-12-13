using System;
using System.Collections.Generic;

namespace CA_BarbutBankaDbFirst.Models;

public partial class PlayedGame
{
    public int Id { get; set; }

    public DateTime PlayedDate { get; set; }

    public int UserId { get; set; }

    public int PlayerScore { get; set; }

    public int PcScore { get; set; }

    public virtual User User { get; set; } = null!;
}
