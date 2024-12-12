using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaFuncoes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int escolha = 0;

            Console.WriteLine("MENU\n");
            do
            {
                Console.WriteLine("1 - Retornador de 1, 0 e -1");
                Console.WriteLine("2 - Base e expoente");
                Console.WriteLine("3 - Fatorial");
                Console.WriteLine("4 - Verificador número primo");
                Console.WriteLine("5 - Imprimir data");
                switch (escolha)
                {
                    case 1:
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    case 5:
                        break;
                    default:
                        break;
                
                }

            } while (escolha != 6);
            
        }
        static int Conversor(int num)
        {
            if (num > 0)
            {
                return 1;
            }
            else if (num < 0)
            {
                return -1;
            } 
            else
            {
                return 0;
            }
            
        }
    }
}
