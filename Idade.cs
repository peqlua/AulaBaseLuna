using System;
using static Helpers;

class Idade
{
    public Idade()
    {
        String idade = Read("qual é a minha idade?");
        if (idade == "8")
        {
            Write("Parabens você acertou😋😺");
            Dino();
            Heart();
        }
        else
        {
            Write("você errou🙁😿");
        }

    }
}