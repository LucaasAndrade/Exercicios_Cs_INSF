// 05. Implementar uma função que recebendo um número limite, retorne um array contendo uma sequência do número limite até 1.
// Ex: 5 => [5,4,3,2,1]


int[] CriarSequencia(int limite)
{
    int[] array = new int[limite];
    int cont = limite;
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = limite;
        limite --;
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