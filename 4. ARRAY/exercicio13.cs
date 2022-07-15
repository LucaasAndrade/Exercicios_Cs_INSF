// 13. Implementar uma função que recebendo um array de números inteiros, retorne um array com o dobro de cada elemento.
// Ex: [1,2,3,4,5] => [2,4,6,8,10]


int[] DobroVetores(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        array[i] = array[i] * 2;
    return array;
}

void MostrarArray(int[] array)
{
    foreach(int i in array)
        Console.WriteLine(i);
}

int[] x = {10, 20 , 30, 40, 50};
int[] a = DobroVetores(x);
MostrarArray(a);