// 7. Implementar uma função para verificar se deve-se ir ao parque, sim ou não. Para ir ao parque, a temperatura atual deve estar entre 23 e 30 graus (maior igual a 23 e menor igual a 30).

bool IrAoParque(int temperatura)
{
    return temperatura > 23 && temperatura < 30;
}

Console.WriteLine(IrAoParque(38));