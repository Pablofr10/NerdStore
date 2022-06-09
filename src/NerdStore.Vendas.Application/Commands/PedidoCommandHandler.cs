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

        return true;
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