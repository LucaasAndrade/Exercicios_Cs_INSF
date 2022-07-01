// 6. Implementar uma função para verificar se uma pessoa está com febre, sabendo que é considerado febre a partir de 37 graus.

string Febre(int temperatura)
{
    string msg = "";
    if(temperatura > 37)
        msg = "Estado Febril";
    else
        msg = "Ta vivo";
    return msg;
}

Console.WriteLine(Febre(38));