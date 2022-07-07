// 18. Implementar uma função que calcule o IMC de uma pessoa e informe a classificação.

string ClassicacaoIMC(double peso, double altura)
{
    double IMC = peso / System.Math.Pow(altura);
    if(IMC <= 18.5)
        return "Abaixo do peso";
    else if(IMC <= 24.9)
        return "Peso normal";
    else if(IMC <= 29.9)
        return "Sobrepeso";
    else if(IMC <= 34.9)
        return "Obesidade I";
    else if(IMC <= 39.9)
        return "Obesidade II";
    else
        return "Obesidade III";
}

Console.WriteLine(ClassicacaoIMC(60, 1.75));