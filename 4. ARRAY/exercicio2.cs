// 02. Implementar uma função que recebendo um número limite, retorne um array contendo uma sequência de 0 até o número anterior ao limite.
// Ex: 5 => [0,1,2,3,4]

int[] CriarSequencia(int limite)
{
    int[] array = new int[limite];
    for(int i = 0; i < limite; i++)
    {
        array[i] = i;
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