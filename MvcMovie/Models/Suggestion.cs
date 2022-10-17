using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcMovie.Models
{
    public class Suggestion
    {
        public int Id { get; set; }
        public string? Title { get; set; }

        public string? Description { get; set; }

        public string? Team { get; set; }

        public string? Owner { get; set; }
        [Display(Name = "Created")]
        [DataType(DataType.Date)]
        public DateTime StartDate { get; set; } 
        public string? Status { get; set; }
        
    }
}
