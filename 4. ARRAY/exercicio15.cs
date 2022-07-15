// 15. Implementar uma função que recebendo o valor de 'a', 'b' e 'c', calcule a fórmula de bhaskara.
// Ex: (1,12,-13) => [1,-13]

double[] FormulaBhaskara(double valorA, double valorB, double valorC)
{
    double delta = (System.Math.Pow(valorB, 2) - ((4 * valorA) * valorC));
    double x1 = ((valorB * -1) + (System.Math.Sqrt(delta)) )/ (2*valorA);
    double x2 = ((valorB * -1) - (System.Math.Sqrt(delta))) / (2*valorA);
    double[] array = {x1, x2};
    return array;
}

void MostrarArray(double[] array)
{
    foreach(int i in array)
        Console.WriteLine(i);
}

double[] x = FormulaBhaskara(1, 12, -13);
MostrarArray(x);