using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace Kagglizer_Dotnet.Models
{
    public class Events
    {
        public int Id { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public string? Title { get; set; }

        public string? Location { get; set; }

        public string? Description { get; set; }
        public DateTime? CreateDate { get; set; }

        public int? CreateId { get; set; }
        public DateTime? ModifyDate { get; set; }

        public int? ModifyId { get; set; }
    }
}
