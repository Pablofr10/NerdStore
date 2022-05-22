﻿using MediatR;

namespace NerdStore.Catalogo.Domain.Events;

public class ProdutoEventHandler : INotificationHandler<ProdutoAbaixoEstoqueEvent>
{
    private readonly IProdutoRepository _produtoRepository;
    public async Task Handle(ProdutoAbaixoEstoqueEvent mensagem, CancellationToken cancellationToken)
    {
        var produto = await _produtoRepository.ObterPorId(mensagem.AggregateId);
    }
}