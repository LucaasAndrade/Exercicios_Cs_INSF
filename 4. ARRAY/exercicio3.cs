// 03. Implementar uma função que recebendo um número limite, retorne um array contendo uma sequência do número anterior ao limite até 0.
// Ex: 5 => [4,3,2,1,0]

int[] CriarSequencia(int limite)
{
    int[] array = new int[limite];
    int cont = limite -1;
    for(int i = 0; i < limite; i++)
    {
        array[i] = cont;
        cont --;
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