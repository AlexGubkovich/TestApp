namespace TestApp.Data
{
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string Title { get; set; } = null!;
        public DateTime BirthDate { get; set; }
        public string Position { get; set; } = null!;
        public Note? Note { get; set; }
        public int CompanyId { get; set; }
    }
}
