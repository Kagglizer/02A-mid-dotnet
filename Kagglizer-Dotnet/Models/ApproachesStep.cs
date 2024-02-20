using System;
using System.Collections.Generic;

namespace Kagglizer_Dotnet.Models;

public partial class ApproachesStep
{
    public int Id { get; set; }

    public string? ApproachName { get; set; }

    public int? ApproachId { get; set; }

    public string? StepName { get; set; }

    public int? StepId { get; set; }

    public int? StepDomainsId { get; set; }

    public int? StepCategoryId { get; set; }

    public string? StepDescription { get; set; }

    public string? StepDescriptionPromptPackage { get; set; }

    public int? StepCompletionCount { get; set; }

    public int? StepNextIfCompleteTrue { get; set; }

    public int? StepNextIfCompleteFalse { get; set; }

    public int? StepNextIfInconclusive { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }
}
