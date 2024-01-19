using System;
using static Helpers;

class TestaIdade
{
    public TestaIdade()
    {
        int idade = ReadInt("digite sua idade");
        // JOVENS ===========================================
        if (idade > 16)
        {
            Write("JÁ TEM FAMÍLIA👨‍👨‍👧‍👧");
            // VELHOS ====================
            if (idade > 50)
            {
                Write("QUE VELHO👴!!!");
            }
            //============================
        }
        //========================================

        if (idade < 16)
        {
            Write("es UM/UMA pré adolecente👱👱‍♀️ 👨‍🎓👩‍🎓");
        }
        if (idade < 11)
        {
            Write("aproveita a tua infancia👧🧑");
        }
        if (idade < 5)
        {
            Write("gu gu dada / voçê é um bebé👶");
        }
    }
}