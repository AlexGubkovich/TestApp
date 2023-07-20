using System.ComponentModel.DataAnnotations;

namespace TestApp.Data.Dto
{
    public class CompanyDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string City { get; set; } = null!;
        public string State { get; set; } = null!;
        public string Phone { get; set; } = null!;
    }
}
