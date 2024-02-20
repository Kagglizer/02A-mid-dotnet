using System;
using System.Collections.Generic;

namespace Kagglizer_Dotnet.Models;

public partial class Event
{
    public int Id { get; set; }

    public DateTime StartDate { get; set; }

    public DateTime EndDate { get; set; }

    public string Title { get; set; } = null!;

    public string Location { get; set; } = null!;

    public string Description { get; set; } = null!;

    public DateTime CreateDate { get; set; }

    public int CreateId { get; set; }

    public DateTime ModifyDate { get; set; }

    public int ModifyId { get; set; }
}
