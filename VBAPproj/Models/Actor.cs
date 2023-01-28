using System.ComponentModel.DataAnnotations;
using VBAPproj.Data.Base;

namespace VBAPproj.Models
{
    public class Actor : IEntityBase
    {
        [Key]
        public int Id { get; set; }

        public string FullName { get; set; }
        [Required(ErrorMessage = "Full name is required.")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Full name must be between 3 and 50 characters.")]

        public string Bio { get; set; }
        [Required(ErrorMessage = "Biography is required.")]

        //relationships

        public List<Actor_Movie> Actors_Movies { get; set; }
    }
}
