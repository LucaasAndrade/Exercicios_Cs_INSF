// 22. Implementar uma função que calcule o valor da mensalidade que um aluno de uma faculdade de tecnologia deve pagar, a partir da sigla do curso, se é isento (sim ou não) e do desconto (em %) que ele possui. Abaixo está o valor da mensalidade para cada curso:
// - SI  (Sistemas de Informação)        = R$  550,00
// - ADS (Análise e Desenv. de Sistemas) = R$  750,00
// - CS  (Ciência da Computação)         = R$ 1150,00
// - EC  (Engenharia da Computação)      = R$ 1300,00
// - ES  (Engenharia de Software)        = R$  950,00

double CalcularMensalidade(string nomeCurso, bool isento, int desconto)
{
    double mensalidade = 0;
    nomeCurso = nomeCurso.ToUpper();
    if(isento)
        return "O aluno é isento de mensalidade!";
    else
    {
        if(nomeCurso == "SI")
            mensalidade = 550;       
        else if(nomeCurso == "ADS")
            mensalidade = 750;
        else if(nomeCurso == "CS")
            mensalidade = 1150;
        else if(nomeCurso == "EC")
            mensalidade = 1300;
        else if(nomeCurso == "ES")
            mensalidade = 950;
        double porcentagem = (100 * desconto) / mensalidade;
        return $"O aluno deve pagar R$ ${mensalidade - porcentagem} por mês";
    }
}

Console.WriteLine(CalcularMensalidade("SI", false, 20));