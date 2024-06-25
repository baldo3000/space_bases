using System;
using System.Collections.Generic;

namespace space_bases.SpaceBases;

public partial class Launchpad
{
    public string BaseName { get; set; } = null!;

    public string LaunchpadName { get; set; } = null!;

    public int LaunchpadCode { get; set; }

    public int WeightCapacity { get; set; }

    public DateTime ConstructionDate { get; set; }

    public int LaunchesHosted { get; set; }

    public bool Active { get; set; }

    public virtual Base BaseNameNavigation { get; set; } = null!;

    public virtual ICollection<Launch> Launches { get; set; } = new List<Launch>();
}
