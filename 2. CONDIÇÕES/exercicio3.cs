// 3. Implementar uma função para verificar qual é o maior entre três números. A função deve retornar uma mensagem na formatação: "O número X é maior que Y e Z". Se os números forem iguais, a função deve retornar a mensagem: "Os números são iguais"

string CompararNumeros(int numero1, int numero2)
{
    if(numero1 > numero2)
        return $"O número {numero1} é maior que o número {numero2}";
    else if(numero2 > numero1)
        return $"O número {numero2} é maior que o número {numero1}";
    else
        return "Os números são iguais!";
}


Console.WriteLine(CompararNumeros(10, 20));