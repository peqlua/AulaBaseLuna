using System;
using static Helpers;

class JogoFixe
{
    public JogoFixe()
    {

        String resposta = Read("O paiblo é:");
        if (resposta == "forte")
        {
            Write("Parabens você acertou😋😺");
            Dino();
            Heart();
        }
        else
        {
            Write("você errou🙁😿");

        }
        Read("Sair ?");
    }
}