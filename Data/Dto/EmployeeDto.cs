namespace TestApp.Data.Dto
{
    public class EmployeeDto
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string Title { get; set; } = null!;
        public DateTime BirthDate { get; set; }
        public string Position { get; set; } = null!;
    }
}
