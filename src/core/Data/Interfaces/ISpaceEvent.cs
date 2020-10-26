using System;
using System.Collections.Generic;

namespace core.Data.Interfaces
{
    public interface ISpaceEvent
    {
        string Header { get; set; }
        string Description { get; set; }
        DateTime When { get; set; }
        List<string> ReferenceLinks { get; set; }
        string CountryOfOrigin { get; set; }
        string Mission { get; set; }
        int NormalizedDayOfYear { get; set; }
    }
}