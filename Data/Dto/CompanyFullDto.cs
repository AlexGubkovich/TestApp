namespace TestApp.Data.Dto
{
    public class CompanyFullDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string City { get; set; } = null!;
        public string State { get; set; } = null!;
        public string Phone { get; set; } = null!;
        public List<EmployeeDto> Employees { get; set; } = new List<EmployeeDto>();
        public List<NoteDto> Notes { get; set; } = new List<NoteDto>();
        public List<OrderDto> History { get; set; } = new List<OrderDto>();
    }
}
