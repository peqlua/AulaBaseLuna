 using System;
using static Helpers;

class Jogo
{
    public Jogo()
    {

        String numero = Read("quanto é quarenta e sete mais quarenta e um?");
        if (numero == "88")
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