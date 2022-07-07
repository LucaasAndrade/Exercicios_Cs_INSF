// 23. Implementar uma função que informe qual a situação de um candidato de vestibular a partir da nota que ele tirou, da nota de corte e nota mínima para aprovação. Considere as regras abaixo:
// - Se a nota for menor que a nota de corte: "Candidato não passou"
// - Se a nota for maior ou igual a nota de aprovação: "Candidato aprovado"
// - Se a nota estiver entre a nota de corte e a nota mínima de aprovação: "Candidato está na lista de espera"


string SituacaoCandidato(int notaCandidato, int notaCorte, int notaMinima)
{
    if(notaCandidato < notaCorte)
        return "Cadidato não passou";
    else if(notaCandidato > notaCorte && notaCandidato < notaMinima)
        return "Candidato está na lista de espera";
    else if(notaCandidato >= notaCorte)
        return "Candidato aprovado";
    else
        return "Canditado Reprovado";
}

Console.WriteLine(SituacaoCandidato(3, 4, 7));