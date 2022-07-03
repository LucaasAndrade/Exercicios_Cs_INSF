// 8. Implementar uma função que informe qual semestre é, a partir do número do mês.

string Semestre(int mes)
{
    if(mes == 1 || mes == 2 || mes == 3 || mes == 4 || mes == 5 || mes == 6)
        return "Primeiro Semestre";
    else if(mes == 7 || mes == 8 || mes == 9 || mes == 10 || mes == 11 | mes == 12)
        return "Segundo Semestre";
    else
        return "Informe um mês válido!";
}

Console.WriteLine(Semestre(13));