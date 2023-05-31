using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BulkyBookWeb.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        public string? Name { get; set; }

        [DisplayName("Display Order")]
        [Range(1, 200, ErrorMessage = "Display Order must be between 1 and 200 only !!")]    /*Min , Max*/
        public int DisplayOrder { get; set; }

        public DateTime CreatedDateTime { get; set; } = DateTime.Now;
    }
}
