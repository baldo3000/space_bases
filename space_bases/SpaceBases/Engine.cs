using System;
using System.Collections.Generic;

namespace space_bases.SpaceBases;

public partial class Engine
{
    public string EngineName { get; set; } = null!;

    public int Thrust { get; set; }

    public int ChamberPressure { get; set; }

    public bool Throttleable { get; set; }

    public string Fuel { get; set; } = null!;

    public string Oxidizer { get; set; } = null!;

    public string AgencyAcronym { get; set; } = null!;

    public virtual Agency AgencyAcronymNavigation { get; set; } = null!;

    public virtual ICollection<Power> Powers { get; set; } = new List<Power>();
}
