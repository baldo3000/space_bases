using System;
using System.Collections.Generic;

namespace space_bases.SpaceBases;

public partial class Launch
{
    public string RocketName { get; set; } = null!;

    public int Sn { get; set; }

    public DateTime Date { get; set; }

    public int Altitude { get; set; }

    public string LaunchCost { get; set; } = null!;

    public int? PayloadWeight { get; set; }

    public string SellerAgencyAcronym { get; set; } = null!;

    public string? BuyerAgencyAcronym { get; set; }

    public string BaseName { get; set; } = null!;

    public int LaunchpadCode { get; set; }

    public virtual Agency? BuyerAgencyAcronymNavigation { get; set; }

    public virtual Launchpad Launchpad { get; set; } = null!;

    public virtual ProducedRocket ProducedRocket { get; set; } = null!;

    public virtual Agency SellerAgencyAcronymNavigation { get; set; } = null!;
}
