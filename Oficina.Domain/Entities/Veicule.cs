namespace Oficina.Domain.Entities;

public class Veicule
{
    public Guid UId { get; set; }
    public string Color { get; set; }
    public string Plate { get; set; }
    public string Model { get; set; }
    public string Brand { get; set; }
    public double Mileage { get; set; }
    public virtual Cliente Owner { get; set; }
}
