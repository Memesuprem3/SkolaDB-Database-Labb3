using System;
using System.Collections.Generic;

namespace SkolaDB_Database_Labb3.Models;

public partial class Betyg
{
    public int BetygId { get; set; }

    public int? StudentId { get; set; }

    public int? KursId { get; set; }

    public int? LarareId { get; set; }

    public string? Betyg1 { get; set; }

    public DateOnly? Datum { get; set; }

    public virtual Kurser? Kurs { get; set; }

    public virtual Personal? Larare { get; set; }

    public virtual Studenter? Student { get; set; }
}
