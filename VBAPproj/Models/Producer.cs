using System.ComponentModel.DataAnnotations;
using VBAPproj.Data.Base;

namespace VBAPproj.Models
{
    public class Producer : IEntityBase
    {
        [Key]
        public int Id { get; set; }


        [Required(ErrorMessage = "Full name is required.")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Full name must be between 3 and 50 characters.")]
        public string FullName { get; set; }
        [Required(ErrorMessage = "Biography is required.")]
        public string Bio { get; set; }

        //relationships

        public List<Movie> Movies { get; set; }
    }
}
