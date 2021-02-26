using System;
namespace EX3
{
    public class InvestimentoSemIR : Investimento
    {
        public override double calcularLucro(int meses)
        {
            if(valorInicial < 1000){
                Console.WriteLine("O valor inicial não pode ser menor do que R$ 1.000");
                return 0;
            } else {
            return (valorInicial * Math.Pow(1 + jurosMensais, meses) - valorInicial);
            }
        }

    }   
    }