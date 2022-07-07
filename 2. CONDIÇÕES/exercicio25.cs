// 25. Implementar uma função que a partir de um dia e mês em formato numérico, informe qual é o signo da pessoa.


string Signo(int dia, int mes)
{
    if(mes != 2 && dia >= 31)
        throw new System.Exception("Informe um dia válido!");
    else if(mes == 2 && dia >= 28)
        throw new System.Exception("O mês de fevereiro só tem 28 dias!");
    if(dia >= 20 && mes == 1 || dia <= 18 && mes == 2)
        return "Aquario";
    else if(dia >= 19 && mes == 2 || dia <= 20 && mes == 3)
        return "Peixes";
    else if(dia >= 21 && mes == 3 || dia <= 19 && mes == 4)
        return "Áries";
    else if(dia >= 20 && mes == 4 || dia <= 20 && mes == 5)
        return "Touro";
    else if(dia >= 21 && mes == 5 || dia <= 20 && mes == 6)
        return "Gêmeos";
    else if(dia >= 21 && mes == 6 || dia <= 22 && mes == 7)
        return "Câncer";
    else if(dia >= 23 && mes == 7 || dia <= 22 && mes == 8)
        return "Leão";
    else if(dia >= 23 && mes == 8 || dia <= 22 && mes == 9)
        return "Virgem";
    else if(dia >= 23 && mes == 9 || dia <= 22 && mes == 10)
        return "Libra";
    else if(dia >= 23 && mes == 10 || dia <= 21 && mes == 11)
        return "Escorpião";
    else if(dia >= 22 && mes == 11 || dia <= 21 && mes == 12)
        return "Sagitário";
    else
        return "Capricórnio";
}

Console.WriteLine(Signo(32, 11));