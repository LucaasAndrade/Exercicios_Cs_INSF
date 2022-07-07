// 19. Implementar uma função que calcule o total a se pagar em uma compra na sorveteria, a partir do total de gramas comprado. O preço de 100g é R$ 3,50 mas se o total de gramas for maior que 1kg, o preço de 100g diminui 50 centavos.


double TotalSorveteria(int gramas)
{
    double preco = 3.5;
    if(gramas >= 1000)
    {
        preco = 3;
        gramas = gramas / 100;
        return preco * gramas;
    }
    else
    {
        gramas = gramas / 100;
        return preco * gramas;
    }
}

Console.WriteLine(TotalSorveteria(1000));