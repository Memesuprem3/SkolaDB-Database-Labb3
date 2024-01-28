using System;
using System.Collections.Generic;

namespace SkolaDB_Database_Labb3.Models;

public partial class Studenter
{
    public int StudentId { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string? Pn { get; set; }

    public int? KlassId { get; set; }

    public virtual ICollection<Betyg> Betygs { get; set; } = new List<Betyg>();

    public virtual Klasser? Klass { get; set; }
}
