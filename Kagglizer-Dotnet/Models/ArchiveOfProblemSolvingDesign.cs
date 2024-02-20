using System;
using System.Collections.Generic;

namespace Kagglizer_Dotnet.Models;

public partial class ArchiveOfProblemSolvingDesign
{
    public int Id { get; set; }

    public string StateCurrent { get; set; } = null!;

    public string StateDesired { get; set; } = null!;

    public string Problem { get; set; } = null!;

    public string Approach { get; set; } = null!;

    public string Plan { get; set; } = null!;

    public int CreatedBy { get; set; }

    public DateTime CreatedDate { get; set; }

    public int ModifiedBy { get; set; }

    public DateTime ModifiedDate { get; set; }
}
