// 7. Implementar uma função que informe o nome de um mês por extenso a partir do número do mês.


string Mes(int numero)
{
    if(numero == 1)
        return "Janeiro";
    else if(numero == 2)
        return "Fevereiro";
    else if(numero == 3)
        return "Março";
    else if(numero == 4)
        return "Abril";
    else if(numero == 5)
        return "Maio";
    else if(numero == 6)
        return "Junho";
    else if(numero == 7)
        return "Julho";
    else if(numero == 8)
        return "Agosto";
    else if(numero == 9)
        return "Setembro";
    else if(numero == 10)
        return "Outubro";
    else if(numero == 11)
        return "Novembro";
    else if(numero == 12)
        return "Dezembro";
    else
        return "Informe um número válido!";
}


Console.WriteLine(Mes(0));