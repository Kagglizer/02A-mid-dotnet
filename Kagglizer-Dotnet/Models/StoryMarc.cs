using System;
using System.Collections.Generic;

namespace Kagglizer_Dotnet.Models;

public partial class StoryMarc
{
    public int Id { get; set; }

    public string? StoryName { get; set; }

    public string? Authors { get; set; }

    public DateTime? PublicationDate { get; set; }

    public DateTime CreatedDate { get; set; }

    public int? CreatedById { get; set; }

    public DateTime ModifiedDate { get; set; }

    public int? ModifiedById { get; set; }
}
