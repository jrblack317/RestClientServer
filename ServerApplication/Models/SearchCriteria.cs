using System.ComponentModel.DataAnnotations;

namespace SeverApplication.Models
{
    public class SearchCriteria
    {
        [Required]
        public string Input { get; set; }
        public int? Id { get; set; }
        [Required]
        public decimal Rate { get; set; }
        public int PropertyShouldNotBeNullable { get; set; }
    }
}