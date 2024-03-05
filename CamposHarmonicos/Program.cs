using System;

namespace CamposHarmonicos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string C = "C, Dm, E, F, G7, Am, Bmb5";
            string D = "D, Em, F#m, G, A7, Bm, C#mb5";
            string E = "E, F#m, G#m, A, B7, C#m, D#mb5";
            string F = "F, Gm, Am, Bb, C7, Dm, Em(b5)";
            string G = "G, Am, Bm, C, D7, Em, F#mb5";
            string A = "A, Bm, C#m, D, E7, F#m, G#m(b5)";
            string B = "B, C#m, D#m, E, F#7, G#m, A#m(b5)";

            Console.Write("Digite o Campo Harmônico que deseja: ");
            string input = Console.ReadLine().Trim().ToLower();  // Remover espaços e converter para minúsculas

            switch (input)
            {
                case "c":
                    Console.WriteLine($"{C}");
                    break;
                case "d":
                    Console.WriteLine($"{D}");
                    break;
                case "e":
                    Console.WriteLine($"{E}");
                    break;
                case "f":
                    Console.WriteLine($"{F}");
                    break;
                case "g":
                    Console.WriteLine($"{G}");
                    break;
                case "a":
                    Console.WriteLine($"{A}");
                    break;
                case "b":
                    Console.WriteLine($"{B}");
                    break;
                default:
                    Console.WriteLine("Digite a Nota certa");
                    break;
            }
        }
    }
}