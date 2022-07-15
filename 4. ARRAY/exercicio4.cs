//4. Implementar uma função que recebendo um número limite, retorne um array contendo uma sequência de 1 até o número limite.
// Ex: 5 => [1,2,3,4,5]


int[] CriarSequencia(int limite)
{
    int[] array = new int[limite];
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = i + 1;
    }
    return array;
}

void MostrarArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.WriteLine(array[i]);
    }
}


int[] x = CriarSequencia(5);
MostrarArray(x);
