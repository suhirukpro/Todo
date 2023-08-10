using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jobs.DataAccess.Models
{
    public class Job
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Description { get; set; }
    }
}
