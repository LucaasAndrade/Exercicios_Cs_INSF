// 11. Implementar uma função que recebendo um array de números inteiros, calcule a média dos elementos.
// Ex: [2,5,8] => 5


int CalcularMediaObjetos(int[] array)
{
    int soma = 0;
    for(int i = 0; i < array.Length; i++)
    {
        soma += array[i];
    }
    return soma / array.Length;
}

int[] x = {5, 10, 8};
Console.WriteLine(CalcularMediaObjetos(x));
