// 01. Implementar uma função que recebendo um array de números inteiros, escreva seus elementos no terminal.
// Ex: [8,2,10,5] => 8
//                   2
//                   10
//                   5


void MostrarArray(int[] numeros)
{
    for(int i = 0; i < numeros.Length; i++)
    {
        Console.WriteLine(numeros[i]);
    }
}

int[] x = {1, 2, 3, 4};
MostrarArray(x);


