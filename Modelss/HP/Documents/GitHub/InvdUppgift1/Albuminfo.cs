using System;
using System.Collections.Generic;

namespace InvdUppgift1;

public partial class Albuminfo
{
    public int AlbumId { get; set; }

    public string? AlbumName { get; set; }

    public int? ReleaseYear { get; set; }

    public int? ArtistId { get; set; }

    public virtual Artistinfo? Artist { get; set; }

    public virtual ICollection<Trackinfo> Trackinfos { get; set; } = new List<Trackinfo>();
}
