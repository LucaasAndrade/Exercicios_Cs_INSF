// 10. Implementar uma função que recebendo um array de números inteiros, some seus elementos.
// Ex: [2,5,8] => 15


int SomaObjetos(int[] array)
{
    int soma = 0;
    for(int i = 0; i < array.Length; i++)
    {
        soma += array[i];
    }
    return soma;
}

int[] x = {6, 3, 9};
Console.WriteLine(SomaObjetos(x));
