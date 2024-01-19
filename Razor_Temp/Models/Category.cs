using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Razor_Temp.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(30)]
        public string Name { get; set; }
        [MaxLength(100)]
        public string Description { get; set; }
        [DisplayName("Display Order")]
        [Range(1, 100, ErrorMessage = "The number should be between 1 to 100")]
        public int DisplayOrder { get; set; }
        public bool? Status { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
