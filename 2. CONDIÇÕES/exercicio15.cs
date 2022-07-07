// 15. Implementar uma função que a partir de duas cores primárias informe a cor resultante. Se as cores informadas não forem primárias, a função deve lançar um erro dizendo que apenas cores primárias são aceitas.

string CoresPrimarias(string cor1, string cor2)
{
    if(cor1 == "vermelho" && cor2 == "amarelo" || cor1 == "amarelo" && cor2 == "vermelho")
        return "Laranja";
    else if(cor1 == "azul" && cor2 == "amarelo" || cor1 == "amarelo" && cor2 == "azul")
        return "Verde ";
    else if(cor1 == "vermelho" && cor2 == "azul" || cor1 == "azul" && cor2 == "vermelho")
        return "Roxo";
    else
        return "Apenas core PRIMÁRIAS são aceitas.";
}

Console.WriteLine("azul", "vermelho");