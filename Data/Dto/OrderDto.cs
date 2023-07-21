namespace TestApp.Data.Dto
{
    public class OrderDto
    {
        public int Id { get; set; }
        public DateTime OrderDate { get; set; }
        public string StoreCity { get; set; } = null!;
    }
}
