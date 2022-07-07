// 20. Implementar uma função que represente a lógica do jogo "Jokenpow". A partir da jogada colocada pelo jogador1 e jogador2, a função deve informar quem ganhou o jogo, ou se deu empate.

string Jokenpow(string jogador1, string jogador2)
{
    jogador1 = jogador1.ToLower();
    jogador2 = jogador2.ToLower();
    if(jogador1 == jogador2)
        return "Empate";
    else if(jogador1 == "pedra" && jogador2 == "tesoura")
        return "Jogador 1 venceu!";
    else if(jogador1 == "papel" && jogador2 == "pedra")
        return "Jogador 1 venceu!";
    else if(jogador1 == "tesoura" && jogador2 == "papel")
        return "Jogador 1 venceu!";
    else if(jogador1 == "tesoura" && jogador2 == "pedra")
        return "Jogador 2 venceu!";
    else if(jogador1 == "pedra" && jogador2 == "papel")
        return "Jogador 2 venceu!";
    else if(jogador1 == "papel" && jogador2 == "tesoura")
        return "Jogador 2 venceu!";
    else
        return "Informe um valor válido";
}


Console.WriteLine(Jokenpow("Pedra", "Tesoura"));