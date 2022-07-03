// 5. Implementar uma função que informe a situação de um orçamento familiar baseado no total de ganhos e gastos. Se o total de ganhos for maior que o total de gastos, deve ser exibido a mensagem: "Você está dentro do orçamento!", senão "Você está fora do orçamento! Não gaste mais!"

string Orcamento(double valorGanhos, double valorGastos)
{
    if(valorGastos < valorGanhos)
        return "Você está dentro do orçamento";
    else
        return "Você está fora do orçamento! Não gaste mais!";
}

Console.WriteLine(Orcamento(1200, 3000));
