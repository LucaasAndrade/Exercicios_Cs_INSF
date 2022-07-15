// 16. Implementar uma função que recebendo um texto, retorne um array de texto com o código ascii de cada caractere.
// Ex: "Bruno" =>  [66, 114, 117, 110, 111] 

int[] ConverterParaCodigoASCII(string nome)
{   
    int[] array = new int[nome.Length];
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = (int)nome[i];
    }
    return array;
}

void MostrarArray(int[] array)
{
    foreach(int i in array)
        Console.WriteLine(i);
}

int[] b = ConverterParaCodigoASCII("Bruno");
MostrarArray(b);