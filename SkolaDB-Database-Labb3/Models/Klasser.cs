using System;
using System.Collections.Generic;

namespace SkolaDB_Database_Labb3.Models;

public partial class Klasser
{
    public int KlassId { get; set; }

    public string? KlassN { get; set; }

    public int? LärareId { get; set; }

    public virtual Personal? Lärare { get; set; }

    public virtual ICollection<Studenter> Studenters { get; set; } = new List<Studenter>();
}
