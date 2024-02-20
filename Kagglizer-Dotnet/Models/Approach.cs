using System;
using System.Collections.Generic;

namespace Kagglizer_Dotnet.Models;

public partial class Approach
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Description { get; set; }

    public int? DomainId { get; set; }

    public int? ReferencesId { get; set; }

    public int? ImplementationMethodId { get; set; }

    public int? DesignMethodId { get; set; }

    public int? OtherClassificationId { get; set; }
}
