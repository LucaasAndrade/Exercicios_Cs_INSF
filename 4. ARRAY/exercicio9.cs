// 09. Implementar uma função que recebendo um array de números inteiros, retorne seu menor valor.
// Ex: [8,2,10,5] => 2

int AcharMenorNumero(int[] array)
{
    int menor = array[0];
    for(int i = 0; i < array.Length; i ++)
    {
        if(array[i] < menor)
            menor = array[i];
    }
    return menor;
}

int[] x = {10, 3, 4, 5, 11 , 20};
Console.WriteLine(AcharMenorNumero(x));