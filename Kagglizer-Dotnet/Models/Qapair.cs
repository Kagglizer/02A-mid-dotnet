using System;
using System.Collections.Generic;

namespace Kagglizer_Dotnet.Models;

public partial class Qapair
{
    public int Id { get; set; }

    public string Question { get; set; } = null!;

    public string Answer { get; set; } = null!;

    public int CategoryId { get; set; }

    public int SortOrder { get; set; }

    public DateTime DateCreated { get; set; }

    public DateTime DateModified { get; set; }

    public int CreatedBy { get; set; }

    public int ModifiedBy { get; set; }
}
