using System;
using System.Collections.Generic;

namespace space_bases.SpaceBases;

public partial class ProducedRocket
{
    public string RocketName { get; set; } = null!;

    public int Sn { get; set; }

    public DateTime ProductionDate { get; set; }

    public int FlightsExecuted { get; set; }

    public virtual ICollection<Launch> Launches { get; set; } = new List<Launch>();

    public virtual Rocket RocketNameNavigation { get; set; } = null!;
}
