using System;
using System.Collections.Generic;

namespace space_bases.SpaceBases;

public partial class Basis
{
    public string BaseName { get; set; } = null!;

    public string Acronym { get; set; } = null!;

    public string Nation { get; set; } = null!;

    public string City { get; set; } = null!;

    public string? AgencyAcronym { get; set; }

    public virtual Agency? AgencyAcronymNavigation { get; set; }

    public virtual ICollection<Launchpad> Launchpads { get; set; } = new List<Launchpad>();
}
