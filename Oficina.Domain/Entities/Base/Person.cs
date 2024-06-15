namespace Oficina.Domain.Entities.Base;

public class Person
{
    public Guid UId { get; set; }
    public string Name { get; set; }
    public string LastName { get; set; }
    public string Address { get; set; }
    public int Identification { get; set; }
}
