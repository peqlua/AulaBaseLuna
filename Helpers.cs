using System;
using System.Threading.Tasks;
using System.Collections.Generic;

static class Helpers
{

    public static int Random(int start = 1, int end = 10)
    {
        Random randNum = new Random();
        return randNum.Next(start, end);
    }

    public static void Big(string text)
    {
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Dictionary<string, string[]> letras = new Dictionary<string, string[]>();
      
        letras.Add("A", new string[]{
          "     A     ",
          "  AA   AA  ",
          "AA       AA",
          "AAAAAAAAAAA",
          "AA       AA"
        });
      
        letras.Add("B", new string[]{
          "BBBBBBBBB   ",
          "BB       BB ",
          "BBBBBBBBBB  ",
          "BB        BB",
          "BBBBBBBBBBB "
        });
        letras.Add("C", new string[]{
          "cccccccc   ",
          "cc         ",
          "cc         ",
          "cc         ",
          "cccccccc   "
        });

        letras.Add("D", new string[]{
          "ddddddddddd ",
          "  dd       d",
          "  dd       d",
          "  dd       d",
          "ddddddddddd "
        });

        letras.Add("E", new string[]{
          "eeeeeeeeeee ",
          "e           ",
          "eeeeeeeeee  ",
          "e           ",
          "eeeeeeeeeee "
        });

        letras.Add("F", new string[]{
          "fffffffffff ",
          "f           ",
          "fffffffffff ",
          "f           ",
          "f           ",
          "f           "
        });

        letras.Add("G", new string[]{
          "ggggggggggg ",
          "gg          ",
          "gg          ",
          "gg      gggg",
          "gg        gg",
          "gggggggggggg"
        });




































      

        letras.Add("O", new string[]{
          " oooooooooo ",
          "o          o",
          "o          o",
          "o          o",
          " oooooooooo "
        });

        letras.Add("P", new string[]{
          "pppppppppp   ",
          "pp       p   ",
          "pp       p   ",
          "pppppppppp   ",
          "pp           ",
          "pp           ",
          "pp           " 
        });

        letras.Add("I", new string[]{
          "      ii    ",
          "            ",
          "      ii    ",
          "      ii    ",
          "      ii    ",
          "      ii    "
        });




      
        List<string[]> textBig = new List<string[]>();
        char[] pic = text.ToUpper().ToCharArray();
        foreach (char p in pic)
        {
            textBig.Add(letras[p.ToString()]);
        }

        var i = 0;
        foreach (string linha in letras["A"])
        {
            string linhaTotal = "";
            foreach (string[] l in textBig)
            {

                linhaTotal = linhaTotal + "    " + l[i];
            }
            i++;
            Console.WriteLine(linhaTotal);
        }

        Console.ResetColor();
    }

    public static void Line()
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("________________________________________");
        Console.ResetColor();
    }

    public static void Head()
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("======================================= ");
        Console.ResetColor();
    }

    public static async Task WriteEffect(string text)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        char[] array = text.ToCharArray();
        string total = ":: ";
        foreach (var letter in array)
        {
            total = total + letter;
            Clear();
            Console.WriteLine(total); await Task.Delay(100);
        }
        Console.ResetColor();
        // Read("pause<ENTER>");
    }



    public static void Write(string text)
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine(":> " + text);
        Console.ResetColor();
    }

    public static void Write(int text)
    {
        Write(text.ToString());
    }

    public static string Read(string msg = "Digite um texto")
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.Write(msg + ": ");
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.BackgroundColor = ConsoleColor.DarkMagenta;
        string result = Console.ReadLine();
        Console.ResetColor();
        return result;
    }

    public static int ReadInt(string msg = "Digite um número")
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.Write(msg + ": ");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.BackgroundColor = ConsoleColor.DarkGreen;
        string result = Console.ReadLine();
        Console.ResetColor();
        return Convert.ToInt32(result);
    }

    public static void Clear()
    {
        System.Console.Clear();
    }

    public static void Heart()
    {
        Console.ForegroundColor = ConsoleColor.DarkMagenta;
        Console.WriteLine("  ███████    ███████");
        Console.WriteLine("██████████  ███████████");
        Console.WriteLine("███████████████████████");
        Console.WriteLine("███████████████████████");
        Console.WriteLine(" █████████████████████");
        Console.WriteLine("   █████████████████");
        Console.WriteLine("     ████████████");
        Console.WriteLine("        ██████");
        Console.WriteLine("          ██");
        Console.ResetColor();
    }
    public static void Smile()
    {
        Console.ForegroundColor = ConsoleColor.DarkMagenta;
        Console.WriteLine("    █████    █████  ");
        Console.WriteLine("   ███████  ███████");
        Console.WriteLine("   ███████  ███████");
        Console.WriteLine("          ██          ");
        Console.WriteLine(" ███      ██      ███");
        Console.WriteLine("   ███          ███");
        Console.WriteLine("     ████████████");
        Console.ResetColor();
    }
    public static void Dino()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("             ██████████");
        Console.WriteLine("            ██  ████████");
        Console.WriteLine("            ████████████");
        Console.WriteLine("            ███████");
        Console.WriteLine("            ██████████");
        Console.WriteLine("            ██████");
        Console.WriteLine("            ██████");
        Console.WriteLine("            ██████");
        Console.WriteLine("            ██████");
        Console.WriteLine("            ██████");
        Console.WriteLine("  █████████████████");
        Console.WriteLine("█████████████████████");
        Console.WriteLine("██ ███████████████████");
        Console.WriteLine("██  ████ ██   ███  ███");
        Console.WriteLine("█    ███ ██   ███  ███");
        Console.WriteLine("█   ██  ██     ██   ██");
        Console.WriteLine("    ███ ███    ███  ███");
        Console.ResetColor();
    }

}