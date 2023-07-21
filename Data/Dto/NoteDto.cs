namespace TestApp.Data.Dto
{
    public class NoteDto
    {
        public int Id { get; set; }
        public int InvoiceNumber { get; set; }
        public string EmployeeFullName { get; set; } = null!;
    }
}
