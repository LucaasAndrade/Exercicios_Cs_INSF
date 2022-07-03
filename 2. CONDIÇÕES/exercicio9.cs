//  9. Implementar uma função que represente a lógica do jogo "Par ou Ímpar". A partir do número colocado pelo jogador1 e jogador2, a função deve informar quem ganhou o jogo.


string ParOuImpar(int numero1, int numero2)
{
    if(numero1 % numero2 == 0)
        return " PAR - Jogador 1 venceu";
    else
        return "IMPAR - Jogador 2 venceu";
}

Console.WriteLine(ParOuImpar(1, 1));