using MediatR;
using NerdStore.Core.Messages;

namespace NerdStore.Vendas.Application.Commands;

public class PedidoCommandHandler : 
    IRequestHandler<AdicionarItemPedidoCommand, bool>
{
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