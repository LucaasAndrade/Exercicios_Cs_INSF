// 12. Implementar uma função que represente uma calculadora. A função deve receber dois valores numéricos mais o tipo da operação matemática que deve realizar nos valores e retornar o resultado do cálculo. As operações suportadas estão listadas abaixo, caso seja enviada uma operação diferente, um erro deve ser lançado com a mensagem: "Operação não suportada".
// - Soma
// - Subtração
// - Multiplicação
// - Divisão
// - Potência


string Calculadora(double numero1, double numero2, string operacao)
{
    operacao = operacao.ToLower();
    if(operacao == "soma")
        return $"{numero1} + {numero2} = {numero1 + numero2}";
    else if(operacao == "subtração" || operacao == "subtracao")
        return $"{numero1} - {numero2} = {numero1 - numero2}";
    else if(operacao == "multiplicação" || operacao == "multiplicacao")
        return $"{numero1} : {numero2} = {numero1 / numero2}";
    else if(operacao == "potência" || operacao == "potencia")
        return $"{System.Math.Pow(numero1, numero2)}";
    else
        return "Operação não suportada!";
}

Console.WriteLine(Calculadora(3, 3, "SOMA"));