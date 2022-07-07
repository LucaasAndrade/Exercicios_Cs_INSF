// 17. Implementar uma função que informe a classificação de um aluno a partir de 3 notas e da quantidade de faltas. O aluno já será considerado reprovado se a quantidade de faltas for maior que 30. A tabela abaixo apresenta as regras para os intervalos da média:
// - Se média maior que 8        = Aprovado com sucesso
// - Se média entre 5 e 8        = Aprovado
// - Se média entre 3 e 5        = Recuperação
// - Se média menor que 3        = Reprovado
// - Se média igual a zero       = Desistente


string SituacaoAluno(double nota1, double nota2, double nota3, int faltas)
{
    double media = (nota1 + nota2 + nota3) / 3;
    if(faltas > 30)
        return "Reprovado!";
    else if(media > 8)
        return "Aprovado com sucesso";
    else if(media > 5)
        return "Aprovado";
    else if(media > 3)
        return "Recuperação";
    else if(media <= 3 && media > 0)
        return "Reprovado!";
    else
        return "Desistente";
}

Console.WriteLine(SituacaoAluno(4, 5, 6, 29));