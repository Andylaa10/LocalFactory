namespace Domain;

public class Box
{
    public int Id { get; set; }
    public string BoxName { get; set; }
    public string Description { get; set; }
    public float Price { get; set; }
    public int CustomerId { get; set; }
    public virtual Customer Customer { get; set; }
}