using Microsoft.VisualBasic;
using System.Security.Cryptography.X509Certificates;

namespace ConsoleApp2
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
            int itérations=0;
            while (!movesAreDone && i < moves.Length)
            {
                Console.WriteLine("mouvement ou pas de danse ('done' pour finir) : ");
                
                input = Console.ReadLine();

                if (input == "done")
                {
                    movesAreDone = true;
                        break;
                }
                else
                {
                    moves[i] = input;
                    
                    Console.WriteLine("ecrire un chiffre pour le nombre de fois : ");
                        itérations = int.Parse(Console.ReadLine());
                    int k = i;
                    while ( k < i + itérations)
                    {
                        
                            
                        if (!movesAreDone) {
                            
                            moves[k] = moves[i];
                            k = k + 1;
                            

                        }


                       ;
                    }

                 i = i + k;   
                }
                

            }

          

            for (int j = moves.GetLowerBound(0); j <= moves.GetUpperBound(0); j++)
                Console.Out.WriteLine(moves[j]);
             //   Console.WriteLine("   [{0,2}]: {1}", j, actions[j]);


                // Display the array elements.
                // for (int j = 0; j < actions.Length; j++)
                //{
                //    DisplayArray(actions);
                // Console.WriteLine(string.Join(" ", actions[j]));
                //}
        }
    }
}
