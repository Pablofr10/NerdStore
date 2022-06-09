using MediatR;
using NerdStore.Core.Messages;
using NerdStore.Vendas.Domain;

namespace NerdStore.Vendas.Application.Commands;

public class PedidoCommandHandler : 
    IRequestHandler<AdicionarItemPedidoCommand, bool>
{
    private readonly IPedidoRepository _pedidoRepository;

    public PedidoCommandHandler(IPedidoRepository pedidoRepository)
    {
        _pedidoRepository = pedidoRepository;
    }
    public async Task<bool> Handle(AdicionarItemPedidoCommand message, CancellationToken cancellationToken)
    {
        if (!ValidarCommando(message)) return false;

        var pedido = await _pedidoRepository.ObterPedidoRascunhoPorClienteId(message.ClienteId);
        var pedidoItem = new PedidoItem(message.ProdutoId, message.Nome, message.Quantidade, message.ValorUnitario);

        if (pedido == null)
        {
            pedido = Pedido.PedidoFactory.NovoPedidoRascunho(message.ClienteId);
            pedido.AdicionarItem(pedidoItem);
        }
        else
        {
            var pedidoItemExistente = pedido.PedidoItemExistente(pedidoItem);
            pedido.AdicionarItem(pedidoItem);

            if (pedidoItemExistente)
            {
                var pedidoAtualizar = pedido.PedidoItems.FirstOrDefault(p => p.ProdutoId == pedidoItem.ProdutoId);
                _pedidoRepository.AtualizarItem(pedidoAtualizar);
            }
            else
            {
                _pedidoRepository.AdicionarItem(pedidoItem);
            }
        }

        return await _pedidoRepository.UnitOfWork.Commit();
    }

    private bool ValidarCommando(Command message)
    {
        if (message.EhValido()) return true;

        foreach (var erro in message.ValidationResult.Errors)
        {
            
        }

        return false;
    }
}