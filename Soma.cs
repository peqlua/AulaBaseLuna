using System;
using static Helpers;

class Soma
{
    public Soma()
    {
        int numero1 = ReadInt("digite um numero");
        int numero2 = ReadInt("digite um numero que queira somar com o outro");
        int soma = numero1 + numero2;
        Write("numero1 + numero2 = " + soma);

    }
}