// 14. Implementar uma função que calcule o total a se pagar na compra de ingressos de cinema, a partir da quantidade de ingressos 'inteiras' e 'meias'. O valor do ingresso é R$ 28,50. Considere que se o ingresso for para QUARTA-FEIRA, todo ingresso custará meia entrada. Se for um filme NACIONAL, o ingresso custará R$ 5,00 para 'inteira' e 'meia'. O desconto para filmes nacionais tem prioridade sobre o desconto de quarta-feira, ou seja, os dois descontos não podem acontecer ao mesmo tempo.

double CalcularIngresos(int qtdInteiras, int qtdMeias, string diaSemana, string nacionalidade)
{
    double inteiras = 28.50;
    if(diaSemana == "quarta-feira")
    {
        inteiras = inteiras / 2;
        return (qtdInteiras + qtdMeias) * inteiras;
    }
    else if(nacionalidade == "brasileira")
    {
        inteiras = 5; 
        return (qtdInteiras + qtdMeias) * inteiras;
    }
    else
    {
        return qtdInteiras * inteiras + qtdMeias * (inteiras / 2);
    }
}

Console.WriteLine(CalcularIngresos(2, 3, "quinta", "brasileira"));