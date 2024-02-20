using System;
using System.Collections.Generic;

namespace Kagglizer_Dotnet.Models;

public partial class UserStudentAnswer
{
    public int? Id { get; set; }

    public int? StoryId { get; set; }

    public DateTime? UseDate { get; set; }

    public int? QuestionId { get; set; }

    public bool? IsStudentCorrect { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? CreatedById { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public int? ModifiedById { get; set; }
}
