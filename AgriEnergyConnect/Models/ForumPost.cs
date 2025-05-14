using System.ComponentModel.DataAnnotations;

namespace AgriEnergyConnect.Models
{
    public class ForumPost
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Message { get; set; }

        public DateTime Timestamp { get; set; } = DateTime.Now;

        public string? AuthorUsername { get; set; }
    }
}
