using System.ComponentModel.DataAnnotations;
using VBAPproj.Data.Base;

namespace VBAPproj.Models
{
    public class Cinema:IEntityBase
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Cinema logo is required.")]
        public string Logo { get; set; }
        [Required(ErrorMessage = "Cinema name is required.")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Cinema description is required.")]
        public string Description { get; set; }

        //relationships

        public List<Movie> Movies { get; set; }
    }
}
