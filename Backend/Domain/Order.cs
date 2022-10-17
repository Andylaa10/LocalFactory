namespace Domain;

public class Order
{
    public int Id { get; set; }
    public int CustomerId { get; set; }
    public virtual Customer? Customer { get; set; }
    public int BoxId { get; set; }
    public virtual Box? Box { get; set; }
}