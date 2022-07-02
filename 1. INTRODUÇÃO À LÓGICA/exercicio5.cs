// 5. Implementar uma função para calcular o salário líquido de um funcionário, a partir de seu salário base, do bônus mensal (em %) e do total de descontos.
//    Ex: Para os valores:
//        -> Salário: 1000 reais
//        -> Bônus: 10 porcento
//        -> Descontos: 300 reais

//        O resultado será:
//        -> 800 //


double SalarioLiquido(double salario, int bonus, double desconto)
{
    double total = ((salario * bonus )/ 100) + salario;
    return total - desconto;
}

Console.WriteLine(SalarioLiquido(1000, 10, 300));