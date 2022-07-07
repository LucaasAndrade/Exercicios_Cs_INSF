// 13. Implementar uma função que calcule o total a se pagar na compra de ingressos de cinema, a partir da quantidade de ingressos 'inteiras' e 'meias'. O valor do ingresso é R$ 28,50. Considere que se o ingresso for para QUARTA-FEIRA, ingressos 'inteiras' também custarão meia entrada.


double CalcularIngresos(int qtdInteiras, int qtdMeias, string diaSemana)
{
    double inteira = 28.50;
    if(diaSemana == "quarta-feira")
    {
        inteira = inteira / 2;
        return (qtdInteiras + qtdMeias) * inteira;
    }
    else
    {
        return qtdInteiras * inteira + qtdMeias * (inteira / 2);
    }
}


Console.WriteLine(CalcularIngresos(2, 4, "quinta-feira"));