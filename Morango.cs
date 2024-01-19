using System;
using static Helpers;

class Morango
{
    public Morango()
    {


int n1 = Random(1, 10);
    int n2 = Random(1, 10);
    int solucao = n1 * n2;
    int tentativa = ReadInt("quanto è "+n1+" * "+n2+"?");

    if(solucao == tentativa){               
    Write("👾parabens👾");                 }
    else
    {
        Write("😓☠️😭tu erraste😭☠️😓");
    }

  }
}