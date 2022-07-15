// 06. Implementar uma função que recebendo um número de início e fim, retorne um array contendo uma sequência do número de início até o número final.
// Ex: (3, 8) => [3,4,5,6,7,8]

int[] CriarSeqeuncia(int inicio, int fim)
{
    int[] array = new int[fim - (inicio - 1)];
    int cont = inicio;
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = cont;
        cont++;
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


int[] x = CriarSeqeuncia(3, 8);
MostrarArray(x);