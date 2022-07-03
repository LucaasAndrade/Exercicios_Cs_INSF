// 10. Implementar uma função que informe a situação de um orçamento familiar baseado no total de ganhos e gastos. A situação deve ser calculada a partir da tabela abaixo:
// - Para Gastos menores que 30% dos Ganhos: "Parabéns, está gerenciando bem seu orçamento!"
// - Para Gastos menores que 50% dos Ganhos: "Muito bem, seus gastos não ultrapassam metade dos ganhos!"
// - Para Gastos menores que 80% dos Ganhos: "Atenção, melhor conter os gastos!"
// - Para Gastos menores que 100% dos Ganhos: "Cuidado, seu orçamento pode ficar comprometido!"
// - Para Gastos maiores que os Ganhos: "Orçamento comprometido! Hora de rever seus gastos!"


string Orcamento(double ganhos, double gastos)
{
    double porcentagem = (gastos * 100) / ganhos;
    if(porcentagem <= 30)
        return "Parabéns, está gerenciando bem seu orçamento!";
    else if(porcentagem <= 50)
        return "Muito bem, seus gastos não ultrapassam metade dos ganhos!";
    else if(porcentagem <= 80)
        return "Atenção, melhor conter seus gastos!";
    else if(porcentagem <= 100)
        return "Cuidado, seu orçamento pode ficar comprometido!";
    else
        return "Orçamento comprometido! Hora de rever seus gastos!";
}


Console.WriteLine(Orcamento(1000, 500));