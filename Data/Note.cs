﻿namespace TestApp.Data
{
    public class Note
    {
        public int Id { get; set; }
        public int InvoiceNumber { get; set; }
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; } = null!;
        public int CompanyId { get; set; }
    }
}