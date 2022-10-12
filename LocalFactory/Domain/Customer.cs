namespace Domain;

public class Customer
{
    public int Id { get; set; }
    public string CustomerName { get; set; }
    public string Email { get; set; }
    public virtual IEnumerable<Box> Boxes { get; set; }
}