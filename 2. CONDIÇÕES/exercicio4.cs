// 4. Implementar uma função que retorne uma mensagem com a ação que um pedestre deve realizar ao ver seu semáforo. As possíveis ações estão listadas abaixo. Se a cor for diferente, a função deve retornar um Erro com a informação: "Farol inoperante"
// - Vermelho -> Espere
// - Verde -> Atravasse

string Semaforo(string cor)
{
    cor = cor.ToLower;
    if(cor == "vermelho")
        return "Espere";
    else if(cor == "verde")
        return "Atravesse";
    else
        return "Informe uma cor válida!";
}

Console.WriteLine(Semaforo("Azul"));