using System;
using System.Collections.Generic;

namespace InvdUppgift1;

public partial class Artistinfo
{
    public int ArtistId { get; set; }

    public string? ArtistName { get; set; }

    public string? Description { get; set; }

    public virtual ICollection<Albuminfo> Albuminfos { get; set; } = new List<Albuminfo>();
}
