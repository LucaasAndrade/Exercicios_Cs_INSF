// 24. Implementar uma função que avalie a temperatura corporal de uma pessoa a partir da sua temperatura. A função deve retornar uma classificação seguindo as orientações abaixo:
// - Temperatura menor que 37 graus: "Temperatura normal"
// - Temperatura até 37,5 graus: "Febrícula"
// - Temperatura de 37,6 a 38,5: "Febre moderada"
// - Temperatura acima de 38,5: "Febre alta"


string AferirTemperatura(int temperatura)
{
    if(temperatura < 37)
        return  "Febre Normal";
    else if(temperatura <= 37.5)
        return "Febrícula";
    else if(temperatura <= 38.5)
        return "Febre moderada";
    else if(temperatura >= 38.5)
        return "Febre alta";
}

Console.WriteLine(AferirTemperatura(38));