public class Transaction
{
    public int ProductId { get; set; }
    public string ProductName { get; set; } = "";
    public string Type { get; set; } = "";
    public int Quantity { get; set; }
    public DateTime Date { get; set; }
}