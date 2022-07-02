// 2. Implementar uma função para verificar qual é o maior entre dois números. Se os números forem iguais, a função deve retornar a mensagem: "Os números são iguais"

string VerificarNumeros(int numero1, int numero2)
{  
    if(numero1 > numero2)
        return $"O número {numero1} é maior que {numero2}";
    else if(numero2 > numero1)
        return $"O número {numero1} é maior que {numero2}";
    else
        return "Os númeors são iguáis!";
}

Console.WriteLine(VerificarNumeros(10, 10));