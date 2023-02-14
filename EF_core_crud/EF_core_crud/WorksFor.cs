using System;
using System.Collections.Generic;

namespace EF_core_crud;

public partial class WorksFor
{
    public int Essn { get; set; }

    public int Pno { get; set; }

    public int? Hours { get; set; }

    public virtual Employee EssnNavigation { get; set; }

    public virtual Project PnoNavigation { get; set; }
}
