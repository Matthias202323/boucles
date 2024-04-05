
using Microsoft.VisualBasic;
using System.Security.Cryptography.X509Certificates;
namespace ConsoleApp5

{
    internal class Program
    {

        static void DisplayArray(string[] arr) => Console.WriteLine(string.Join(" ", arr));
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            string[] moves = new string[32];
            bool movesAreDone = false;

            int i = 0;
            string input = "";
            int itérations = 0;
            while (!movesAreDone && i < moves.Length)
            {
                Console.WriteLine("mouvement ou pas de danse ('done' pour finir) : ");

                input = Console.ReadLine();

                if (input == "done")
                {
                    movesAreDone = true;
                    
                }
                else
                {
                    moves[i] = input;

                    Console.WriteLine("ecrire un chiffre pour le nombre de fois : ");
                    itérations = int.Parse(Console.ReadLine());
                    int k = 0;
                    while (k < itérations)
                    {


                        if (!movesAreDone)
                        {

                            moves[i+k] = input;

                            k = k + 1;

                        }

                        

                    }

                i = i + k;
                   
                }
                

            }



            for (int j = moves.GetLowerBound(0); j <= moves.GetUpperBound(0); j++)
                Console.Out.WriteLine(moves[j]);
         
        }
    }
}

