// 8. Implementar uma função que retorne uma mensagem de boas vindas, a partir de um nome de aluno. Ex. "Seja bem-vindo Bruno!"

string BemVindo(string nome)
{
    return $"Bem Vindo {nome}";
}

Console.WriteLine(BemVindo("Lucas"));