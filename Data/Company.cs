using System.ComponentModel.DataAnnotations;

namespace TestApp.Data
{
    public class Company
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Address { get; set; } = null!;
        public string City { get; set; } = null!;
        public string State { get; set; } = null!;
        [Phone]
        public string Phone { get; set; } = null!;
        public List<Employee> Employees { get; set; } = new List<Employee>();
        public List<Note> Notes { get; set; } = new List<Note>();
        public List<Order> History { get; set; } = new List<Order>();
    }
}
