using System;
using System.Collections.Generic;

namespace space_bases.SpaceBases;

public partial class Rocket
{
    public string RocketName { get; set; } = null!;

    public int FueledWeight { get; set; }

    public int Height { get; set; }

    public int Width { get; set; }

    public int Stages { get; set; }

    public int MaxAltitude { get; set; }

    public int MaxLaunches { get; set; }

    public string TrajectoryType { get; set; } = null!;

    public string AgencyAcronym { get; set; } = null!;

    public virtual Agency AgencyAcronymNavigation { get; set; } = null!;

    public virtual ICollection<Power> Powers { get; set; } = new List<Power>();

    public virtual ICollection<ProducedRocket> ProducedRockets { get; set; } = new List<ProducedRocket>();
}
