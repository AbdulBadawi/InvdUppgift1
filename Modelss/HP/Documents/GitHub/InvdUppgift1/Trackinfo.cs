using System;
using System.Collections.Generic;

namespace InvdUppgift1;

public partial class Trackinfo
{
    public int TrackId { get; set; }

    public string? Title { get; set; }

    public int? TrackNumber { get; set; }

    public int? AlbumId { get; set; }

    public virtual Albuminfo? Album { get; set; }
}
