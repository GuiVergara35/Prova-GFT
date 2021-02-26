using System;

namespace EX1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Bem vindo ao exercício 1 da prova técnica do processo GFT_Start!");
            int somatoria = 0;

            while (somatoria < 300){
                Console.Write("Digite um número:");
                Int32.TryParse(Console.ReadLine(), out int valor);
                    if (valor < 0){
                        Console.WriteLine("Valores negativos não são permitidos!");
                    } else {
                        somatoria += valor;
                    }
                }
                Console.WriteLine($"A somatória total é igual a {somatoria}"); 
            }

            
        }
    }

