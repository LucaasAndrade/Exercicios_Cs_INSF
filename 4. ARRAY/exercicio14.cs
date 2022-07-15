// 14. Implementar uma função que recebendo um número, retorne um array com a tabuada desse número.
// Ex: 4 =>  [0,4,8,12,16,20,24,28,32,36,40]

int[] TabuadaComVetores(int numero)
{
    int[] array = new int[11];
    for(int i = 0; i < array.Length; i++)
        array[i] = numero * i;
    return array;
}

void MostrarArray(int[] array)
{
    foreach(int i in array)
        Console.WriteLine(i);
}

int[] x = TabuadaComVetores(4);
MostrarArray(x);