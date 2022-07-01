// 4. Implementar uma função para verificar se um aluno REPROVOU baseado em 3 notas, considerando que a média para passar é a partir de 5.

string Aprovado(double nota1, double nota2, double nota3)
{
    string msg = "";
    if((nota1 + nota2 + nota3) / 3 >= 5)
    {
        msg = "Aprovado!";
    }
    else
    {
        msg = "Reprovado";
    }
    return msg;
}

Console.WriteLine(Aprovado(3, 5, 6));
