using System.ComponentModel.DataAnnotations;

namespace TestApp.Data.Dto
{
    public class CompanyCreateDto
    {
        [Required]
        [StringLength(60)]
        public string Name { get; set; } = null!;

        [Required]
        [StringLength(60)]
        public string Address { get; set; } = null!;

        [Required]
        [StringLength(20)]
        public string City { get; set; } = null!;

        [Required]
        [StringLength(5)]
        public string State { get; set; } = null!;

        [Required, Phone]
        public string Phone { get; set; } = null!;
    }
}
