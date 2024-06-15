namespace Oficina.Domain.Entities;

public class OrdemServico
{
    public Guid UId { get; set; }
    public decimal Value { get; set; }
    public virtual Cliente Client { get; set; }
}
