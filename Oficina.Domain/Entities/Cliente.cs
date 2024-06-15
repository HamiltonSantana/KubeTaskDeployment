using Oficina.Domain.Entities.Base;

namespace Oficina.Domain.Entities;

public class Cliente : Person
{
    public Guid Id { get; set; }
    public Veicule Veicule { get; set; }
}
