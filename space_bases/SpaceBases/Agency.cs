using System;
using System.Collections.Generic;

namespace space_bases.SpaceBases;

public partial class Agency
{
    public string AgencyName { get; set; } = null!;

    public string Acronym { get; set; } = null!;

    public DateTime FoundationDate { get; set; }

    public string Email { get; set; } = null!;

    public string Password { get; set; } = null!;

    public string HeadquarterNation { get; set; } = null!;

    public string HeadquarterCity { get; set; } = null!;

    public bool SpaceAgency { get; set; }

    public string RepresentativeId { get; set; } = null!;

    public virtual ICollection<Base> Bases { get; set; } = new List<Base>();

    public virtual ICollection<Engine> Engines { get; set; } = new List<Engine>();

    public virtual ICollection<Launch> LaunchBuyerAgencyAcronymNavigations { get; set; } = new List<Launch>();

    public virtual ICollection<Launch> LaunchSellerAgencyAcronymNavigations { get; set; } = new List<Launch>();

    public virtual Representative Representative { get; set; } = null!;

    public virtual ICollection<Rocket> Rockets { get; set; } = new List<Rocket>();
}
