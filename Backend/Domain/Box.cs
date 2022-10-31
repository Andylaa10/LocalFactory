namespace Domain;

public class Box
{
    //TO-DO Photo 
    public int Id { get; set; }
    
    public string Photo { get; set; }
    public string BoxName { get; set; }
    public string Description { get; set; }
    public float Price { get; set; }
    public List<Order>? Orders { get; set; }
}