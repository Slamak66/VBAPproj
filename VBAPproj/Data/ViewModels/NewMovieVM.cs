using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using VBAPproj.Data.Enums;
using VBAPproj.Data.Base;

namespace VBAPproj.Models
{
    public class NewMovieVM
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is required.")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Description is required.")]
        public string Description { get; set; }
        [Required(ErrorMessage = "Price is required.")]
        public double Price { get; set; }
        [Required(ErrorMessage = "Movie start date is required.")]
        public DateTime StartDate { get; set; }
        [Required(ErrorMessage = "Movie end date is required.")]
        public DateTime EndDate { get; set; }
        [Required(ErrorMessage = "Movie category date is required.")]
        public MovieCategory MovieCategory { get; set; }

        //relationships

        [Required(ErrorMessage = "Movie actors are required.")]
        public List<int> ActorIds { get; set; }

        [Required(ErrorMessage = "Cinema is required.")]
        public int CinemaId { get; set; }
        [Required(ErrorMessage = "Movie producer is required.")]
        public int ProducerId { get; set; }
    }
}
