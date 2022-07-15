// 08. Implementar uma função que recebendo um array de números inteiros, retorne seu maior valor.
// Ex: [8,2,10,5] => 10


int AcharMaiorNumero(int[] array)
{
    int maior = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] > maior)
            maior = array[i];
    }
    return maior;
}

int[] x = {1, 2, 10, 20, 15};
Console.WriteLine(AcharMaiorNumero(x));
