// 9. Implementar uma função que retorne uma mensagem formatada com o valor das parcelas de uma compra, a partir do valor total da compra e da quantidade do parcelamento. 
//   Exemplo da mensagem de resposta: "Sua compra de R$ 1200 em 10x de R$ 120 foi concluída"z

string CompraOK(double valor, int qtdParcelas)
{
    return $"Sua compra de R$ {valor} em {qtdParcelas}X vezes de R$ ${valor / qtdParcelas} foi concluída!";
}

Console.WriteLine(CompraOK(1200, 10));