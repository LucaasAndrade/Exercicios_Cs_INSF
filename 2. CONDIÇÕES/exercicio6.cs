// 6. Implementar uma função que informe o dia da semana por extenso a partir do número do dia, sabendo que a semana começa no Domingo como dia zero. Se o número do dia não estiver entre 0 e 6, um erro deve ser lançado com a mensagem: "Dia da semana inválido".

string DiaSemana(int numero)
{
    if(numero == 0)
        return "Domingo";
    else if(numero == 1)
        return "Segunda";
    else if(numero == 2)
        return "Terça";
    else if(numero == 3)
        return "Quarta";
    else if(numero == 4)
        return "Quinta";
    else if(numero == 5)
        return "Sexta";
    else if(numero == 6)
        return "Sábado";
    else
        return "Informe um número válido!";
}

Console.WriteLine(DiaSemana(3));