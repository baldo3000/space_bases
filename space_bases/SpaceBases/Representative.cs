using System;
using System.Collections.Generic;

namespace space_bases.SpaceBases;

public partial class Representative
{
    public string Name { get; set; } = null!;

    public string Surname { get; set; } = null!;

    public DateTime Birthday { get; set; }

    public string Id { get; set; } = null!;

    public int Phone { get; set; }

    public string City { get; set; } = null!;

    public string Email { get; set; } = null!;

    public virtual ICollection<Agency> Agencies { get; set; } = new List<Agency>();
}
