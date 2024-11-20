using System;
using RefactLibrary;

namespace RefactorFork
{
    public class Program
    {
        public static void Main()
        {
            const string TextAskNumInputs = "Escull introduir la quantitat de nombres entre 15 i 100: ";
            const string TextNextNumber = "Introdueix el següent número, {0}: ";
            const string TextFinalProduct = "El producte de cada un dels números és: ";
            const string FormatError = "El format introduït no és correcte.";
            const int RangeMax = 100;
            const int RangeMin = 15;

            int numInputs = 0;
            int productAllNumbers;
            bool validNum;

            //Entra nombre de inputs i comprova si està en rang i en format correcte :D
            do
            {
                Console.Write(TextAskNumInputs);
                try
                {
                    numInputs = Convert.ToInt32(Console.ReadLine());
                    validNum = Refact.ValidateInRange(numInputs, RangeMin, RangeMax);
                }
                catch (FormatException)
                {
                    Console.WriteLine(FormatError);
                    validNum = false;
                }
            } while (!validNum);

            //Recompte de números introduïts per l'usuari
            int[] numsToCatch = new int[numInputs];

            for (int i = 0; i < numInputs; i++)
            {
                do
                    try
                    {
                        Console.Write(string.Format(TextNextNumber, i + 1));
                        numsToCatch[i] = Convert.ToInt32(Console.ReadLine());
                        validNum = true;
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine(FormatError);
                        validNum = false;
                    }
                while (!validNum);
            }

            //Output final
            productAllNumbers = Refact.ProductArrayContent(numsToCatch);
            Console.WriteLine($"{TextFinalProduct}{productAllNumbers}");
        }
    }
}