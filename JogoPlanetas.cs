using System;
using static Helpers;

class JogoPlanetas
{
    public JogoPlanetas()
    {

   String planeta = Read("qual é o planeta que está no 3 planeta de distancia da terra (sem ver a resposta)");

       // Read("Sair ?");
if(planeta == "saturno")
{
    
  Write("voçê acertou");
  Dino();
  Heart();        }
        else
        {
  Write("você errou");

        };
        
    }
}