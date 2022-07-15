// 12. Implementar uma função que recebendo um array de números inteiros, retorne seu segundo maior valor.
// Ex: [8,2,10,5] => 8

int AcharSegundoMaior(int[] array)
{
    int maior = 0;
    int segundoMaior = 0;
    foreach(int i in array)
    {
        if(i > maior)
            maior = i;
    }
    foreach (int i in array)
    {
        if(i > segundoMaior && i < maior)
            segundoMaior = i;
    }
    return segundoMaior;
}

int[] x = {10, 20, 30 , 50, 60 , 100};
Console.WriteLine(AcharSegundoMaior(x));
