using System.ComponentModel.DataAnnotations;

namespace JobFrontend.Models
{
    public class Job
    {
        public int Id { get; set; }

        [Required]
        public string Description { get; set; }
    }
}
