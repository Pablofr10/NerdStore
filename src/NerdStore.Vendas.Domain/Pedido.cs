using NerdStore.Core.DomainObjects;

namespace NerdStore.Vendas.Domain;

public class Pedido : Entity, IAggregateRoot
{
    
}

public class PedidoItem : Entity
{

}

public class Voucher : Entity
{

}

public interface IPedidoRepository
{

}

public enum PedidoStatus
{

}

public enum TipoDescontoVoucher
{

}