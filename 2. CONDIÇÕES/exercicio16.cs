// 16. Implementar uma função que informe a classificação de um aluno a partir de 3 notas, seguindo as regras abaixo:
// - Se média maior que 8        = Aprovado com sucesso
// - Se média entre 5 e 8        = Aprovado
// - Se média entre 3 e 5        = Recuperação
// - Se média menor que 3        = Reprovado
// - Se média igual a zero        = Desistente

string ClassificacaoAluno(double nota1, double nota2, double nota3)
{
    double media = (nota1 + nota2 + nota3) / 3;
    if(media > 8)
        return "Aprovado com sucesso!";
    else if(media > 5)
        return "Aprovado";
    else if(media > 3)
        return "Recuperação";
    else if(media <= 3 && media > 0)
        return "Reprovado";
    else
        return "Desistente";
}

Console.WriteLine(ClassificacaoAluno(4, 5, 6));