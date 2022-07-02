// 1. Implementar uma função para verificar qual é o maior entre dois números. A função deve retornar uma mensagem na formatação: "O número X é maior que Y"

string VerificarMaior(int numero1, int numero2)
{
    if (numero1 > numero2)
        return $"O número {numero1} é maior que {numero2}";

    else
        return $"O número {numero2} é maior que {numero1}";
}

Console.WriteLine(VerificarMaior(9, 10));