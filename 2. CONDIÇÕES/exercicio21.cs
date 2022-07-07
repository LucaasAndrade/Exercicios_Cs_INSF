// 21. Implementar uma função que calcule o valor da mensalidade que um aluno de faculdade deve pagar, a partir do valor cheio da mensalidade, se é isento (sim ou não) e do desconto (em %) que ele possui.
// mensalidade = 100
// desconto = x
// 100 * desconto = mensalidade * x; 

double CalcularMensalidade(double mensalidade, bool isento, int desconto)
{
    if(isento)
        return "O aluno é isento de mensalidade!";
    else
    {
        double porcentagem = (100 * desconto) / mensalidade;
        return $"O aluno deve pagar R${mensalidade - porcentagem} por mês!";
    }
}


Console.WriteLine(CalcularMensalidade(800, false, 20));