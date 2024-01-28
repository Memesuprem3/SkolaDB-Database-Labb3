using System;
using System.Collections.Generic;

namespace SkolaDB_Database_Labb3.Models;

public partial class Kurser
{
    public int KursId { get; set; }

    public string? KursN { get; set; }

    public int? LärareId { get; set; }

    public virtual ICollection<Betyg> Betygs { get; set; } = new List<Betyg>();

    public virtual Personal? Lärare { get; set; }
}
