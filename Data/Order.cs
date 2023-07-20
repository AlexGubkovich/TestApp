namespace TestApp.Data
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime OrderDate { get; set; }
        public string StoreCity { get; set; } = null!;
        public int CompanyId { get; set; }
    }
}