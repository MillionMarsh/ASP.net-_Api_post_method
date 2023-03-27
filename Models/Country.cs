using System.ComponentModel.DataAnnotations;

namespace apipractice.Models
{
    public class Country
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        [MaxLength(5)]
        public string shortname { get; set; }

        [Required]
        [MaxLength(10)]
        public string countrycode { get; set; }
    }
}
