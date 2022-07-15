// 07. Implementar uma função que recebendo um número de início e fim, retorne um array contendo uma sequência do número final até o número inicial.
// Ex: (3, 8) => [8,7,6,5,4,3]


int[] CriarSequenciaDecrescente(int inicio, int fim)
{
    int contador = inicio;
    int[] array = new int[inicio - (fim - 1)];
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = contador;
        contador -= 1;
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

int[] x = CriarSequenciaDecrescente(10, 6);
MostrarArray(x);