using System;
using static Helpers;

class CoisaDificil
{
    public CoisaDificil()
    {
        int numero1 = ReadInt("Digite um numero");
        int numero2 = ReadInt("Digite um numero que queira somar com o outro");
        int soma = numero1 + numero2;
        Write("o resultado e " + soma);
    }
}