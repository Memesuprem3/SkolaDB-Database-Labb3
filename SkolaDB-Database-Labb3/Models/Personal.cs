using System;
using System.Collections.Generic;

namespace SkolaDB_Database_Labb3.Models;

public partial class Personal
{
    public int Id { get; set; }

    public string? Namn { get; set; }

    public string? Pn { get; set; }

    public string? Tjänst { get; set; }

    public virtual ICollection<Betyg> Betygs { get; set; } = new List<Betyg>();

    public virtual ICollection<Klasser> Klassers { get; set; } = new List<Klasser>();

    public virtual ICollection<Kurser> Kursers { get; set; } = new List<Kurser>();
}
