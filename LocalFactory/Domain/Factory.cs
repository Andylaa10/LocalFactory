namespace Domain;

public class Factory
{
    public int Id { get; set; }
    public string FactoryName { get; set; }
    public string Address { get; set; }
    public IEnumerable<Box> Boxes { get; set; }
    
}