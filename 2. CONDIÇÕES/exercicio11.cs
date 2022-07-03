// 11. Implementar uma função que informe qual é o tipo do triângulo: Isóceles, Escaleno ou Equilátero baseado em seus três lados.
// Implementar uma função que verifique, sim ou não, se uma data informada é válida. As informações da data devem vir separadas por dia, mês e ano no formato numérico.


string IdentificarTriangulo(double lado1, double lado2, double lado3)
{
    if(lado1 == lado2 && lado1 == lado3 && lado2 == lado3)
        return "Triângulo Equilátero";
    else if(lado1 == lado2 || lado1 == lado3 || lado2 == lado3)
        return "Triângulo Isósceles";
    else    
        return "Triângulo Escaleno!";    
}

Console.WriteLine(IdentificarTriangulo(10, 11, 12));