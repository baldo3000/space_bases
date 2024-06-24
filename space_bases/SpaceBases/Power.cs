using System;
using System.Collections.Generic;

namespace space_bases.SpaceBases;

public partial class Power
{
    public string EngineName { get; set; } = null!;

    public string RocketName { get; set; } = null!;

    public int Count { get; set; }

    public virtual Engine EngineNameNavigation { get; set; } = null!;

    public virtual Rocket RocketNameNavigation { get; set; } = null!;
}
