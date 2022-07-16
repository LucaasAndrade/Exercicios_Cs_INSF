// 17. Implementar uma função que recebendo um array de números inteiros, retorne o array com o menor elemento na primeira posição.
// Ex: [4,2,1,3,7] => [1,2,4,3,7]


void PrintarArray(int[] array)
{
    foreach(int i in array)
    {
        Console.WriteLine($"{i} ");
    }
        Console.WriteLine("--------");
}

int[] OrganizarArray(int[] array)
{
    int atual = 0;
    for(int i = 0; i < array.Length; i++)
    {
        for(int j = 0; j < array.Length; j++)
        {
            if(array[j] > array[i])
            {
                atual = array[j];
                array[j] = array[i];
                array[i] = atual;
            }
        }
    }
    return array;
}

int[] x = {4,2,1,3,7};
PrintarArray(OrganizarArray(x));